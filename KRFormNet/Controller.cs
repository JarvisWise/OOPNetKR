using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KRFormNet.Source;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.CodeDom;

namespace KRFormNet
{
    class Controller
    {
        public static string[] Towns = {"Sumy", "Kiev", "poltava", "Kharkov" , "Odessa", "Lviv", "Zhytomyr", "Rivne", "Vinnytsia", "Zakarpattia" };
        public static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\KRFormNet\KRFormNet\Databases\Products.mdf;Integrated Security=True";
        public static Store shop = new Store();

    }
}
