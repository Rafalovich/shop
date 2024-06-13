using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shop
{
    public partial class ListsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            //if (!IsPostBack)
            //{
            //    DDLCity.DataSource= LsCity;
            //    DDLCity.DataTextField = "CityName";
            //    DDLCity.DataValueField = "CityId";
            //    DDLCity.DataBind();
            //    DDLCity.Items.Insert(0, "בחר עיר");
            //    DDLProd.DataSource= LstProd;
            //    DDLProd.DataTextField = "Pname";
            //    DDLProd.DataValueField = "Pid";
            //    DDLProd.DataBind();
            //    DDLProd.Items.Insert(0, "בחר מוצר");
            //    for (int i = 1; i < 91; i++)
            //    {
            //        DDLNamber.Items.Add(new ListItem(i+""));
            //    }
            //}
        }
    }
}