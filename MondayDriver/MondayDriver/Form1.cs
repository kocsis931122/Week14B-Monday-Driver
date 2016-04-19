using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MondayDriver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] directories = Directory.GetDirectories(@"C:\");
            string[] files = Directory.GetFiles(@"C:\");
            listBox1.Items.AddRange(directories);
            listBox1.Items.AddRange(files);
            comboBox1.DataSource = Environment.GetLogicalDrives();
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                textBox1.Text = @"C:\";
            }
            else
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] directories = Directory.GetDirectories(textBox1.Text);
            string[] files = Directory.GetFiles(textBox1.Text);
            listBox1.Items.AddRange(directories);
            listBox1.Items.AddRange(files);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            textBox1.Text = @"C:\";
        }
    }
}
