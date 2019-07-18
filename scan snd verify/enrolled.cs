using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI_Support
{
    public partial class enrolled : Form
    {
        public string currentuser;
        public string currentid;
        public string currentscan;
        public enrolled()
        {
            InitializeComponent();
            loadall();
        }
        private fingerdatabase start;
        public void loadall()
        {
            List<fingerdatabase> users = fingerdatabase.GetFingerdatabases();
            foreach(fingerdatabase x in users)
            {
                ListViewItem item = new ListViewItem(new string[] {x.username,x.userid,x.scanid});
                item.Tag = x;
                listView.Items.Add(item);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            loadall();
        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count >0)
            {
                ListViewItem current = listView.SelectedItems[0];
                start = (fingerdatabase)current.Tag;
                currentuser = start.username;
                currentid = start.userid;
                currentscan = start.scanid;
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
