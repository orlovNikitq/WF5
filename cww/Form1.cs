using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cww
{
    public partial class Form1 : Form
    {
        List <Bitmap> images = new List <Bitmap> ();
        Timer timer = new Timer();
        bool flag = false;
        int np = 0;
        int full = 0;
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += next_Click;
        }

        private void next_Click(object sender, EventArgs e)
        {
            NextPicture();
        }

        private void NextPicture()
        {
            if (images.Count == 0) return;
            else
            {
                np++;
                if(np>=images.Count)
                {
                    np = 0;
                }
                pictureBox1.Image = images[np];
            }
            label1.Text = $"{np}/{full-1}";
        }

        private void bt_open_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                if (images.Count != 0)
                {
                    foreach (var item in images)
                    {
                        item.Dispose();
                    }
                    images.Clear();
                }
                DirectoryInfo direct = new DirectoryInfo(folder.SelectedPath);
                IEnumerable<FileInfo> files = direct.EnumerateFiles();
                foreach(var item in files)
                {
                    string ex = Path.GetExtension(item.FullName);
                    if (ex == ".bmp" || ex == ".jpg" || ex == ".jpeg" || ex == ".png")
                    {
                        Bitmap pt = new Bitmap(item.FullName);
                        Size pt_size = pictureBox1.Size;
                        images.Add(new Bitmap(pt,pictureBox1.Size));
                    }
                }
            }
            full = images.Count;
            
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            if (images.Count == 0) MessageBox.Show("Нет картинок");
            else
            {
                flag = true;
                timer.Start();
            }
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            flag = false;
            timer.Stop();
        }

        private void bt_prevew_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                if (images.Count == 0) return;
                else
                {
                    np--;
                    if (np < 0)
                    {
                        np = images.Count - 1;
                    }
                    pictureBox1.Image = images[np];
                }
            }
            label1.Text = $"{np}/{full-1}";
        }
        private void bt_next_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                if (images.Count == 0) return;
                else
                {
                    np++;
                    if (np >= images.Count)
                    {
                        np = 0;
                    }
                    pictureBox1.Image = images[np];
                }
            }
            label1.Text = $"{np}/{full - 1}";
        }
    }
}
