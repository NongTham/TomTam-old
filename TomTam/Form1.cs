using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TomTam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArchAPI.Arch API = new ArchAPI.Arch();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            API.Execute(fastColoredTextBox1.Text);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Title = "Open"
                Filter = "Text (*.txt)|*.txt|Lua (*.lua)|*.lua|All Files (*.*)|*.*"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.Text = File.ReadAllText(dialog.FileName);
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                Title = "Save as",
                Filter = "Text (*.txt)|*.txt|Lua (*.lua)|*.lua|All Files (*.*)|*.*"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(dialog.FileName))
                {
                    File.Create(dialog.FileName).Close();
                    File.WriteAllText(dialog.FileName, fastColoredTextBox1.Text);
                }
                else
                {
                    File.WriteAllText(dialog.FileName, fastColoredTextBox1.Text);
                }
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            API.Attach();
        }
    }
}
