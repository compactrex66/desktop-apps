using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nazwisko, gender;
            string wiek;
            bool isAStudent;

            nazwisko = textBox1.Text;
            wiek = textBox2.Text;
            isAStudent = checkBox1.Checked;
            gender = radioButton1.Checked ? "Pan" : radioButton2.Checked ? "Pani" : "";

            textBox3.Text = $"{nazwisko} {wiek} lat/a {gender} {(isAStudent ? "student" : "")}";

            textBox4.Text = "Zainteresowania: ";
            foreach(object hobby in checkedListBox1.CheckedItems)
            {
                textBox4.Text += $"{hobby.ToString()} ";
            }

            textBox5.Text = "Języki obce: ";
            foreach (object language in checkedListBox2.CheckedItems)
            {
                textBox5.Text += $"{language} ";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
