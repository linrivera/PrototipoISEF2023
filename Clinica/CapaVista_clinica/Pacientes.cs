﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_clinica
{
    public partial class Pacientes : Form
    {
        public Pacientes()
        {
            InitializeComponent();
        }

        private void navegador1_Load_1(object sender, EventArgs e)
        {

            NavegadorVista.Navegador.idApp = "1000";
            TextBox[] Grupotextbox = { txt_id, txt_dpi, txt_nombre, txt_apellido, txt_fechanac, txt_nit, txt_estado, txt_direccion, txt_telefono };
            TextBox[] Idtextbox = { txt_id, txt_dpi };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = tbl_paciente;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(tbl_paciente, Grupotextbox, "sig");
        }
    }
}
