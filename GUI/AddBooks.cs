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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.storageDataSet);

        }

        private void AddBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storageDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.storageDataSet.Books);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            string Path = Environment.CurrentDirectory;
            string[] appPath = Path.Split(new string[] { "bin" }, StringSplitOptions.None);
            AppDomain.CurrentDomain.SetData("DataDirectory", appPath[0]);
            con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\devil\Desktop\LibraryManagementSystem\LibraryManagementSystem\Databases\Storage.mdf; Integrated Security = True");
        
    
            con.Open();
            string commandString = "INSERT INTO Books (Id,Book_Id,Book_Name,Author) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            SqlCommand sqlCmd = new SqlCommand(commandString, con);
            int index = sqlCmd.ExecuteNonQuery();
            con.Close();

           
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void book_IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void book_NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void authorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread th;

            Application.Exit();
            th = new Thread(openLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void openLogin(object obj)
        {
            Application.Run(new Form1());
        }
    
    }
}
