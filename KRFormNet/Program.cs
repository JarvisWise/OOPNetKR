using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KRFormNet
{
    static class Program
    {
        [STAThread]
        static void Main()
        {



            /*using (StreamWriter MyFile = new StreamWriter(path))
            {
                MyFile.Write(1);
            }*/
            String line; //path = @"currentCustomerId.txt";
            using (StreamReader MyFile = new StreamReader(Controller.path))
            {
                while ((line = MyFile.ReadLine()) != null)
                {
                    Controller.currentCustomerId = Int32.Parse(line);
                }
            }
            if (Controller.currentCustomerId <= 0)
            {
                Controller.currentCustomerId = -1;
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
