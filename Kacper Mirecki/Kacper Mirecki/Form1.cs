using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kacper_Mirecki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HideGroupBoxes()
        {
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //message box
            string result = $"Nazwisko: {textBox1.Text}\nZawód: {listBox1.SelectedItem}\nPłeć: {(radioButton1.Checked ? "Mężczyzna" : radioButton2.Checked ? "Kobieta" : "")}";
            MessageBox.Show(result, "Dane Osobowe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //save file dialog
            string result = $"Nazwisko: {textBox1.Text}\nZawód: {listBox1.SelectedItem}\nPłeć: {(radioButton1.Checked ? "Mężczyzna" : radioButton2.Checked ? "Kobieta" : "")}";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                if(path != null)
                {
                    File.WriteAllText(path, result);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string result = "Znane języki: ";
            foreach(var language in listBox2.SelectedItems)
            {
                result += language.ToString() + " ";
            }

            result += "\nZainteresowania: ";
            foreach (var hobby in checkedListBox1.CheckedItems)
            {
                result += hobby.ToString() + " ";
            }

            MessageBox.Show(result, "Inne Dane");
        }

        private void daneOsoboweToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideGroupBoxes();
            groupBox2.Show();
        }

        private void inneInformacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideGroupBoxes();
            groupBox3.Show();
        }

        private void generujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideGroupBoxes();
            groupBox4.Show();

            string smallLetters = "qwertyuiopasdfghjklzxcvbnm";
            string bigLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string specialChars = "!@#$%^&*()-=_+";
            string numbers = "1234567890";

            string path = "../../dlugosc.txt";
            string resultPassword = "";

            int passwordLength;

            try
            {
                passwordLength = Int32.Parse(File.ReadAllText(path));
            }
            catch 
            {
                MessageBox.Show("Nie udało się odczytać długości hasła z pliku", "Błąd odczytu");
                return;
            }

            Random rand = new Random();

            resultPassword += specialChars[rand.Next(0, specialChars.Length)];
            resultPassword += bigLetters[rand.Next(0, bigLetters.Length)];
            resultPassword += numbers[rand.Next(0, numbers.Length)];
            resultPassword += smallLetters[rand.Next(0, smallLetters.Length)];

            for (int i = 0; i < passwordLength - 4; i++)
            {
                resultPassword += smallLetters[rand.Next(0, smallLetters.Length)];
            }

            textBox2.Text = passwordLength.ToString();
            textBox3.Text = resultPassword;
        }
    }
}
