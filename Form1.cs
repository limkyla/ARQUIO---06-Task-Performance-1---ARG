using CalculatorPrivateAssembly;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmBasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void compute_Click(object sender, EventArgs e)
        {
            float firstNum = float.Parse(tb1.Text);
            float secondNum = float.Parse(tb2.Text);

            if (cb1.Text == "+")
            {
                lbl2.Text = BasicComputation.additionResult(firstNum, secondNum).ToString();
            }
            else if(cb1.Text == "-")
            {
                lbl2.Text = BasicComputation.subtractionResult(firstNum, secondNum).ToString();
            }
            else if (cb1.Text == "*")
            {
                lbl2.Text = BasicComputation.multiplicationResult(firstNum, secondNum).ToString();
            }
            else if (cb1.Text == "/")
            {
                lbl2.Text = BasicComputation.divisionResult(firstNum, secondNum).ToString();
            }
        }
    }
}
