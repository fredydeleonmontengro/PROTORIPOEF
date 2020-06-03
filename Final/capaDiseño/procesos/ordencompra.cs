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
    public partial class ordencompra : Form
    {
        public ordencompra()
        {
            InitializeComponent();
            MostrarConsulta();
        }
        logica logic = new logica();
        string codigoproduct;
        string producto;
        public void MostrarConsulta()
        {
            OdbcDataReader mostrar = logic.productos();
            try
            {
                while (mostrar.Read())
                {
                    string s = mostrar.GetString(0) + mostrar.GetString(1);
                    Console.WriteLine(s);
                    dataGridView1.Rows.Add(mostrar.GetString(0), mostrar.GetString(1));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void subtotal()
        {
            //Variable donde almacenaremos el resultado de la sumatoria.
            double sumatoria = 0;
            //Método con el que recorreremos todas las filas de nuestro Datagridview
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                //Aquí seleccionaremos la columna que contiene los datos numericos.
                sumatoria += Convert.ToDouble(row.Cells["Column2"].Value);
            }
            //Por ultimo asignamos el resultado a el texto de nuestro Label
            textBox3.Text = Convert.ToString(sumatoria);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarConsulta();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                codigoproduct = dataGridView1.Rows[dataGridView1.CurrentRow.Index].
                  Cells[0].Value.ToString();
                producto = dataGridView1.Rows[dataGridView1.CurrentRow.Index].
                    Cells[1].Value.ToString();

            }
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(codigoproduct, producto, textBox4.Text, textBox5.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ORDEN DE COMPRA ALMACENADA Y PEDIDA");
        }
    }
}
