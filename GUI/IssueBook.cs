using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.GUI
{
    public partial class IssueBook : Form
    {

        public IssueBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th;

            Application.Exit();
            th = new Thread(openUser);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openUser(object obj)
        {
            Application.Run(new User());
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con;
            string Path = Environment.CurrentDirectory;
            string[] appPath = Path.Split(new string[] { "bin" }, StringSplitOptions.None);
            AppDomain.CurrentDomain.SetData("DataDirectory", appPath[0]);
            con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\devil\Desktop\LibraryManagementSystem\LibraryManagementSystem\Databases\Storage.mdf; Integrated Security = True");

            try
            {
                con.Open();
                string commandString = "DELETE FROM BOOKS WHERE Book_Id = '" + this.textBox1.Text + "';";
                SqlCommand sqlCmd = new SqlCommand(commandString, con);
                int index = sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Book has been Issued!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Book not Available!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
    }
}
