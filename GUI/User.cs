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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            Thread th;

            th = new Thread(openBooks);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }
        private void openBooks(object obj)
        {
            Application.Run(new Books());
        }
        private void IssueBooks(object obj)
        {
            Application.Run(new IssueBook());
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Thread th;

            th = new Thread(IssueBooks);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
