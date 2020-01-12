using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BestTry.App_Code;
using System.Data;

namespace BestTry
{
    public partial class Item : System.Web.UI.Page
    {
        int ItemID =-1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ItemID = int.Parse(Request.QueryString["ItemID"].ToString());

                DataTable dt = new ProductManager().GetItems(ItemID);
                this.imgItemImage.ImageUrl = "/Graphics/" + dt.Rows[0].Field<string>("Image");
                this.LbProduct.Text = dt.Rows[0].Field<string>("ItemName");
                this.LbPrice.Text="$ " + dt.Rows[0].Field<decimal>("Price").ToString("#,###.##");
                this.LbDesc.Text = dt.Rows[0].Field<string>("Description");
            }

        }
    }
}