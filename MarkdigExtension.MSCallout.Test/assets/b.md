---
aliases: 
tags: [markdown, parser, markdig, callout]
star:
date created: January 6th 2023, 10:23:35 pm
date modified: January 9th 2023, 4:58:03 pm
---

## 描述问题

解析obsidian的callout文件块，首先描述分析callout的基本格式，可以参考obsidian的官方文档[^1]

基本的callout格式为：

> [! NOTE]+ Title 阿克苏就看 $\int _{a} f(x) \, dx$
> Contents
> > [! note]
> > aaa
> > aaa
> > > [! seealso]
> > > > [! abstract]

主要就是这种可以支持**类型+题目+折叠+嵌套**的格式


## 方案分析

`markdig`提供了一个默认的可以解析多重`quote`的parser，可以参考：`QuoteBlockParser`

主要难点是实现markdig的parser

### Callout类和对应的parser




## 参考

##### 引文


##### 脚注

[^1]: [Use callouts - Obsidian Help](https://help.obsidian.md/How+to/Use+callouts)
