using ejecutable.CONTENEDOR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejecutable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text== "examen")
            {
                if (textBox2.Text == "final")
                {
                    programa form = new programa();
            form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("usuario o clave incorrectos");
                }
            }
            else
            {
                MessageBox.Show("usuario o clave incorrectos");
            }

        }

    
    }
}