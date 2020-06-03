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

namespace capaDiseño.consultas
{
    public partial class bodegasexistentes : Form
    {
        public bodegasexistentes()
        {
            InitializeComponent();
            MostrarConsulta();
        }
        logica logic = new logica();

        public void MostrarConsulta()
        {
            OdbcDataReader mostrar = logic.bodegas();
            try
            {
                while (mostrar.Read())
                {
                    string s = mostrar.GetString(0) + mostrar.GetString(1) ;
                    Console.WriteLine(s);
                    dataGridView1.Rows.Add(mostrar.GetString(0), mostrar.GetString(1));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            MostrarConsulta();

        }

        private void bodegasexistentes_Load(object sender, EventArgs e)
        {

        }
    }
}
