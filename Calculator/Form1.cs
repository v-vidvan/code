using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int result;
        public string FinalResult;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1 == null || textBox2 == null || textBox3 == null)
            {
                FinalResult = "Please enter values in all the text boxes";
            }
            int i;
            if (int.TryParse(textBox1.Text.ToString(), out i) == false || int.TryParse(textBox3.Text.ToString(), out i)==false)
            {

                FinalResult = "Please enter integers only";
            }
            else
            {

                
                    switch (textBox2.Text)
                    {
                        case "+":
                            result = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox3.Text);
                            FinalResult = result.ToString();
                            break;
                        case "-":
                            result = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox3.Text);
                            FinalResult = result.ToString();
                            break;
                        case "*":
                            result = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox3.Text);
                            FinalResult = result.ToString();
                            break;
                        case "/":
                            if (Convert.ToInt32(textBox3.Text) == 0) {
                                FinalResult = "Cannot divide by 0(Invalid Operation)";
                            }
                            else { 
                            result = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox3.Text);
                            FinalResult = result.ToString();
                            }
                            break;
                        default:
                            FinalResult = "Invalid Operator";
                            break;

                    }
               
               // FinalResult = FinalResult.Contains("Invalid Operator") ? FinalResult = "Invalid Operator" : FinalResult.Contains("Cannot")?FinalResult =FinalResult:FinalResult= result.ToString();

               // label1.Text = FinalResult;
               
            }
            if (FinalResult != null)
            {
                label1.Text = FinalResult;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
