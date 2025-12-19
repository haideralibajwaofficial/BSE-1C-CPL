using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BU_Kit
{
    public partial class studentDashboard : Form
    {
        
            static bool clicked = false;
        void visible()
        {
            value1stTxt.Visible = clicked;
            value2ndTxt.Visible = clicked;
            valueResultTxt.Visible = clicked;
            plusBtn.Visible = clicked;
            minusBtn.Visible = clicked;
            divideBtn.Visible = clicked;
            multiplyBtn.Visible = clicked;
            rootBtn.Visible = clicked;
            sinBtn.Visible = clicked;
            cosBtn.Visible = clicked;
            tanBtn.Visible = clicked;
            pBtn.Visible = clicked;
            cBtn.Visible = clicked;
            equalBtn.Visible = clicked;
            factBtn.Visible = clicked;
        }

        Form Parent;

        public studentDashboard(Form parent)
        {
            InitializeComponent();
            signedInTxt.Text = menu.get(menu.enroll, "firstname") + " " + menu.get(menu.enroll, "lastname");
            visible();
            Parent = parent;
        }

        private void calculatorBtn_Click(object sender, EventArgs e)
        {
            clicked = !clicked;

            visible();
        }

        // ----------- Calculator ------------- //

        // enum to track which operation is currently selected
        enum Operation
        {
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
            Power,
            Sin,
            Cos,
            Tan,
            Sqrt,
            Factorial
        }

        // stores the currently selected operation
        Operation currentOperation = Operation.None;

        // resets calculator to initial state
        void ResetCalculator()
        {
            value1stTxt.ReadOnly = false;
            value2ndTxt.ReadOnly = true;

            value1stTxt.Text = "";
            value2ndTxt.Text = "";
            valueResultTxt.Text = "";

            currentOperation = Operation.None;
        }

        // validates and returns first value
        bool TryGetFirstValue(out double value)
        {
            return double.TryParse(value1stTxt.Text, out value);
        }

        // validates and returns second value
        bool TryGetSecondValue(out double value)
        {
            return double.TryParse(value2ndTxt.Text, out value);
        }

        // factorial logic
        int Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
                result *= i;
            return result;
        }

        // handles single value operations
        void PerformSingleValueOperation(Operation op)
        {
            if (!TryGetFirstValue(out double v1))
            {
                MessageBox.Show("Enter a valid first value");
                return;
            }

            double result = 0;

            if (op == Operation.Sin) result = Math.Sin(v1 * Math.PI / 180);
            else if (op == Operation.Cos) result = Math.Cos(v1 * Math.PI / 180);
            else if (op == Operation.Tan) result = Math.Tan(v1 * Math.PI / 180);
            else if (op == Operation.Sqrt)
            {
                if (v1 < 0)
                {
                    MessageBox.Show("Negative number not allowed");
                    return;
                }
                result = Math.Sqrt(v1);
            }
            else if (op == Operation.Factorial)
            {
                if (v1 < 0 || v1 % 1 != 0)
                {
                    MessageBox.Show("Factorial requires a whole number");
                    return;
                }
                result = Factorial((int)v1);
            }

            valueResultTxt.Text = result.ToString();
            value1stTxt.ReadOnly = true;
            //ResetCalculator();
        }

        // prepares calculator for two value operations
        void PrepareTwoValueOperation(Operation op)
        {
            if (!TryGetFirstValue(out _))
            {
                MessageBox.Show("Enter a valid first value");
                return;
            }

            currentOperation = op;
            value1stTxt.ReadOnly = true;
            value2ndTxt.ReadOnly = false;
            value2ndTxt.Focus();
        }

        // executes two value operations when equals is pressed
        void PerformTwoValueOperation()
        {
            if (currentOperation == Operation.None)
                return;

            if (!TryGetSecondValue(out double v2))
            {
                MessageBox.Show("Enter a valid second value");
                return;
            }

            double v1 = double.Parse(value1stTxt.Text);
            double result = 0;

            if (currentOperation == Operation.Add) result = v1 + v2;
            else if (currentOperation == Operation.Subtract) result = v1 - v2;
            else if (currentOperation == Operation.Multiply) result = v1 * v2;
            else if (currentOperation == Operation.Divide)
            {
                if (v2 == 0)
                {
                    MessageBox.Show("Division by zero");
                    return;
                }
                result = v1 / v2;
            }
            else if (currentOperation == Operation.Power) result = Math.Pow(v1, v2);

            valueResultTxt.Text = result.ToString();
            //ResetCalculator();
            currentOperation = Operation.None;
            value1stTxt.ReadOnly = false;
            value2ndTxt.ReadOnly = true;
            value1stTxt.Text = "";
            value2ndTxt.Text = "";

        }

        // button click methods

        private void plusBtn_Click(object sender, EventArgs e)
        {
            PrepareTwoValueOperation(Operation.Add);
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            PrepareTwoValueOperation(Operation.Subtract);
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            PrepareTwoValueOperation(Operation.Multiply);
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            PrepareTwoValueOperation(Operation.Divide);
        }

        private void pBtn_Click(object sender, EventArgs e)
        {
            PrepareTwoValueOperation(Operation.Power);
        }

        private void sinBtn_Click(object sender, EventArgs e)
        {
            PerformSingleValueOperation(Operation.Sin);
        }

        private void cosBtn_Click_1(object sender, EventArgs e)
        {
            PerformSingleValueOperation(Operation.Cos);
        }


        private void tanBtn_Click(object sender, EventArgs e)
        {
            PerformSingleValueOperation(Operation.Tan);
        }

        private void rootBtn_Click(object sender, EventArgs e)
        {
            PerformSingleValueOperation(Operation.Sqrt);
        }

        private void factBtn_Click(object sender, EventArgs e)
        {
            PerformSingleValueOperation(Operation.Factorial);
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            PerformTwoValueOperation();
        }

        private void cBtn_Click(object sender, EventArgs e)
        {
            ResetCalculator();
        }

        // --------------- Calculator ------------------- //















        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Parent.Show();
            this.Hide();
        }

        private void studentDashboard_Load(object sender, EventArgs e)
        {
           
        }
    }
}
