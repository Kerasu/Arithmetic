using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arithmatic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            int integerAnswer;

            firstNumber = 10;
            secondNumber = 32;

            integerAnswer = 100 + firstNumber + secondNumber + 327489847;
            MessageBox.Show(integerAnswer.ToString(),"Addition Box");
        }

        private void BtnAddFloats_Click(object sender, EventArgs e)
        {
            float firstNumber;
            float secondNumber;
            float floatAnswer;
            int integerAnswer = 20;

            firstNumber = 10.5F;
            secondNumber = 32.5F;

            floatAnswer = firstNumber + secondNumber + integerAnswer;

            MessageBox.Show(floatAnswer.ToString(), "Float Box");
        }

        private void BtnSubtraction_Click(object sender, EventArgs e)
        {
            int answerSubtract;
            int numberOne = 12;
            int numberTwo = -55;

            answerSubtract = 50 - 25 - 10 - 2 - numberOne - numberTwo;

            MessageBox.Show(answerSubtract.ToString(), "Subtraction Box");
        }

        private void BtnMixed_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            int thirdNumber;
            int fourthNumber;
            int fifthNumber;
            int answer;

            firstNumber = 100;
            secondNumber = 50;
            thirdNumber = -50;
            fourthNumber = 10 / 5;
            fifthNumber = 2 * 2;

            answer = ((firstNumber + secondNumber - thirdNumber) / fourthNumber) * fifthNumber;

            MessageBox.Show(answer.ToString());


        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
