using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string livingPlace, school;
            livingPlace = comboBox1.SelectedItem.ToString();
            school = listBox1.Items[listBox1.SelectedIndex].ToString();

            textBox1.Text = $"{livingPlace} {school}";
        }
    }
}
