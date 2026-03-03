using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            HideAllControls();
            label1.Show();
            label2.Show();
            textBox1.Show();
            textBox2.Show();
            button1.Show();
            textBox3.Show();
            groupBox2.Show();
            button1.Text = "Oblicz";
        }

        private void ShowTestComponents()
        {
            HideAllControls();
            label1.Show();
            textBox1.Show();
            button1.Show();
            textBox3.Show();
            radioButton1.Show();
            radioButton2.Show();
            groupBox1.Show();
            groupBox2.Show();
            label3.Show();
            listBox1.Show();
            label4.Show();
            comboBox1.Show();
            label5.Show();
            checkBox1.Show();
            checkBox2.Show();
            button1.Text = "Sprawdź";
        }

        private void HideAllControls()
        {
            groupBox1.Hide();
            label3.Hide();
            listBox1.Hide();
            label4.Hide();
            comboBox1.Hide();
            label5.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            groupBox2.Hide();
            label2.Hide();
            textBox2.Hide();
            groupBox3.Hide();
            panel2.Hide();
            panel3.Hide();
        }

        private Color GetChosenColor()
        {
            int red = hScrollBar1.Value;
            int green = hScrollBar2.Value;
            int blue = hScrollBar3.Value;

            Color color = Color.FromArgb(red, green, blue);

            return color;
        }

        private void ChangePanelColor()
        {
            Color color = GetChosenColor();

            panel1.BackColor = color;

            textBox4.Text = color.R.ToString();
            textBox5.Text = color.G.ToString();
            textBox6.Text = color.B.ToString();
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
            } else if (action == "test")
            {
                string name = textBox1.Text;
                int points = 0;
                if (radioButton1.Checked) points++;
                if (listBox1.SelectedItems.Count == 4 && 
                    listBox1.SelectedItems.Contains("Pęd") && 
                    listBox1.SelectedItems.Contains("Energia Potencjalna") && 
                    listBox1.SelectedItems.Contains("Siła") &&
                    listBox1.SelectedItems.Contains("Energia kinetyczna")) 
                    points++;
                if (comboBox1.SelectedText == "N") points++; Console.WriteLine(comboBox1.SelectedText);
                if (!checkBox1.Checked) points++;
                if (checkBox2.Checked) points++;
                Console.WriteLine(points.ToString());
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
            label4.Text = "Która to jednostka siły: ";
            checkBox1.Text = "Im większa prędkość ciała tym większa energia potencjalna";
            action = "test";
            ShowTestComponents();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            ChangePanelColor();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            ChangePanelColor();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            ChangePanelColor();
        }

        private void wybórKoloruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllControls();
            groupBox3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Color color = GetChosenColor();
            label10.Text = $"{color.R}, {color.G}, {color.B}";
            label10.BackColor = color;
        }

        private void energiaPotencjalnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllControls();
            panel2.Show();
            Graphics graphics = panel2.CreateGraphics();
            Rectangle panelRectangle = panel2.ClientRectangle;
            Pen pen = new Pen(Color.Black, 2);
            Pen rubber = new Pen(DefaultBackColor, 2);
            SolidBrush brush = new SolidBrush(Color.Black);

            int ellipseSize = 50, middlePanelX = panelRectangle.Right / 2 - ellipseSize / 2;

            graphics.DrawString("Ep=MAX", DefaultFont, brush, middlePanelX + 75, panelRectangle.Y + 30);
            graphics.DrawString("Ep=0", DefaultFont, brush, middlePanelX + 75, panelRectangle.Y + 310);
            graphics.DrawLine(pen, 5, panelRectangle.Y + 340, panelRectangle.Right - 5, panelRectangle.Y + 340);

            for (float i = 1; i < 300; i*=1.2f)
            {
                graphics.DrawEllipse(rubber, middlePanelX, panelRectangle.Y + 5 + i/1.2f, ellipseSize, ellipseSize);
                graphics.DrawEllipse(pen, middlePanelX, panelRectangle.Y + 5 + i, ellipseSize, ellipseSize);
                Thread.Sleep(5);
            }
        }

        private void energiaKinetycznaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAllControls();
            panel3.Show();
            Graphics graphics = panel3.CreateGraphics();
            Rectangle panelRectangle = panel3.ClientRectangle;
            Pen pen = new Pen(Color.Black, 2);
            Pen rubber = new Pen(DefaultBackColor, 2);

            int carWidth = 50, carHeight = 25;
            double sineAngle = 0;

            graphics.DrawLine(pen, panelRectangle.Left, panelRectangle.Bottom, panelRectangle.Right, panelRectangle.Bottom);

            for (float i = 2; i < panelRectangle.Right - carWidth - 2;)
            {
                i += (float)Math.Abs(Math.Sin(sineAngle));
                sineAngle += 0.0073;
                Console.WriteLine(Math.Sin(sineAngle));
                Console.WriteLine(sineAngle);
                graphics.DrawRectangle(pen, i, panelRectangle.Bottom - carHeight - 3, carWidth, carHeight);
                Thread.Sleep(5);
                if(i + (float)Math.Abs(Math.Sin(sineAngle)) < panelRectangle.Right - carWidth - 2)
                    graphics.DrawRectangle(rubber, i, panelRectangle.Bottom - carHeight - 3, carWidth, carHeight);
            }
        }
    }
}
