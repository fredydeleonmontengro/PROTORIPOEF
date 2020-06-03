using capaDiseño.consultas;
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
    public partial class agregarbodega : Form
    {
        public agregarbodega()
        {
            InitializeComponent();
        }
        logica logic = new logica();

        private void button2_Click(object sender, EventArgs e)
        {
            bodegasexistentes form = new bodegasexistentes();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.bodegasadd(textBox1.Text, textBox2.Text);
            MessageBox.Show("GUARDADA");
            textBox1.Clear();
            textBox2.Clear();
        }

        private void agregarbodega_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
