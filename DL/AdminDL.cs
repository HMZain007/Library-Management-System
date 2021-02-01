using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.GUI;
using LibraryManagementSystem.DL;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;
using LibraryManagementSystem.DTO;

namespace LibraryManagementSystem.DL
{
    class AdminDL
    {
        SqlCommand cmd;
        SqlConnection con;
        public AdminDL()
        {
            string Path = Environment.CurrentDirectory;
            string[] appPath = Path.Split(new string[] { "bin" }, StringSplitOptions.None);
            AppDomain.CurrentDomain.SetData("DataDirectory", appPath[0]);
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + appPath[0] + @"Storage.mdf;Integrated Security=True";

            con = new SqlConnection(conString);
        }



    }

}
