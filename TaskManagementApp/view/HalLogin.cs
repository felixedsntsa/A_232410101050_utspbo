using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagementApp.Model;

namespace TaskManagementApp.view
{
    public partial class HalLogin : Form
    {
        public HalLogin()
        {
            List<Admin> admins = new List<Admin>();
            InitializeComponent();
            Admin admin = new Admin();
            admin.Username = "admin";
            admin.Password = "admin123";
        }

        private void buttonLoginAdmin_Click(object sender, EventArgs e)
        {
            AdminDash admindash = new AdminDash();
            HalWelcome halwelcome = new HalWelcome();

            if (textBoxUsername.Text != "admin" && textBoxPassword.Text != "admin123")
            {
                this.Hide();
                halwelcome.Show();
            }
            else
            {
                this.Hide();
                admindash.Show();
            }
        }
    }
}
