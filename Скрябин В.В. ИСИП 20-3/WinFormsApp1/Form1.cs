using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// ЛАБ. РАБОТА 3
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double z = Convert.ToDouble(textBox3.Text);
            double res;

            if (1 < x * y || x * y < 10)
            {
                res = Math.E * Math.Pow(x, 2);
            }
            if (12 > x * y || x * y < 40)
            {
                res = Math.Sqrt(Math.Abs(Math.Pow(x, 2) + 4 * y));
            }
            else
            {
                res = y * Math.Pow(Math.Pow(x, 2),2);
            }

            if(radioButton1.Checked = true)
            {
                res = Math.Sin(res);
            }

            if(radioButton2.Checked = true)
            {
                res = Math.Cos(res);
            }

            if(radioButton3.Checked = true)
            {
                res = Math.Exp(res);
            }

            textBox4.Text += Environment.NewLine + "Выполнил: Скрябин В.В. ИСИП 20-3";
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();
            textBox4.Text += Environment.NewLine + "Результат U = " + res.ToString();
            textBox4.Text += Environment.NewLine + "Результат с RadioButton'а = " + res.ToString();
        }
    }
}
