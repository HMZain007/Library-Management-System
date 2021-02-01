using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.GUI;
using LibraryManagementSystem.DTO;
using LibraryManagementSystem.DL;

namespace LibraryManagementSystem.GUI
{
    public partial class Admin : Form
    {

        AdminDL ADL = new AdminDL();
        public Admin()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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
        private void openAddBooks(object obj)
        {
            Application.Run(new AddBooks());
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th;

            th = new Thread(openAddBooks);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}