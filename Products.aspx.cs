using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using BestTry.App_Code;
using System.Data;

namespace BestTry
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //When page is loaded the first time
            if (!Page.IsPostBack)
            {
                //First, load all the categories from the DB
                DataTable dt = new CategoriesManager().GetCategories();

                foreach (DataRow dr in dt.Rows)
                {
                    ListItem item = new ListItem();
                    item.Text = dr.Field<string>("CategoryName");
                    item.Value = dr.Field<int>("CategoryID").ToString();
                    this.BLCategories.Items.Add(item);
                }

                //Second, load all the Products belongs to the first category from the DB
                //DataTable data = new ProductManager().GetProducts();
                //foreach (DataRow datar in data.Rows)
                //{
                //    ListItem Product = new ListItem();
                //    Product.Text = datar.Field<string>("ItemName");
                //    Product.Value = datar.Field<int>("ItemId").ToString();
                //    this.BLProducts.Items.Add(Product);
                //}
                this.BindProductGridView();
            }
        }

        protected void BLCategories_Click(object sender, BulletedListEventArgs e)
        {
            this.BindProductGridView(int.Parse(this.BLCategories.Items[e.Index].Value.ToString()));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        private void BindProductGridView(int ID = -1)
        {
            DataTable dt = new ProductManager().GetProducts(ID);
            this.GVProducts.DataSource = dt;
            this.GVProducts.DataBind();
        }

    }
}