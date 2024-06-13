using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shop.BackAdmin
{
    public partial class UsersLists : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var LstUsers = (List<Users>)Application["Users"];
                RptUsers.DataSource = LstUsers;
                RptUsers.DataBind();
            }
             
        }
    }
}