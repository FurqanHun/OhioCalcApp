using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1 = 0;
        double num2 = 0;
        string option = "";
        double total = 0;
        string operators = "+-*/";
        


        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn1.Text;
            txtOUT.Text = txtOUT.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn2.Text;
            txtOUT.Text = txtOUT.Text + btn1.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn3.Text;
            txtOUT.Text = txtOUT.Text + btn1.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn4.Text;
            txtOUT.Text = txtOUT.Text + btn1.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn5.Text;
            txtOUT.Text = txtOUT.Text + btn1.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn6.Text;
            txtOUT.Text = txtOUT.Text + btn1.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn7.Text;
            txtOUT.Text = txtOUT.Text + btn1.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn8.Text;
            txtOUT.Text = txtOUT.Text + btn1.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn9.Text;
            txtOUT.Text = txtOUT.Text + btn1.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn0.Text;
            txtOUT.Text = txtOUT.Text + btn1.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            option = "+";
            
            txtOUT.Text+=option;
            num1 = double.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtOUT.Text);
            option = "-";
            string value = txtOUT.Text + btnSub.Text;           //  txtOUT.AppendText(btnSub.Text+"abc");
            txtOUT.Text = value; 
            
            num1 = double.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            option = "*";
            txtOUT.Text = txtOUT.Text + btnMul.Text;
            num1 = double.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            txtOUT.Text = txtOUT.Text + btnDiv.Text;
            num1 = double.Parse(txtDisplay.Text);

            txtDisplay.Clear();
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            txtOUT.Text = txtDisplay.Text;
            num2 = double.Parse(txtDisplay.Text);

            if (option == "+")
            {
                total = num1 + num2;
            }
            if (option == "-")
            {
                total = num1 - num2;
            }
            if (option == "*")
            {
                total = num1 * num2;
            }
            if (option == "/")
            {
                total = num1 / num2;
            }
            txtDisplay.Text = total + "";
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            total = 0;
            num1 = 0;
            num2 = 0;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnDot.Text;    
        }

        private void txtOUT_TextChanged(object sender, EventArgs e)
        {
           txtOUT.Text = txtDisplay.Text;
            

        }
    }
}
