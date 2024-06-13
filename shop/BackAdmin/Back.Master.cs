using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shop.BackAdmin
{
    public partial class Back : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ClientLogin"] == null)
            {
                //Response.Redirect("/Login.aspx");
            }
        }
    }
}