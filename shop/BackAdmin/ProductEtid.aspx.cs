using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shop.BackAdmin
{
    public partial class ProductEtid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAddProd_Click(object sender, EventArgs e)
        {
            if (FlD.HasFile)//בדיקה האם נבחר קובץ
            {
                FlD.SaveAs(Server.MapPath("/Upload/Products/") + FlD.FileName);
            }
            //if(DDLCategory.)
        }
    }
}