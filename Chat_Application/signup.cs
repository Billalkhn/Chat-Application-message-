using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Data.SqlClient;

namespace Chat_Application
{
    public partial class signup : MaterialForm
    {
        public signup()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            userinfo info = new userinfo();
            info.fname = textBox1.Text;
            info.lname = textBox2.Text;
            info.email = textBox3.Text;
            info.password = textBox4.Text;
            admin ad = new admin();

            ad.insert(info);
            MessageBox.Show("Sign up complete");
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
