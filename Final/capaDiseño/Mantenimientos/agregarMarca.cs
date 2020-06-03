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
    public partial class agregarMarca : Form
    {
        public agregarMarca()
        {
            InitializeComponent();
        }
        logica logic = new logica();

        private void agregarMarca_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.marcasadd(textBox1.Text, textBox2.Text);
            MessageBox.Show("GUARDADA");
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
