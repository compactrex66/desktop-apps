using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace package
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox1.Image = Properties.Resources.pocztowka;
                label1.Text = "Cena: 1 zł";
            } else if (radioButton2.Checked)
            {
                pictureBox1.Image = Properties.Resources.list;
                label1.Text = "Cena: 1,5 zł";
            } else if (radioButton3.Checked)
            {
                pictureBox1.Image = Properties.Resources.paczka;
                label1.Text = "Cena: 10 zł";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string postalCode = textBox2.Text;

            for (int i = 0; i < postalCode.Length; i++)
            {
                if (postalCode[i] < '0' || postalCode[i] > '9')
                {
                    MessageBox.Show("Kod pocztowy powinien składać się z samych cyfr");
                    return;
                }
            }

            if (postalCode.Length != 5)
            {
                MessageBox.Show("Nieprawidłowa liczba cyfr w kodzie pocztowym");
                return;
            }

            MessageBox.Show("Dane przesyłki zostały wprowadzone");
        }
    }
}
