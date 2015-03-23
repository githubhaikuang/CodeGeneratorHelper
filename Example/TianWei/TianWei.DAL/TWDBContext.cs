/*
 * -------------------------------------------------------------------------------
 * 版权信息：	韩天伟（hantianwei.cn）	版权所有	2015
 * 功能描述：	代码处成器生成
 * 
 * 创建人：　	代码生成
 * 创建日期：	2015-03-23 23:01:25
 * 创建说明：	
 * 
 * 修改人：　	
 * 修改日期：	
 * 修改说明：	
 *    
 * -------------------------------------------------------------------------------
 */
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using TianWei.Model;
using TianWei.Enums;
using TianWei.Utility;
using System.Data.Common;

namespace TianWei.DAL
{
    /// <summary>
    ///   数据访问层上下文
    /// </summary>
    public partial class TWDBContext : DbContext
    {

	    static TWDBContext()
        {
            Database.SetInitializer<TWDBContext>(null);
        }

        public TWDBContext(WriteRead writeRead)
            : base(writeRead == WriteRead.Write ? DBConfig.Write : DBConfig.Read)
        {
        }

		        
   
    }
}
