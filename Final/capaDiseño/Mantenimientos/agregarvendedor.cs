using capaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaDiseño.Mantenimientos
{
    public partial class agregarvendedor : Form
    {
        public agregarvendedor()
        {
            InitializeComponent();
        }

        logica logic = new logica();
        private void button1_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.vendedoradd(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            MessageBox.Show("GUARDADA");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }
    }
}
