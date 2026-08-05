using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace guiSumCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "") File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            textBox1.Text = "";
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "") File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            textBox1.Text = "";

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "") File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            

        }

        private void saveTotalTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "") File.WriteAllText(saveFileDialog1.FileName, textBox2.Text);
            textBox2.Text = "";

        }

        private void clearTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "") File.WriteAllText(saveFileDialog1.FileName, textBox2.Text);
            textBox2.Text = "";

        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Double totals = 0.00;
            int counter = 1;
            String[] cols= textBox1.Text.Split('\n');
            for (int i = 0; i < cols.Length; i++) 
            {
                try
                {
                    Double d = 0.00;
                    d= Double.Parse(cols[i]);
                    totals=totals + d;
                    textBox2.Text += d.ToString()+"          =" + totals.ToString() + "\r\n";
                }
                catch (Exception ex) 
                {
                    textBox2.Text += "\nline "+counter.ToString()+"\r\n";
                
                }
                counter++;
            
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")textBox1.Text= File.ReadAllText(openFileDialog1.FileName);
            

        }
    }
}
