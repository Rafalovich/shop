using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace shop
{
    public partial class ProductInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var list = (List<Product>)Application["Product"];
            
            if(!IsPostBack)
            {
                string Pid = Request["pid"] + "";
                if(Pid != "")
                {
                    for(int i = 0; i < list.Count; i++)
                    {
                        if(Pid == list[i].Pid+"")
                        {
                            LtlPname.Text = list[i].Pname;
                            LtlPrice.Text = list[i].Price+"";
                        }
                    }
                }
            }
        }
    }
}