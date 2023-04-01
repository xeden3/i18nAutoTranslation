# i18nAutoTranslation

[toc]

# 前言

我们很多项目都需要基于i18n的国际化支持，但当修改一个版本的时候，其他语言的json文件都需要同步调整，这让整个多语言的运维提供了很大的难度。

i18nAutoTranslation 是为了使运维更加简单而开发出来的，其中使用了Google Translation的API，所以在进行翻译的时候，需要 **`科学上网`** 🚩

# 软件基础结构和文件文件夹框架

![image](https://user-images.githubusercontent.com/38025067/229268641-151adf97-2cd6-4eaf-b5b1-792b2b5a7ada.png)


## 软件基础说明

i18nAutoTranslation 是以中文语言包为基础包，并且通过该语言包，自动翻译成英语，日语，韩语，波兰语四种语言；

所以打开中文json的是在做翻译之前的前置操作，必须要先进行`打开中文json`

其次，如果你想复用之前已经翻译过的文件包（英语，日语，韩语，波兰语），则需要进行`导入翻译后文件夹`

通过`导入翻译后文件夹`，即可打开之前翻译过的文件，如果某些KEY在原翻译文件中没有，则这个翻译为空。

## 翻译后文件夹结构

```
|-- 翻译后文件夹
    |-- en
    |   |-- translation.json
    |-- jp
    |   |-- translation.json
    |-- ko
    |   |-- translation.json
    |-- pl
        |-- translation.json

```

建议一般我们会在项目中使用 `local` 作为全球化的文件夹，并且里面会分 cn、en、jp、ko、pl、de 等语言包的子文件夹，结构如下

``` 
|-- local
    |-- cn
    |   |-- translation.json
    |-- en
    |   |-- translation.json
    |-- jp
    |   |-- translation.json
    |-- ko
    |   |-- translation.json
    |-- pl
        |-- translation.json

```

每次使用的时候，通过打开 cn\translation.json 和导入 i18n文件夹，即可进行后续的翻译维护

# 使用

打开软件，并`打开中文json`

![image](https://user-images.githubusercontent.com/38025067/229268650-f0f2e264-7373-42e3-b36a-d4ed30513614.png)


导入翻译后文件夹，选择原来被翻译后的文件夹，一般为cn文件夹上级的文件夹，`locales`

![image](https://user-images.githubusercontent.com/38025067/229268661-0ec6f415-01cd-4035-a349-f15de73dcbda.png)

![image](https://user-images.githubusercontent.com/38025067/229268668-99840710-10cb-42c8-87cb-0064f78e96c9.png)


点击开始翻译，则自动进行全部翻译，如果希望已经有的翻译不改变，则勾选`已有翻译不再翻译`

![image](https://user-images.githubusercontent.com/38025067/229268674-f936b543-f653-41f7-a9e8-bb16e23b4877.png)

最后点击`导出翻译后文件夹`，选择需要导出的位置，则可以生成最新的翻译结果

![image](https://user-images.githubusercontent.com/38025067/229268676-b5f21e84-9553-4ca7-a30c-d2f6668ad3ea.png)

# 注意事项

唯一需要注意的就是，翻译的时候，需要科学上网
