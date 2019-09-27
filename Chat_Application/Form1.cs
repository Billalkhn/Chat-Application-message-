using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Application
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            signup s2 = new signup();
            s2.Show();
            this.Hide();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            chat_panel chat = new chat_panel();
            admin ad = new admin();
            try
            {
                userinfo info = ad.select(textBox1.Text, textBox2.Text);
                this.Hide();
                chat.Show();
                chat.Text = ("Hello " + info.fname);
            }
            catch (Exception)
            {

                MessageBox.Show("Wrong crendentials");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
