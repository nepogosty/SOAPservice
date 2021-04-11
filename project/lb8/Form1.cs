using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
        ServiceReference1.CountryInfoServiceSoapTypeClient asp = new ServiceReference1.CountryInfoServiceSoapTypeClient();
        private void button1_Click(object sender, EventArgs e)
        {
           
            textBox2.Text = asp.CountryName(textBox1.Text);
            textBox5.Text = asp.CapitalCity(textBox1.Text);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox4.Text = asp.CountryISOCode(textBox3.Text);
           
            textBox6.Text = asp.LanguageName(textBox3.Text);
           
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
