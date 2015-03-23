using CodeGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeGenerator.Template
{
    public partial class IDataAccessTemplate
    {
        public List<FieldModel> fieldList { get; set; }

        public string tableName { get; set; }

        public string description { get; set; }

        public string keyName { get; set; }

        public string keyType { get; set; }

        public IDataAccessTemplate(List<FieldModel> _fieldList, TableModel _tableModel)
        {
            this.fieldList = _fieldList;
            this.tableName = _tableModel.Name;
            this.description = string.IsNullOrEmpty(_tableModel.Description) ? "" : _tableModel.Description;
            this.keyName = _fieldList.Where(o => o.IsPk == 1).FirstOrDefault().Name;
            //this.keyType = StringHelper.GetCSharpType(_fieldList.Single(o => o.IsPk == 1).Type);
        }
    }
}