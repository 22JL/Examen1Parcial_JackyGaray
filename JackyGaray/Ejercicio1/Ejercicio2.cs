using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }
        string[] nombreProducto = new string[100];
        decimal[] precio = new decimal[100];
        int contador = 0;

        private async void button1_Click(object sender, EventArgs e)
        {

            decimal resultado = await CalcularAsync(); //


            decimal total = resultado - (resultado * Convert.ToDecimal(0.15));

            listBox1.Items.Clear();
            for (int i = 0; i < contador; i++)
            {
                listBox1.Items.Add(nombreProducto[i] + " ........... L. " + precio[i]);
            }

            listBox1.Items.Add("");
            listBox1.Items.Add("Sub Total .......... L. " + resultado);
            listBox1.Items.Add("Descuento 15% ...... L. " + resultado * Convert.ToDecimal(0.15));
            listBox1.Items.Add("Total a cancelar ..... L. " + total);




        }
        
        private async Task<decimal> CalcularAsync()
        {
            
            decimal suma = await Task.Run(() =>
            {
                decimal total = 0;
                for (int i = 0; i < precio.Length; i++)
                {
                    total += precio[i];
                }                
                return total;
            });

            return suma;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Ingrese el nombre del producto");
                textBox1.Focus();
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Ingrese el precio del producto");
                textBox2.Focus();
                return;
            }
            errorProvider1.Clear();

            nombreProducto[contador] = textBox1.Text;
            precio[contador] = Convert.ToDecimal(textBox2.Text);
            contador++;
            textBox1.Clear();
            textBox2.Clear();

            listBox1.Items.Clear();
            for (int i = 0; i < contador; i++)
            {
                listBox1.Items.Add(nombreProducto[i] + " ........... L. " + precio[i]);
            }
        }

       
    }
}
