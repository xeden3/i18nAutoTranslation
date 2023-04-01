namespace I18nAutoTranslation
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listInventoryData = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Node = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lb_key_count = new System.Windows.Forms.Label();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_start_trans = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.prog_trans = new System.Windows.Forms.ProgressBar();
            this.lb_prog_trans = new System.Windows.Forms.Label();
            this.btn_stop_trans = new System.Windows.Forms.Button();
            this.btn_open_other_lang = new System.Windows.Forms.Button();
            this.chk_not_all = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listInventoryData
            // 
            this.listInventoryData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.CN,
            this.EN,
            this.JP,
            this.KO,
            this.PL,
            this.Node});
            this.listInventoryData.FullRowSelect = true;
            this.listInventoryData.GridLines = true;
            this.listInventoryData.HideSelection = false;
            this.listInventoryData.Location = new System.Drawing.Point(12, 12);
            this.listInventoryData.Margin = new System.Windows.Forms.Padding(4);
            this.listInventoryData.Name = "listInventoryData";
            this.listInventoryData.Size = new System.Drawing.Size(1010, 846);
            this.listInventoryData.TabIndex = 0;
            this.listInventoryData.UseCompatibleStateImageBehavior = false;
            this.listInventoryData.View = System.Windows.Forms.View.Details;
            // 
            // No
            // 
            this.No.Text = "No";
            this.No.Width = 36;
            // 
            // CN
            // 
            this.CN.Text = "CN(KEY)";
            this.CN.Width = 107;
            // 
            // EN
            // 
            this.EN.Text = "EN";
            this.EN.Width = 94;
            // 
            // JP
            // 
            this.JP.Text = "JP";
            this.JP.Width = 81;
            // 
            // KO
            // 
            this.KO.Text = "KO";
            this.KO.Width = 92;
            // 
            // PL
            // 
            this.PL.Text = "PL";
            this.PL.Width = 83;
            // 
            // Node
            // 
            this.Node.Text = "Node";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 888);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "总词条数";
            // 
            // lb_key_count
            // 
            this.lb_key_count.AutoSize = true;
            this.lb_key_count.Location = new System.Drawing.Point(152, 888);
            this.lb_key_count.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_key_count.Name = "lb_key_count";
            this.lb_key_count.Size = new System.Drawing.Size(22, 24);
            this.lb_key_count.TabIndex = 2;
            this.lb_key_count.Text = "0";
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(1036, 12);
            this.btn_open.Margin = new System.Windows.Forms.Padding(6);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(238, 46);
            this.btn_open.TabIndex = 3;
            this.btn_open.Text = "打开中文Json";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_start_trans
            // 
            this.btn_start_trans.Location = new System.Drawing.Point(1036, 232);
            this.btn_start_trans.Margin = new System.Windows.Forms.Padding(6);
            this.btn_start_trans.Name = "btn_start_trans";
            this.btn_start_trans.Size = new System.Drawing.Size(238, 46);
            this.btn_start_trans.TabIndex = 4;
            this.btn_start_trans.Text = "开始翻译";
            this.btn_start_trans.UseVisualStyleBackColor = true;
            this.btn_start_trans.Click += new System.EventHandler(this.btn_start_trans_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(1036, 136);
            this.btn_save.Margin = new System.Windows.Forms.Padding(6);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(238, 46);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "导出翻译后文件夹";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // prog_trans
            // 
            this.prog_trans.Location = new System.Drawing.Point(292, 888);
            this.prog_trans.Margin = new System.Windows.Forms.Padding(6);
            this.prog_trans.Name = "prog_trans";
            this.prog_trans.Size = new System.Drawing.Size(734, 24);
            this.prog_trans.TabIndex = 6;
            // 
            // lb_prog_trans
            // 
            this.lb_prog_trans.AutoSize = true;
            this.lb_prog_trans.BackColor = System.Drawing.Color.Transparent;
            this.lb_prog_trans.Cursor = System.Windows.Forms.Cursors.No;
            this.lb_prog_trans.Location = new System.Drawing.Point(1056, 888);
            this.lb_prog_trans.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_prog_trans.Name = "lb_prog_trans";
            this.lb_prog_trans.Size = new System.Drawing.Size(22, 24);
            this.lb_prog_trans.TabIndex = 7;
            this.lb_prog_trans.Text = "-";
            // 
            // btn_stop_trans
            // 
            this.btn_stop_trans.Enabled = false;
            this.btn_stop_trans.Location = new System.Drawing.Point(1036, 290);
            this.btn_stop_trans.Margin = new System.Windows.Forms.Padding(6);
            this.btn_stop_trans.Name = "btn_stop_trans";
            this.btn_stop_trans.Size = new System.Drawing.Size(238, 46);
            this.btn_stop_trans.TabIndex = 8;
            this.btn_stop_trans.Text = "停止翻译";
            this.btn_stop_trans.UseVisualStyleBackColor = true;
            this.btn_stop_trans.Click += new System.EventHandler(this.btn_stop_trans_Click);
            // 
            // btn_open_other_lang
            // 
            this.btn_open_other_lang.Location = new System.Drawing.Point(1032, 78);
            this.btn_open_other_lang.Margin = new System.Windows.Forms.Padding(6);
            this.btn_open_other_lang.Name = "btn_open_other_lang";
            this.btn_open_other_lang.Size = new System.Drawing.Size(238, 46);
            this.btn_open_other_lang.TabIndex = 9;
            this.btn_open_other_lang.Text = "导入翻译后文件夹";
            this.btn_open_other_lang.UseVisualStyleBackColor = true;
            this.btn_open_other_lang.Click += new System.EventHandler(this.btn_open_other_lang_Click);
            // 
            // chk_not_all
            // 
            this.chk_not_all.AutoSize = true;
            this.chk_not_all.Location = new System.Drawing.Point(1036, 354);
            this.chk_not_all.Name = "chk_not_all";
            this.chk_not_all.Size = new System.Drawing.Size(258, 28);
            this.chk_not_all.TabIndex = 10;
            this.chk_not_all.Text = "已有翻译的不再翻译";
            this.chk_not_all.UseVisualStyleBackColor = true;
            this.chk_not_all.CheckedChanged += new System.EventHandler(this.chk_not_all_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 946);
            this.Controls.Add(this.chk_not_all);
            this.Controls.Add(this.btn_open_other_lang);
            this.Controls.Add(this.btn_stop_trans);
            this.Controls.Add(this.lb_prog_trans);
            this.Controls.Add(this.prog_trans);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_start_trans);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.lb_key_count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listInventoryData);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "I18nAutoTranslation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listInventoryData;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader CN;
        private System.Windows.Forms.ColumnHeader EN;
        private System.Windows.Forms.ColumnHeader JP;
        private System.Windows.Forms.ColumnHeader KO;
        private System.Windows.Forms.ColumnHeader PL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_key_count;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_start_trans;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ProgressBar prog_trans;
        private System.Windows.Forms.Label lb_prog_trans;
        private System.Windows.Forms.Button btn_stop_trans;
        private System.Windows.Forms.Button btn_open_other_lang;
        private System.Windows.Forms.CheckBox chk_not_all;
        private System.Windows.Forms.ColumnHeader Node;
    }
}

