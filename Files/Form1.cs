using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                try
                {
                    string text = File.ReadAllText(path);
                    textBox1.Text = text;
                } catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas wczytywania pliku: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;

                try
                {
                    File.WriteAllText(path, textBox2.Text);
                    MessageBox.Show("Zapisano zawartość do pliku");
                } catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas zapisywania do pliku: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;

                try
                {
                    File.AppendAllText(path, textBox2.Text);
                    MessageBox.Show("Dopisano zawartość do pliku");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas dopisywania do pliku: " + ex.Message);
                }
            }
        }
    }
}
