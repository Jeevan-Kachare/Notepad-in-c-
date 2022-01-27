using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace Assignment_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files(*.txt*)|*.txt ";
            saveFileDialog1.Title = "save a text file";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileSystem.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text, true);
            }

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            if (!(OpenFileDialog1.ShowDialog() == DialogResult.Cancel))
                pictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName);
           
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

            printDocument1.DocumentName = "My Custom Document";
            printDialog1.Document = printDocument1;
            printDialog1.AllowSomePages = true;
            printDialog1.AllowCurrentPage = true;
            //printDialog1.AllowSelection = true;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.Print();

            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void selectFolderPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            label2.Text = folderBrowserDialog1.SelectedPath;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
               
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if ( colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
