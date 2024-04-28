using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace text_ed
{
    public partial class ed : Form
    {
        public ed()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void browseAFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "choose your beloved ASCII or Unicode readable text file";
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "everything (.)|*.*|text fyle (.txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            
        }

        private void closeSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyctrlcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }


        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void aboutThisSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 2.0F;
        }

        private void outToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 1.0F;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void wordwrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
