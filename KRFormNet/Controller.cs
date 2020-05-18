using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KRFormNet.Source;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KRFormNet
{
    class Controller
    {
        public static Store shop= new Store();
        public static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\KRFormNet\KRFormNet\Databases\Products.mdf;Integrated Security=True";

        /*public async static void ControllerInit()
        {
            //add name
            //add info 
            // add customers

            String connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\KRFormNet\KRFormNet\Databases\Products.mdf;Integrated Security=True";
            productsSqlConnection = new SqlConnection(connString);



            await productsSqlConnection.OpenAsync();
            SqlDataReader sqlReader = null;
            SqlCommand comm = new SqlCommand("SELECT * FROM [Products]", productsSqlConnection);

            try
            {
                // read product list
                sqlReader = await comm.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    shop.AddProduct(new Product(Convert.ToInt32(sqlReader["Id"]), Convert.ToString(sqlReader["productName"]), Convert.ToDouble(sqlReader["price"]), Convert.ToInt32(sqlReader["productNumber"])));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());//
            }
            finally {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }*/
    }
}
