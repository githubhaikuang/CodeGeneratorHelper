﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本: 12.0.0.0
//  
//     对此文件的更改可能会导致不正确的行为。此外，如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace CodeGenerator.Template
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using CodeGenerator.Utility;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "H:\Users\tianwei\Desktop\新建文件夹 (3)\CodeGenerator\Template\DbContextTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class DbContextTemplate : DbContextTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("/*\r\n * --------------------------------------------------------------------------" +
                    "-----\r\n * 版权信息：\t奥鹏教育（open.com.cn）\t版权所有\t");
            
            #line 10 "H:\Users\tianwei\Desktop\新建文件夹 (3)\CodeGenerator\Template\DbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DateTime.Now.ToString("yyyy")));
            
            #line default
            #line hidden
            this.Write("\r\n * 功能描述：\t代码处成器生成\r\n * \r\n * 创建人：　\t代码生成\r\n * 创建日期：\t");
            
            #line 14 "H:\Users\tianwei\Desktop\新建文件夹 (3)\CodeGenerator\Template\DbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
            
            #line default
            #line hidden
            this.Write("\r\n * 创建说明：\t\r\n * \r\n * 修改人：　\t\r\n * 修改日期：\t\r\n * 修改说明：\t\r\n *    \r\n * -------------------" +
                    "------------------------------------------------------------\r\n */\r\nusing System." +
                    "Data.Entity;\r\nusing System.Data.Entity.Infrastructure;\r\nusing ");
            
            #line 25 "H:\Users\tianwei\Desktop\新建文件夹 (3)\CodeGenerator\Template\DbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Config.BusinessEntitiesClass));
            
            #line default
            #line hidden
            this.Write(";\r\nusing ");
            
            #line 26 "H:\Users\tianwei\Desktop\新建文件夹 (3)\CodeGenerator\Template\DbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Config.NameSpace));
            
            #line default
            #line hidden
            this.Write(".Enums;\r\nusing ");
            
            #line 27 "H:\Users\tianwei\Desktop\新建文件夹 (3)\CodeGenerator\Template\DbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Config.NameSpace));
            
            #line default
            #line hidden
            this.Write(".Utility;\r\nusing ");
            
            #line 28 "H:\Users\tianwei\Desktop\新建文件夹 (3)\CodeGenerator\Template\DbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Config.NameSpace));
            
            #line default
            #line hidden
            this.Write(".Config;\r\nusing System.Data.Common;\r\n\r\nnamespace ");
            
            #line 31 "H:\Users\tianwei\Desktop\新建文件夹 (3)\CodeGenerator\Template\DbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Config.NameSpace));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 31 "H:\Users\tianwei\Desktop\新建文件夹 (3)\CodeGenerator\Template\DbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Config.DataAccessSuffix));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    /// <summary>\r\n    ///   数据访问层上下文\r\n    /// </summary>\r\n    public partia" +
                    "l class ");
            
            #line 36 "H:\Users\tianwei\Desktop\新建文件夹 (3)\CodeGenerator\Template\DbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utility.Config.DBContext));
            
            #line default
            #line hidden
            this.Write(" : DbContext\r\n    {\r\n\r\n\t   static ");
            
            #line 39 "H:\Users\tianwei\Desktop\新建文件夹 (3)\CodeGenerator\Template\DbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utility.Config.DBContext));
            
            #line default
            #line hidden
            this.Write("()\r\n        {\r\n            Database.SetInitializer<");
            
            #line 41 "H:\Users\tianwei\Desktop\新建文件夹 (3)\CodeGenerator\Template\DbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utility.Config.DBContext));
            
            #line default
            #line hidden
            this.Write(">(null);\r\n        }\r\n\r\n        public ");
            
            #line 44 "H:\Users\tianwei\Desktop\新建文件夹 (3)\CodeGenerator\Template\DbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Utility.Config.DBContext));
            
            #line default
            #line hidden
            this.Write("(WriteRead writeRead)\r\n            : base(writeRead == WriteRead.Write ? DBConfig" +
                    ".Write : DBConfig.Read)\r\n        {\r\n        }\r\n\r\n\t\t");
            
            #line 49 "H:\Users\tianwei\Desktop\新建文件夹 (3)\CodeGenerator\Template\DbContextTemplate.tt"

    foreach(var table in tableList)
    {
		
            
            #line default
            #line hidden
            this.Write("        \r\n        /// <summary>\r\n        /// ");
            
            #line 55 "H:\Users\tianwei\Desktop\新建文件夹 (3)\CodeGenerator\Template\DbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(table.Description!=null?table.Description.Replace("\r","").Replace("\n",""):""));
            
            #line default
            #line hidden
            this.Write("数据访问上下文\r\n        /// </summary>\r\n\t\tpublic DbSet<");
            
            #line 57 "H:\Users\tianwei\Desktop\新建文件夹 (3)\CodeGenerator\Template\DbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(table.Name));
            
            #line default
            #line hidden
            this.Write("> ");
            
            #line 57 "H:\Users\tianwei\Desktop\新建文件夹 (3)\CodeGenerator\Template\DbContextTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(table.Name));
            
            #line default
            #line hidden
            this.Write(" { get; set; }\r\n\t\t");
            
            #line 58 "H:\Users\tianwei\Desktop\新建文件夹 (3)\CodeGenerator\Template\DbContextTemplate.tt"
 
    }
		
            
            #line default
            #line hidden
            this.Write("\r\n    }\r\n}\r\n ");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class DbContextTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
