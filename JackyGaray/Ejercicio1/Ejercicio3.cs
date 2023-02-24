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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1; i <= 100; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    listBox1.Items.Add("Número " + i + ":  Jacky Lara");

                }
                else
                if (i % 3 == 0)
                {
                    listBox1.Items.Add("Número " + i + ":  Jacky");

                }
                else
                 if (i % 5 == 0)
                {
                    listBox1.Items.Add("Número " + i + ":  Lara");
                }
                else
                {
                    listBox1.Items.Add("Número " + i );
                }


            }
        }
    }
}
