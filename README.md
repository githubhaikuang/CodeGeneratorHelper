### CodeGeneratorHelper 简介
    
    T4代码生成器，其中包括一个独立版代码生成器，不依赖其它项目及可；还有一个是T4模板的扩展
    有很多不完善处欢迎大家一起完善，如有问题也请及时提出来一起解决，谢谢大家！
    
### 使用方法

    将两个文件：MultipleOutputHelper.ttinclude 和 CodeGeneratorHelper.ttinclude 引用到T4模板中
    
    <#@include file="$(ProjectDir)\MultipleOutputHelper.ttinclude"#>
    <#@include file="$(ProjectDir)\CodeGeneratorHelper.ttinclude"#> 
    
    再在模板中查询数据
    
    <#		
		  var manager = Manager.Create(Host, GenerationEnvironment);  
		  List<CodeGeneratorHelper.TableModel> tableList = CodeGeneratorHelper.GetTableList();
		  foreach(var tableModel in tableList)
		  {	
			  manager.StartNewFile(tableModel.Name +".cs");
			  List<CodeGeneratorHelper.FieldModel> fieldList = CodeGeneratorHelper.GetFieldList(tableModel.Name);
    #>
      ...这里是生成的代码模板
    <#
		  manager.EndBlock();    
      }
       manager.Process(true);  
    #> 
