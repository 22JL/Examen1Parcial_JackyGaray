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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] meses = new string[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            double interes = 0;
            double capital = 200000;
           
            listBox1.Items.Clear();
            for (int i = 0; i < meses.Length; i++)
            {
                interes = capital * 0.015 * (i + 1);
                listBox1.Items.Add("En " + meses[i] + " ganará L. " + interes);
            }
        }
    }
}
