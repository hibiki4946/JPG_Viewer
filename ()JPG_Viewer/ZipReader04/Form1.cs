using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;

namespace ZipReader04
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



            //FolderBrowserDialog FBD = new FolderBrowserDialog();

            //if (FBD.ShowDialog() == DialogResult.OK)
            //{
            //    list_open.Items.Clear();
            //    //textBox1.Text = FBD.SelectedPath;
            //    string[] files = Directory.GetFiles(FBD.SelectedPath);
            //    string[] dirs = Directory.GetDirectories(FBD.SelectedPath);

            //    foreach (string file in files)
            //    {
            //        //listBox1.Items.Add(Path.GetFileName(file));
            //        list_open.Items.Add(file);
            //    }
            //    foreach (string dir in dirs)
            //    {
            //        list_open.Items.Add(Path.GetFileName(dir));
            //    }
            //}
        }


        private void panelImages_SizeChanged(object sender, EventArgs e)
        {

        }



        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //System.Environment.Exit(System.Environment.ExitCode);

        }

        int x = 0;
        int y = 0;
        int i = 1;
        int i_1 = 1;
        int i_0 = 1;
        int page = 0;
        string files = "0";
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.A:
                    page = 0;
                    panelImages_MouseClick(null, null);
                    break;

                case Keys.Z:
                    page = 1;
                    panelImages_MouseClick(null, null);
                    break;

                case Keys.Escape:
                     System.Environment.Exit(System.Environment.ExitCode);
                    break;


                case Keys.F11:
                    if(this.TopMost == true)
                    {
                        this.FormBorderStyle = FormBorderStyle.Sizable;
                        this.WindowState = FormWindowState.Normal;
                        this.TopMost = false;
                    }
                    else
                    {
                        this.FormBorderStyle = FormBorderStyle.None;
                        //this.WindowState = FormWindowState.Maximized;
                        this.TopMost = true;
                    }
                    break;

                case Keys.X:
                    panelImages_MouseDoubleClick(null, null);

                    break;

                case Keys.C:

                    this.panelImages.Controls.Clear();

                    break;


            }

        }


        private void panelImages_Scroll(object sender, ScrollEventArgs e)
        {
            this.panelImages.Controls.Clear();
        }

        private void panelImages_MouseClick(object sender, MouseEventArgs e)
        {
            //if(page == 0 && i > i_0) { i = i_1 - i_0*2; }
            if (page == 1) { i = i_1; }

            //i = i_1;
            if (files != "0")
            {
                x = 0;
                y = 0;
                this.panelImages.Controls.Clear();

                try
                {
                    while (y < 36000)
                    {
                        PictureBox pic = new PictureBox();
                        pic.Image = Image.FromFile(files + "\\" + i + ".jpg");
                        pic.Location = new Point(x, y);
                        pic.Size = new Size(pic.Size.Width, pic.Size.Height);
                        pic.SizeMode = PictureBoxSizeMode.AutoSize;

                        y += pic.Size.Height;
                        this.panelImages.Controls.Add(pic);
                        i++;
                    }

                    i_0 = i - i_1;
                    i_1 = i;
                }
                catch (Exception ex)
                {
                    x = 0;
                    y = 0;
                    i = 1;

                    i_0 = i_1;
                    i_1 = i;
                }


            }


        }

        private void panelImages_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            //string[] files = Directory.GetFiles(FBD.SelectedPath);
            FBD.SelectedPath = files;
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                files = FBD.SelectedPath;
            }
            i = 1;
            i_1 = 1;
            panelImages_MouseClick(null, null);
        }



        private void panelImages_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.A:
                    page = 0;
                    panelImages_MouseClick(null, null);
                    break;

                case Keys.Z:
                    page = 1;
                    panelImages_MouseClick(null, null);
                    break;

                case Keys.Escape:
                    System.Environment.Exit(System.Environment.ExitCode);
                    break;


                case Keys.F11:
                    if (this.TopMost == true)
                    {
                        this.FormBorderStyle = FormBorderStyle.Sizable;
                        this.WindowState = FormWindowState.Normal;
                        this.TopMost = false;
                    }
                    else
                    {
                        this.FormBorderStyle = FormBorderStyle.None;
                        //this.WindowState = FormWindowState.Maximized;
                        this.TopMost = true;
                    }
                    break;

                case Keys.X:
                    panelImages_MouseDoubleClick(null, null);

                    break;

                case Keys.C:
                    this.panelImages.Controls.Clear();

                    break;


            }
        }

    }
}
