using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BestTry.App_Code
{
    public class ProductManager
    {
        /// <summary>
        /// Get Product by given CategoryId
        /// </summary>
        /// <param name="categoryId">Id of the selected Category</param>
        /// <returns>
        /// rerturn Datatable
        /// </returns>
        public DataTable GetProducts(int categoryId = -1)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
            SqlCommand scm = new SqlCommand();
            scm.CommandText = "App_Product_By_Category";
            scm.CommandType = CommandType.StoredProcedure;
            scm.Parameters.AddWithValue("@CategoryId", categoryId);
            scm.Connection = connection;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(scm);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet.Tables[0];
        }

        public DataTable GetItems(int categoryId)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
            SqlCommand scm = new SqlCommand();
            scm.CommandText = "App_Get_Item_By_ID";
            scm.CommandType = CommandType.StoredProcedure;
            scm.Parameters.AddWithValue("@ItemId", categoryId);
            scm.Connection = connection;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(scm);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet.Tables[0];
        }
    }
}