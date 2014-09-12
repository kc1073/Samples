using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace HashtableExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Hashtable Info = new Hashtable();

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            Info.Add(a, b);
            label4.Text = a + " " + b;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder allEntries = new StringBuilder();
            foreach (DictionaryEntry DE in Info)
            {
                allEntries.Append(DE.Key);
                allEntries.Append(DE.Value);
            }
            label4.Text = allEntries.ToString();
        }

    }
}
