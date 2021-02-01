using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LibraryManagementSystem.BL;
using LibraryManagementSystem.DTO;
using System.IO;





namespace LibraryManagementSystem.DL
{

    class LoginDL
    {
        SqlConnection con;
        public LoginDL()
        {
            con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\devil\Desktop\LibraryManagementSystem\LibraryManagementSystem\Databases\credentials.mdf; Integrated Security = True");
        }

        public int VerifyUserfromDB(LoginDTO dto)
        {
            con.Open();
            string query = "SELECT id FROM credentials WHERE Username ='" + dto.Username + "'AND Password = '" + dto.Password + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int id = Convert.ToInt32(reader["ID"]);
                reader.Close();
                con.Close();
                return id;
            }
            else
            {
                reader.Close();
                con.Close();
                return 0;
            }
        }
    }
}
