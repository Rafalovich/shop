using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using BLL;

namespace shop
{
    /// <summary>
    /// Summary description for ExportProduct
    /// </summary>
    public class ExportProduct : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/csv";
            HttpContext.Current.Response.AddHeader("content-disposition", "attachment; filename=ProductList.xls");
            context.Response.Write("<table>");
            context.Response.Write("<tr><td>מספר מוצר</td><td>שם מוצר</td><td>מחיר</td><td>הערות</td><td>תמונה</td><tr>");
            List<Product> LstProduct= Product.GetAll();
            for (int i = 0; i < LstProduct.Count; i++)
            {
                context.Response.Write($"<tr><td>{LstProduct[i].Pid}</td><td>{LstProduct[i].Pname}</td><td>{LstProduct[i].Price}</td><td>{LstProduct[i].PDesc}</td><td>{LstProduct[i].PicName}</td></tr>");
            }

            context.Response.Write("</table>");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}