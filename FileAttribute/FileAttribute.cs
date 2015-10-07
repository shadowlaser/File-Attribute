using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace yjl
{
    public partial class FileAttribute : Form
    {
        public FileAttribute()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Hidden.Checked = ReadOnly.Checked = System.Checked = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                FileAttributes attr = File.GetAttributes(textBox1.Text);
                if ((attr &FileAttributes.Hidden) == FileAttributes.Hidden)
                {
                    Hidden.Checked = true;
                   
                }
                
                if ((attr &FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                {
                    ReadOnly.Checked =true;
                    
                }
                if ((attr & FileAttributes.System) == FileAttributes.System)
                {
                    System.Checked = true;
                    
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileAttributes attr = File.GetAttributes(textBox1.Text);
            //attr |= FileAttributes.Normal;
            
           

            if (ReadOnly.Checked)
            {
                attr |= FileAttributes.ReadOnly;

            }
            else
            {
                attr &= FileAttributes.ReadOnly;
            }

            if (System.Checked)
            {
                attr |= FileAttributes.System;

            }
            else
            {
                attr &= FileAttributes.System;
            }


            if (Hidden.Checked)
            {
                attr |= FileAttributes.Hidden;

            }
            else
            {
                attr &= FileAttributes.Hidden;
            }
            File.SetAttributes(textBox1.Text, attr);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}