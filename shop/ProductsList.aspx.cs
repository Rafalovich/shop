﻿using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shop
{
    public partial class ProductsList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var LstProd = (List<Product>)Application["Product"];

                RptProduct.DataSource= LstProd;
                RptProduct.DataBind();
            }
        }
    }
}