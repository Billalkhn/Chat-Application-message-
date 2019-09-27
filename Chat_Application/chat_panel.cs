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

namespace Chat_Application
{
    public partial class chat_panel : MaterialForm
    {
        public chat_panel()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Server_chat_panel scp = new Server_chat_panel();
            scp.Show();
            this.Hide();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Client_chat_panel ccp = new Client_chat_panel();
            ccp.Show();
            this.Hide();
        }
    }
}
