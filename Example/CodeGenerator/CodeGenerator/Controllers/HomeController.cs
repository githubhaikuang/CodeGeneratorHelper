using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;

namespace CodeGenerator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetTableList()
        {
            List<Models.TableModel> tableList = new List<Models.TableModel>();
            tableList = new DataAccess.GenerateDataAccess().GetTableList();
            var list = tableList == null ? new List<Models.ZTreeModel>() : tableList.Select(o => new Models.ZTreeModel { id = o.Name, pId = "0", name = o.Name + " -- " + o.Description, @checked = false });
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GenerateCode(string data, bool isOnlyModel)
        {

            var changeList = (List<Models.ZTreeModel>)JsonConvert.DeserializeObject(data, typeof(List<Models.ZTreeModel>));

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in changeList)
            {
                try
                {
                    if (isOnlyModel)
                    {
                        Impl.GenerateImpl.GenerateModel(item.id);
                    }
                    else
                    {
                        Impl.GenerateImpl.GenerateDataAccess(item.id);
                    }
                    stringBuilder.AppendFormat("<p>表[{0}]生成成功</p>", item.id);
                }
                catch (Exception ex)
                {
                    stringBuilder.AppendFormat("<p style='color:red;'>表[{0}]生成失败，原因如下：{1}</p>", item.id, ex.Message);
                }
            }

            return Json(new { IsSuccess = true, ErrorInfo = stringBuilder.ToString() }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GenerateDBContext()
        {
            string ErrorInfo = string.Empty;
            try
            {
                Impl.GenerateImpl.GenerateDbContext();
                ErrorInfo = "<p>DBContext 生成成功</p>";
            }
            catch (Exception ex)
            {
                ErrorInfo = string.Format("<p style='color:red;'>DBContext 生成失败，原因如下：{0}</p>", ex.Message);
            }

            return Json(new { IsSuccess = true, ErrorInfo = ErrorInfo }, JsonRequestBehavior.AllowGet);
        }
    }
}
