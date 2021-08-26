using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projectForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            int yas = int.Parse(textBox3.Text);

            KisilerListBox.Items.Add(ad + soyad + yas);
        }
        private void buttonÇıkıs_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
