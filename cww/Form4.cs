using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cww
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListBox lb = new ListBox();
            lb.SetBounds(200, 250, 300, 300);
            Controls.Add(lb);
            rec(treeView1.Nodes, lb);
        }
        private void rec(TreeNodeCollection nodes, ListBox lb)
        {
            foreach (TreeNode node in nodes)
            {
                string str = node.Text;
                rec(node.Nodes, lb);
                lb.Items.Add(str);
            }
        }
    }
}
