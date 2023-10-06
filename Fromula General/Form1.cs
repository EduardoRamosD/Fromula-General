using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fromula_General
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double a, b, c, x1, x2;
            
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);


            x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

            label5.Text = x1.ToString();
            label6.Text = x2.ToString();

            string Mensaje = ("Valores ingresados:"   +   "a:"  +  a  +  "b:"  +   b   +   "c:"  +  c  + "\n resultado x1=" + x1   + "resultado x2="  +  x2);

            MessageBox.Show(Mensaje, "Valores y Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);



            
        }
    }
}
