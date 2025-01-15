using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.VisualStyles.VisualStyleElement.Button.RadioButton;

namespace CASA_DE_CAMBIO
{
    public partial class Form1 : Form
    {
        private double tasaUSD = 2.0;
        private double tasaEUR = 0.85;
        private double tasaMXN = 20.0;
        private double tasaJPY = 10.0;

        // Método para calcular la conversión dependiendo del RadioButton seleccionado
        // Método para calcular la conversión dependiendo del RadioButton seleccionado
        private void CalcularConversion()
        {
            double cantidad;

            // Verificar si el valor en el TextBox2 es un número válido
            if (double.TryParse(textBox2.Text, out cantidad))
            {
                double resultado = 0;

                // Determinar qué RadioButton está seleccionado y realizar la conversión
                if (radioButton1.Checked) // Moneda 1 (USD)
                {
                    resultado = cantidad * tasaUSD;
                    pictureBox1.Image = imageList1.Images[0];
                    label2.Text = ("CANTIDAD EN EUROS");
                }
                else if (radioButton2.Checked) // Moneda 2 (EUR)
                {
                    resultado = cantidad * tasaEUR;
                    pictureBox1.Image = imageList1.Images[1];
                    label2.Text = ("CANTIDAD EN YUANES");
                }
                else if (radioButton3.Checked) // Moneda 3 (MXN)
                {
                    resultado = cantidad * tasaMXN;
                    pictureBox1.Image = imageList1.Images[2];
                    label2.Text = ("CANTIDAD EN DOLARES");
                }
                else if (radioButton4.Checked) // Moneda 4 (JPY)
                {
                    resultado = cantidad * tasaJPY;
                    pictureBox1.Image = imageList1.Images[3];
                    label2.Text = ("CANTIDAD EN RUBLOS");
                }

                // Mostrar 
                textBox1.Text =resultado.ToString("F2");
              
            }
            else
            {
                // Mensaje de error si no se introduce un número válido
                textBox1.Text = "Por favor ingrese un valor numérico válido.";
                label2.Visible = false;

            }
        }

        public Form1()
                 {
            InitializeComponent();
    }





    private void label1_Click(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {
                Close();
            }

            private void button2_Click(object sender, EventArgs e)
            {
            textBox2.Clear();
            groupBox1.Visible = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

            private void textBox2_TextChanged(object sender, EventArgs e)
            {
                if (textBox2.Text != "")
                {
                    groupBox1.Visible = true;
                }

            }

           

            private void radioButton1_CheckedChanged(object sender, EventArgs e)
            {
                if (radioButton1.Checked)
                {
                    CalcularConversion();
                }
            }

            private void radioButton2_CheckedChanged(object sender, EventArgs e)
            {
                if (radioButton2.Checked)
                {
                    CalcularConversion();
                }
            }

            private void radioButton3_CheckedChanged(object sender, EventArgs e)
            {
            if (radioButton3.Checked)
            {
                CalcularConversion();
            }
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                CalcularConversion();
            }
        }
    }
}
