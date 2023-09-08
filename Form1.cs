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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( !string.IsNullOrEmpty(TX_1.Text) )
            {
                if ( Int32.TryParse(TX_1.Text, out int num))
                {
                    TX_2.Text = Recursivo(num).ToString();
                }
            }
        }
        private int Recursivo(int num)
        {
            int resultado = 1;
            if (num > 1) { return num + Recursivo(num - 1); }

            return resultado;

        }
    }
}
