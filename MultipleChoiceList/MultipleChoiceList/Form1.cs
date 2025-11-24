using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleChoiceList
{
    public partial class Form1 : Form
    {
        string password;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            password = "";
            string letters = "qwertyuiopasdfghjklzxcvbnm";
            string bigLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string numbers = "0123456789";
            string specialChars = "!@#$%^&*()_+-=";
            int passwordLength = Int32.Parse(textBox3.Text);

            Random rand = new Random();

            if (passwordLength < 3) passwordLength = 3;
            for(int i = 0; i < passwordLength; i++)
            {
                if (checkBox1.Checked && i == 0)
                {
                    password += bigLetters[rand.Next(0, bigLetters.Length)];
                } else if (checkBox2.Checked && i == 1)
                {
                    password += numbers[rand.Next(0, numbers.Length)];
                } else if (checkBox3.Checked && i == 2)
                {
                    password += specialChars[rand.Next(0, specialChars.Length)];
                } else
                {
                    password += letters[rand.Next(0, letters.Length)];
                }
            }

            MessageBox.Show(password);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text, lastName = textBox2.Text, job = comboBox1.SelectedItem.ToString();
            MessageBox.Show($"Dane pracownika: {firstName} {lastName} {job} Hasło: {password}");
        }
    }
}
