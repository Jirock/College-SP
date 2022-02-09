using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double num3 = Convert.ToDouble(textBox3.Text);
            double result = 2 * Math.Cos((num1) - Math.PI / 6) / (0.5 + Math.Sin(num2 * 2) * (1 + num3 * 2 / (3 - num3 * 2 / 5)));

            textBox4.Text += Environment.NewLine + "Выполнил: Скрябин В.В. ИСИП 20-3";
            textBox4.Text += Environment.NewLine + "X = " + num1.ToString();
            textBox4.Text += Environment.NewLine + "Y = " + num2.ToString();
            textBox4.Text += Environment.NewLine + "Z = " + num3.ToString();
            textBox4.Text += Environment.NewLine + "Результат U = " + result.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
