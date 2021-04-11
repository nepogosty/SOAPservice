using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(ServiceReference2.VolumesWeights));
            comboBox1.SelectedItem = ServiceReference2.VolumesWeights.liter;
            comboBox2.DataSource = Enum.GetValues(typeof(ServiceReference2.VolumesWeights));
            comboBox2.SelectedItem = ServiceReference2.VolumesWeights.liter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(textBox1.Text);
                ServiceReference2.VolumesWeights from = (ServiceReference2.VolumesWeights)comboBox1.SelectedItem;
                ServiceReference2.VolumesWeights to = (ServiceReference2.VolumesWeights)comboBox2.SelectedItem;
                string res = soapClient.ChangeVolumeWeight(value, from, to);
                textBox2.Text = res;
            }
            catch
            {
                textBox2.Text = "Incorrect introduced value";
            }
        }
        public ServiceReference2.LiterSoapClient soapClient = new ServiceReference2.LiterSoapClient();
    }
}
