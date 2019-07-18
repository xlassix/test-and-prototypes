using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI_Support
{
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
            label3.Hide();
            label1.Hide();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if ((user.Text != "admin" || user.Text != "Admin"))
            {
                label3.Show();
            }
            if((pass.Text != "admin"))
            {
                label1.Show();
            }
            else
            {
                enrolled me = new enrolled();
                me.Show();
                Hide();
            }
        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
