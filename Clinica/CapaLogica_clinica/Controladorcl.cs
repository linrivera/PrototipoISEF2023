using CapsDatos;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica_clinica
{
    public class Controladorcl
    {
        Sentencias sentencias = new Sentencias();
        Conexion conexion = new Conexion();
        public void llenarCombo(string tabla, ComboBox comboBox)
        {
            comboBox.Items.Clear();
            List<string> almacenes = sentencias.getDatosComboBox(tabla);
            foreach (string almacen in almacenes)
            {
                comboBox.Items.Add(almacen);
            }
        }
        public void llenarCombo2(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            List<string> almacenes = sentencias.getExamenes();
            foreach (string almacen in almacenes)
            {
                comboBox.Items.Add(almacen);
            }
        }
        public void registrarVenta(List<string> encabezado, List<string> detalle)
        {
            char[] caracteresEliminar = { ',' };
            string valuesEncabezado = "";
            string valuesDetalle = "";

            foreach (string datos in encabezado)
            {
                valuesEncabezado += "'" + datos + "',";
            }
            valuesEncabezado = valuesEncabezado.TrimEnd(caracteresEliminar);

            foreach (string datos in detalle)
            {
                valuesDetalle += datos + ",";
            }
            valuesDetalle = valuesDetalle.TrimEnd(caracteresEliminar);

            sentencias.insert("tbl_encabezadofactura", valuesEncabezado);
            sentencias.insert("tbl_detallefactura", valuesDetalle);
        }

        public void setNewId(TextBox textBox, string tabla, string campo)
        {
            int id = sentencias.getNewId(campo, tabla) + 1;

            textBox.Text = id.ToString();
        }
    }
}
