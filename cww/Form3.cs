using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cww
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListBox lb = new ListBox();
            lb.SetBounds(400, 50, 300, 300);
            Controls.Add(lb);
            foreach (ListViewItem item in listView1.Items)
            {
                string str = item.Text;
                foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                {
                    str += " : " + subitem.Text;
                }
                lb.Items.Add(str);
            }
        }

        private void largenconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon; 
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Tile; 
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Column1", 100); 
            listView1.Columns.Add("Column2", 100);
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void smalllconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }
    }
}
