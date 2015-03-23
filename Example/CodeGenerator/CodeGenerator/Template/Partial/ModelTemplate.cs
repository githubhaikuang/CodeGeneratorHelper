using CodeGenerator.Models;
/*
 * -------------------------------------------------------------------------------
 * 版权信息：	奥鹏远程教育中心	版权所有	2013
 * 功能描述：	
 * 
 * 创建人：　	韩天伟(HanTw)
 * 创建日期：	2014/6/3 16:51:20
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
    public partial class ModelTemplate
    {
        public List<FieldModel> fieldList { get; set; }

        public string tableName { get; set; }

        public string description { get; set; }

        public ModelTemplate(List<FieldModel> _fieldList, TableModel _tableModel)
        {
            this.fieldList = _fieldList;
            this.tableName = _tableModel.Name;
            this.description = string.IsNullOrEmpty(_tableModel.Description) ? "" : _tableModel.Description;
        }
    }
}