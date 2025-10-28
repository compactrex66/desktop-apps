using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Darrays
{
    public partial class Form1 : Form
    {
        int[,] tab;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Random rand = new Random();
            dataGridView1.RowCount = 5;
            dataGridView2.RowCount = 5;
            tab = new int[dataGridView1.RowCount, dataGridView1.ColumnCount];

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = rand.Next(0, 10);
                    tab[i, j] = (int)dataGridView1.Rows[i].Cells[j].Value;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            dataGridView1.RowCount = 5;
            dataGridView2.RowCount = 5;
            tab = new int[dataGridView1.RowCount, dataGridView1.ColumnCount];

            for(int i = 0; i < dataGridView1.RowCount; i++)
            {
                for(int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = rand.Next(0, 10);
                    tab[i,j] = (int)dataGridView1.Rows[i].Cells[j].Value;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum =  0;
            for(int i = 0; i < dataGridView1.RowCount; i++)
            {
                for(int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    sum += tab[i, j];
                }
                dataGridView2.Rows[i].Cells[0].Value = sum;
                sum = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    sum += tab[j, i];
                }
                dataGridView3.Rows[0].Cells[i].Value = sum;
                sum = 0;
            }
        }
    }
}
