using CodeGenerator.Models;
using CodeGenerator.Utility;
/*
 * -------------------------------------------------------------------------------
 * 版权信息：	奥鹏远程教育中心	版权所有	2013
 * 功能描述：	
 * 
 * 创建人：　	韩天伟(HanTw)
 * 创建日期：	2014/6/3 16:50:10
 * 创建说明：	
 * 
 * 修改人：　	
 * 修改日期：	
 * 修改说明：	
 *    
 * -------------------------------------------------------------------------------
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeGenerator.Template
{
    public partial class DataAccessTemplate
    {
        public List<FieldModel> fieldList { get; set; }

        public string tableName { get; set; }

        public string description { get; set; }

        public string keyName { get; set; }

        public string keyType { get; set; }

        public DataAccessTemplate(List<FieldModel> _fieldList, TableModel _tableModel)
        {
            this.fieldList = _fieldList;
            this.tableName = _tableModel.Name;
            this.description = string.IsNullOrEmpty(_tableModel.Description) ? "" : _tableModel.Description;
            this.keyName = _fieldList.Where(o => o.IsPk == 1).FirstOrDefault().Name;
            //this.keyType = StringHelper.GetCSharpType(_fieldList.Single(o => o.IsPk == 1).Type);
        }
    }
}