using capaDiseño.consultas;
using capaDiseño.Mantenimientos;
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

namespace capaDiseño.procesos
{
    public partial class nuevoproducto : Form
    {
        public nuevoproducto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            marcas form = new marcas();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            agregarMarca form = new agregarMarca();
            form.ShowDialog();
        }

        logica logic = new logica();
        private void button1_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.productoadd(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            MessageBox.Show("GUARDADA");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
          

        }
    }
}
