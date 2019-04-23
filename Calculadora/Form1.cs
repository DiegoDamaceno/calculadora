using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum1.Text = "";
            txtnum2.Text = "";
            txtresultado1.Text = "";
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //declarando variaveis do tipo double
            double num1, num2, resultado;
            /*num1 e num2 recebem o conteudo do textbox
             * (txtnum1.text e txtnum2.text)
             * Convert.Todouble é necessário para que seja convertido o conteudo
             * do textbox em número.*/
            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);
            //Variável resultado = recebe conteúdo de num1 + num2 e realiza o cálculo
            resultado = num1 + num2;
            //txtresultado.txt = recebe conteúdo da variável resultado e converte para número
            txtresultado1.Text = resultado.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);
            resultado = num1 - num2;
            txtresultado1.Text = resultado.ToString();
         }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);
            resultado = num1 * num2;
            txtresultado1.Text = resultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);
            resultado = num1 / num2;
            txtresultado1.Text = resultado.ToString();
        }
    }
}
