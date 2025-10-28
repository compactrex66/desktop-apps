using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Tables
{
    public partial class Form1 : Form
    {
        int[] tab;
        public Form1()
        {
            InitializeComponent();
        }

        private void Sort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            tab = new int[dataGridView1.ColumnCount];

            dataGridView2.Visible = false;
            label1.Visible = false;
            textBox1.Visible = false;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = rand.Next(1, 101);
                    tab[j] = (int)dataGridView1.Rows[i].Cells[j].Value;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tab == null) return;

            int min = tab[0];
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (min > tab[i]) {
                    min = tab[i];
                }
            }
            label1.Text = "Najmniejszy element:";
            textBox1.Text = min.ToString();

            label1.Visible = true;
            textBox1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tab == null) return;

            int max = tab[0];
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (max < tab[i])
                {
                    max = tab[i];
                }
            }
            label1.Text = "Największy element:";
            textBox1.Text = max.ToString();

            label1.Visible = true;
            textBox1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tab == null) return;

            dataGridView2.Visible = true;

            Sort(tab);
            for (int i = 0;i < dataGridView2.RowCount; i++)
            {
                for (int j = 0;  j < dataGridView2.ColumnCount; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = tab[j];
                }
            }
        }
    }
}
