using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                double num1 = Convert.ToDouble(txtNumero1.Text);
                double num2 = Convert.ToDouble(txtNumero2.Text);

                
                double resultado = num1 + num2;

                
                listBoxResultados.Items.Add(resultado);
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, ingrese números válidos.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                double num1 = Convert.ToDouble(txtNumero1.Text);
                double num2 = Convert.ToDouble(txtNumero2.Text);

                
                double resultado = num1 - num2;

                
                listBoxResultados.Items.Add(resultado);
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, ingrese números válidos.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            listBoxResultados.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
