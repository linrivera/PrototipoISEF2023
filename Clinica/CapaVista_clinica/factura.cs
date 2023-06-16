using CapaLogica_clinica;
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

namespace CapaVista_clinica
{
    public partial class factura : Form
    {
        public factura()
        {
            InitializeComponent();
            llenarcombobox();
            getIdEncabezado();
            bloquear();
        }
        CapaLogica_clinica.Controladorcl controlador = new CapaLogica_clinica.Controladorcl();
        private void llenarcombobox()
        {
            controlador.llenarCombo("tbl_paciente", txt_paciente);
            controlador.llenarCombo("tbl_pago", txtpago);
            controlador.llenarCombo2( txt_exam);
            tbl_detalle.Columns.Add("1", "id");
            tbl_detalle.Columns.Add("2", "precio");
        }
        private void getIdEncabezado()
        {
            controlador.setNewId(txt_encabezado, "tbl_encabezadofactura", "pk_idEncabezado");
            controlador.setNewId(txt_serie, "tbl_encabezadofactura", "pk_idEncabezado");
            controlador.setNewId(txt_nofactura, "tbl_encabezadofactura", "pk_idEncabezado");
            txt_total.Text = "0";
        }

        private void bloquear()
        {
            txt_encabezado.Enabled = false;
            txt_fecha.Enabled = false;
            txt_serie.Enabled = false;
            txt_total.Enabled = false;
            txt_nofactura.Enabled = false;
            txt_iddetalle.Enabled = false;
            txt_exam.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_exam.SelectedIndex != null)
            {

                string[] infoExamen = txt_exam.SelectedItem.ToString().Split('-');

                bool existeDato = false;
                foreach (DataGridViewRow row in tbl_detalle.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == infoExamen[0])
                    {
                        existeDato = true;
                        break;
                    }
                }

                if (!existeDato)
                {
                    // Agregar una nueva fila con el dato ingresado
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(tbl_detalle);
                    newRow.Cells[0].Value = infoExamen[0];
                    newRow.Cells[1].Value = infoExamen[3];
                    tbl_detalle.Rows.Add(newRow);
                    float newTotal = float.Parse(txt_total.Text) + float.Parse(infoExamen[3]);
                    txt_total.Text = newTotal.ToString();

                }
                else
                {
                    MessageBox.Show("El dato ya existe en el DataGridView.");
                }
            }
        }

        private void Sieguiente_Click(object sender, EventArgs e)
        {

            if (txtpago.SelectedIndex != null && txt_paciente.SelectedIndex != null && txt_encabezado.Text.Length != 0
                && txt_serie.Text.Length != 0 && txt_nofactura.Text.Length != 0)
            {
                txt_iddetalle.Text = txt_encabezado.Text; 
                txt_exam.Enabled = true;
                txt_paciente.Enabled = false;
                txtpago.Enabled = false;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (txtpago.SelectedIndex != null && txt_paciente.SelectedIndex != null && txt_encabezado.Text.Length != 0
                && txt_serie.Text.Length != 0 && txt_nofactura.Text.Length != 0)
            {
                Console.WriteLine("A");
                if (tbl_detalle.Rows.Count > 0)
                {
                    Console.WriteLine("A");

                    string[] infoPaciente = txt_exam.SelectedItem.ToString().Split('-');
                    string[] infoPago = txt_exam.SelectedItem.ToString().Split('-');
                    string fechaActual = DateTime.Now.ToString("yyyy-MM-dd");

                    List<string> encabezado = new List<string>();
                    List<string> detalle = new List<string>();
                    encabezado.Add(txt_encabezado.Text);
                    encabezado.Add(txt_serie.Text);
                    encabezado.Add(txt_nofactura.Text);
                    encabezado.Add(infoPaciente[0]);
                    encabezado.Add(fechaActual);
                    encabezado.Add(txt_total.Text);
                    encabezado.Add(infoPago[0]);



                    foreach (DataGridViewRow row in tbl_detalle.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            detalle.Add(txt_iddetalle.Text+","+ txt_encabezado.Text + ","+row.Cells[0].Value.ToString() + "," + row.Cells[1].Value.ToString());
                        }
                    }
                    controlador.registrarVenta(encabezado, detalle);
                }
            }
        }
    }
}
