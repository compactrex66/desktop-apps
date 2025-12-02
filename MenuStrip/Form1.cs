using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class Form1 : Form
    {
        string action;
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowCalculateComponents()
        {
            groupBox1.Hide();
            label3.Hide();
            listBox1.Hide();
            label1.Show();
            label2.Show();
            textBox1.Show();
            textBox2.Show();
            button1.Show();
            textBox3.Show();
        }

        private void ShowTestComponents()
        {
            label2.Hide();
            textBox2.Hide();
            label1.Show();
            textBox1.Show();
            button1.Show();
            textBox3.Show();
            radioButton1.Show();
            radioButton2.Show();
            groupBox1.Show();
            label3.Show();
            listBox1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (action == "calculatePotentialEnergy")
            {
                float g = 9.81f, mass, height;

                mass = float.Parse(textBox1.Text);
                height = float.Parse(textBox2.Text);

                textBox3.Text = g * mass * height + " J";
            } else if (action == "calculateKineticEnergy")
            {
                float mass, velocity;

                mass = float.Parse(textBox1.Text);
                velocity = float.Parse(textBox2.Text);

                textBox3.Text = 0.5 * mass * (velocity * velocity) + " J";
            } else if (action == "calculateVelocity")
            {
                float distance, time;

                distance = float.Parse(textBox1.Text);
                time = float.Parse(textBox2.Text);

                textBox3.Text = distance / time + " m/s";
            } else if (action == "calculateDistance")
            {
                float time, velocity;

                velocity = float.Parse(textBox1.Text);
                time = float.Parse(textBox2.Text);

                textBox3.Text = velocity * time + " m";
            } else if (action == "calculateTime")
            {
                float distance, velocity;

                velocity = float.Parse(textBox1.Text);
                distance = float.Parse(textBox2.Text);

                textBox3.Text = velocity / distance + " s";
            }
        }

        private void potencjalnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Masa";
            label2.Text = "Wysokość";
            action = "calculatePotentialEnergy";
            ShowCalculateComponents();
        }

        private void kinetycznaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Masa";
            label2.Text = "Prędkość";
            action = "calculateKineticEnergy";
            ShowCalculateComponents();
        }

        private void prędkośćToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Droga";
            label2.Text = "Czas";
            action = "calculateVelocity";
            ShowCalculateComponents();
        }

        private void drogaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Prędkość";
            label2.Text = "Czas";
            action = "calculateDistance";
            ShowCalculateComponents();
        }

        private void czasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Prędkość";
            label2.Text = "Droga";
            action = "calculateTime";
            ShowCalculateComponents();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Nazwisko";
            groupBox1.Text = "Jaka energia wzrasta wraz z prędkością ?";
            label3.Text = "Które z podanych wartości zależą od masy: ";
            action = "test";
            ShowTestComponents();
        }
    }
}
