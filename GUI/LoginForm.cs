using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.DTO;
using LibraryManagementSystem.DL;
using LibraryManagementSystem.BL;
using System.Threading;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            userfield.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginDTO lg = new LoginDTO();
            LoginBL lb = new LoginBL();
            lg.Username = userfield.Text;
            lg.Password = passfield.Text;
            int status = lb.VerifyUserData(lg);
            if (status != 0)
            {
                Thread th;
                if (status == 1)
                {

                    Application.Exit();
                    th = new Thread(openadmin);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else if (status == 2)
                {

                    Application.Exit();
                    th = new Thread(openuser);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
            }
            else
            {
                MessageBox.Show("Incorrect Credentials","ErrorBox",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }

        private void openadmin(object obj)
        {
            Application.Run(new GUI.Admin());
        }

        private void openuser(object obj)
        {
            Application.Run(new GUI.User());
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    







        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void passfield_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            userfield.Text = "";
            passfield.Clear();
            userfield.Focus();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
