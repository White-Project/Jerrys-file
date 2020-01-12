using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace BestTry.App_Code
{
    public class CategoriesManager
    {
        /// <summary>
        /// Get Category Names
        /// </summary>
        /// <returns>
        /// rerturn Datatable
        /// </returns>
        public DataTable GetCategories()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());
            SqlCommand scm = new SqlCommand();
            scm.CommandText = "App_Category_List";
            scm.CommandType = CommandType.StoredProcedure;
            scm.Connection = connection;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(scm);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet.Tables[0];
        }
    }
}