using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiOperationContractClient.ArithmeticService;

namespace MultiOperationContractClient
{
    public partial class Form1 : Form
    {
        public int FirstNumber;
        public int SecondNumber;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            var client = new ArithmeticServiceClient("NetTcpBinding_IArithmeticService");
            FirstNumber = Convert.ToInt32(firstNumTextBox.Text);
            SecondNumber = Convert.ToInt32(LastNumTextBox.Text);

            AddTextBox.Text = client.Addition(FirstNumber, SecondNumber).ToString(CultureInfo.InvariantCulture);

            SubTextBox.Text = FirstNumber > SecondNumber ? client.Subtraction(FirstNumber, SecondNumber).ToString(CultureInfo.InvariantCulture) : client.Subtraction(SecondNumber, FirstNumber).ToString(CultureInfo.InvariantCulture);

            MutliplicationTextBox.Text =
                client.Multiplication(FirstNumber, SecondNumber).ToString(CultureInfo.InvariantCulture);
            if (SecondNumber != 0)
                DivTextBox.Text = client.Division(FirstNumber, SecondNumber).ToString(CultureInfo.InvariantCulture);
            else
            {
                MessageBox.Show(@"Divide By Zero");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModuloTextBox.Clear();
            var client = new ModuloServiceClient("NetTcpBinding_IModuloService");
            FirstNumber = Convert.ToInt32(firstNumTextBox.Text);
            SecondNumber = Convert.ToInt32(LastNumTextBox.Text);
            if (SecondNumber > 1)
               ModuloTextBox.Text = client.Modulo(FirstNumber, SecondNumber).ToString(CultureInfo.InvariantCulture);
            else
            {
                MessageBox.Show(@"I won't do any modulus!");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            firstNumTextBox.Clear();
            LastNumTextBox.Clear();
            AddTextBox.Clear();
            SubTextBox.Clear();
            ModuloTextBox.Clear();
            DivTextBox.Clear();
            MutliplicationTextBox.Clear();
        }
    }
}
