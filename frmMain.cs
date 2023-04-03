using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace I18nAutoTranslation
{
    public partial class frmMain : Form
    {

        private JObject _json_obj = null;
        private bool _b_stop_trans = false;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "打开文件";
            dialog.Filter = "所有文件(*.*)|*.*";
            
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // 删除之前可能载入的数据
                listInventoryData.Items.Clear();
                
                string file = dialog.FileName;
                // MessageBox.Show(file);
                _json_obj = open_json_file(file);

                listInventoryData.BeginUpdate();
                int count = _json_obj.Descendants().OfType<JValue>().Count();
                prog_trans.Maximum = count;

                foreach (JValue value in _json_obj.Descendants().OfType<JValue>())
                {
                    ListViewItem item = new ListViewItem();
                    //序号
                    item.Text = (listInventoryData.Items.Count + 1) + "";
                    //CN
                    item.SubItems.Add(value.ToString());
                    //EN
                    item.SubItems.Add("");
                    //JP
                    item.SubItems.Add("");
                    //KO
                    item.SubItems.Add("");
                    //PL
                    item.SubItems.Add("");
                    //Node
                    item.SubItems.Add(value.Path.ToString());

                    listInventoryData.Items.Add(item);
                    Console.WriteLine(value.ToString());
                    prog_trans.Value ++;
                }
                prog_trans.Value = 0;
                listInventoryData.EndUpdate();
            }
        }

        private void save_json_folder(string file_path, JObject jobj) 
        {
            // 分别保存4组翻译结果
            save_json_file_by_trans_lang(file_path, "en", 2, jobj);
            save_json_file_by_trans_lang(file_path, "jp", 3, jobj);
            save_json_file_by_trans_lang(file_path, "ko", 4, jobj);
            save_json_file_by_trans_lang(file_path, "pl", 5, jobj);
        }

        private void save_json_file_by_trans_lang(string path, string lang, int subitem_idx, JObject mod_jobj) 
        {
            string new_path = path + "/" + lang;
            Directory.CreateDirectory(new_path);
            JObject new_jobj = new JObject();
            new_jobj = mod_jobj.DeepClone() as JObject;
            int idx = 0;
            foreach (JValue value in new_jobj.Descendants().OfType<JValue>())
            {
                value.Value = listInventoryData.Items[idx].SubItems[subitem_idx].Text;
                idx++;
            }
            File.WriteAllText(new_path + "/translation.json", new_jobj.ToString());
        }

        private JObject open_json_file(string file_path) 
        {
            try
            {
                using (System.IO.StreamReader file = System.IO.File.OpenText(file_path))
                {
                    using (JsonTextReader reader = new JsonTextReader(file))
                    {
                        JObject o = (JObject)JToken.ReadFrom(reader);
                        // var value = o[key].ToString();
                        return o;
                    }
                }
            }
            catch { }
            return null;

        }


        private void open_json_folder(string file_path, ref JObject en_jobj, ref JObject jp_jobj, ref JObject ko_jobj, ref JObject pl_jobj)
        {
            // 分别保存4组翻译结果
            en_jobj = open_json_file(file_path + "/en/translation.json");
            jp_jobj = open_json_file(file_path + "/jp/translation.json");
            ko_jobj = open_json_file(file_path + "/ko/translation.json");
            pl_jobj = open_json_file(file_path + "/pl/translation.json");
        }



        private void btn_start_trans_Click(object sender, EventArgs e)
        {
            // Initialize the translator
            Translator t = new Translator();
            btn_start_trans.Enabled = false;
            btn_stop_trans.Enabled = true;
            // Translate the text
            try
            {
                int idx = 0;
                int count = _json_obj.Descendants().OfType<JValue>().Count();
                prog_trans.Maximum = count;
                lb_key_count.Text = count.ToString();

                for (int i = 0; i < listInventoryData.Items.Count; i++)
                {
                    if (_b_stop_trans)
                        break;

                    string value = listInventoryData.Items[i].SubItems[1].Text.ToString();


                    listInventoryData.Items[idx].SubItems[2].Text = translate_lang_by_list_idx(chk_not_all.Checked, value.ToString(), listInventoryData.Items[idx].SubItems[2].Text, t, "Chinese", "English");
                    listInventoryData.Items[idx].SubItems[3].Text = translate_lang_by_list_idx(chk_not_all.Checked, value.ToString(), listInventoryData.Items[idx].SubItems[3].Text, t, "Chinese", "Japanese");
                    listInventoryData.Items[idx].SubItems[4].Text = translate_lang_by_list_idx(chk_not_all.Checked, value.ToString(), listInventoryData.Items[idx].SubItems[4].Text, t, "Chinese", "Korean");
                    listInventoryData.Items[idx].SubItems[5].Text = translate_lang_by_list_idx(chk_not_all.Checked, value.ToString(), listInventoryData.Items[idx].SubItems[5].Text, t, "Chinese", "Polish");

                    lb_prog_trans.Text = string.Format("{1}/{2} {0} mSec", (int)t.TranslationTime.TotalMilliseconds, idx, lb_key_count.Text);

                    listInventoryData.Update();

                    idx++;
                    prog_trans.Value += 1;
                    Application.DoEvents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                
                this.Cursor = Cursors.Default;
            }

            prog_trans.Value = 0;
            _b_stop_trans = false;
            btn_stop_trans.Enabled = false;
            btn_start_trans.Enabled = true;
        }

        private string translate_lang_by_list_idx(bool not_trans_if_have_word, string cn_word, string old_word, Translator t, string from_lang, string to_lang) 
        {
            string w = old_word;
            if (not_trans_if_have_word)
            {
                if (old_word == "")
                {
                    w = t.Translate(cn_word, from_lang, to_lang);
                }
            }
            else 
            {
                w = t.Translate(cn_word, from_lang, to_lang);
            }
            return w;
        }

        private void btn_stop_trans_Click(object sender, EventArgs e)
        {
            _b_stop_trans = true;
        }

        /// <summary>
        /// 保存Json翻译后的文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = dialog.SelectedPath;
                save_json_folder(path, _json_obj);
            }
        }


        /// <summary>
        /// 打开Json翻译后的文件夹，并将翻译对应到List里面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_open_other_lang_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = dialog.SelectedPath;
                JObject en_jobj = new JObject();
                JObject jp_jobj = new JObject();
                JObject ko_jobj = new JObject();
                JObject pl_jobj = new JObject();
                open_json_folder(path, ref en_jobj, ref jp_jobj, ref ko_jobj, ref pl_jobj);
                if(en_jobj!=null)
                    listInventoryData_update_by_jobject(2, en_jobj);
                if (jp_jobj != null)
                    listInventoryData_update_by_jobject(3, jp_jobj);
                if (ko_jobj != null)
                    listInventoryData_update_by_jobject(4, ko_jobj);
                if (pl_jobj != null)
                    listInventoryData_update_by_jobject(5, pl_jobj);

            }
        }

        private void listInventoryData_update_by_jobject(int subitem_idx, JObject jobj) 
        {
            listInventoryData.BeginUpdate();
            foreach (JValue value in jobj.Descendants().OfType<JValue>())
            {
                for (int i = 0; i < listInventoryData.Items.Count; i++)
                {
                    if (listInventoryData.Items[i].SubItems[6].Text.ToString() == value.Path.ToString())
                    {
                        listInventoryData.Items[i].SubItems[subitem_idx].Text = value.ToString();
                        break;
                    }

                }
            }
            listInventoryData.EndUpdate();
        }

        private void chk_not_all_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
