using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicrosoftWinformsTutorial
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        int addend1;
        int addend2;

        int minuend;
        int subtrahend;

        int multiplicand;
        int multiplier;

        int dividend;
        int divisor;

        int timeLeft;

        public Form1()
        {
            InitializeComponent();
        }

        public void StartTheQuiz()
        {
            addend1 = random.Next(51);
            addend2 = random.Next(51);

            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            suma.Value = 0;

            minuend = random.Next(1, 101);
            subtrahend = random.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            różnica.Value = 0;

            multiplicand = random.Next(2, 11);
            multiplier = random.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            iloczyn.Value = 0;

            divisor = random.Next(2, 11);
            int temporaryQuotient = random.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            iloraz.Value = 0;

            timeLeft = 30;
            timeLabel.Text = "30 sekund";
            timer1.Start();
        }

        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == suma.Value)
                && (minuend - subtrahend == różnica.Value)
                && (multiplicand * multiplier == iloczyn.Value)
                && (dividend / divisor == iloraz.Value))
                return true;
            else
                return false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
            timeLabel.BackColor = Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("Wszystkie odpowiedzi są poprawne",
                                "Gratulacje");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " sekund";
                if (timeLeft <= 5) timeLabel.BackColor = Color.Red;
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Koniec czasu";
                MessageBox.Show("Nie skończyłeś na czas", "Niestety");
                suma.Value = addend1 + addend2;
                różnica.Value = minuend - subtrahend;
                iloczyn.Value = multiplicand * multiplier;
                iloraz.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}
