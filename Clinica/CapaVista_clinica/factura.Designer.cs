
namespace CapaVista_clinica
{
    partial class factura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_encabezado = new System.Windows.Forms.TextBox();
            this.txt_serie = new System.Windows.Forms.TextBox();
            this.txt_nofactura = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_paciente = new System.Windows.Forms.ComboBox();
            this.txt_fecha = new System.Windows.Forms.DateTimePicker();
            this.txtpago = new System.Windows.Forms.ComboBox();
            this.Sieguiente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbl_detalle = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_iddetalle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_exam = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "idEncabezado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Serie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "No. Factura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID Paciente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "ID Pago ";
            // 
            // txt_encabezado
            // 
            this.txt_encabezado.Location = new System.Drawing.Point(153, 41);
            this.txt_encabezado.Name = "txt_encabezado";
            this.txt_encabezado.Size = new System.Drawing.Size(100, 20);
            this.txt_encabezado.TabIndex = 7;
            // 
            // txt_serie
            // 
            this.txt_serie.Location = new System.Drawing.Point(153, 68);
            this.txt_serie.Name = "txt_serie";
            this.txt_serie.Size = new System.Drawing.Size(100, 20);
            this.txt_serie.TabIndex = 8;
            // 
            // txt_nofactura
            // 
            this.txt_nofactura.Location = new System.Drawing.Point(153, 101);
            this.txt_nofactura.Name = "txt_nofactura";
            this.txt_nofactura.Size = new System.Drawing.Size(100, 20);
            this.txt_nofactura.TabIndex = 9;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(410, 69);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 10;
            // 
            // txt_paciente
            // 
            this.txt_paciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_paciente.FormattingEnabled = true;
            this.txt_paciente.Location = new System.Drawing.Point(153, 128);
            this.txt_paciente.Name = "txt_paciente";
            this.txt_paciente.Size = new System.Drawing.Size(121, 21);
            this.txt_paciente.TabIndex = 11;
            this.txt_paciente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(410, 41);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(200, 20);
            this.txt_fecha.TabIndex = 12;
            // 
            // txtpago
            // 
            this.txtpago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtpago.FormattingEnabled = true;
            this.txtpago.Location = new System.Drawing.Point(410, 100);
            this.txtpago.Name = "txtpago";
            this.txtpago.Size = new System.Drawing.Size(121, 21);
            this.txtpago.TabIndex = 13;
            // 
            // Sieguiente
            // 
            this.Sieguiente.Location = new System.Drawing.Point(199, 167);
            this.Sieguiente.Name = "Sieguiente";
            this.Sieguiente.Size = new System.Drawing.Size(75, 23);
            this.Sieguiente.TabIndex = 15;
            this.Sieguiente.Text = "Siguiente";
            this.Sieguiente.UseVisualStyleBackColor = true;
            this.Sieguiente.Click += new System.EventHandler(this.Sieguiente_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cancelas";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbl_detalle
            // 
            this.tbl_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_detalle.Location = new System.Drawing.Point(52, 293);
            this.tbl_detalle.Name = "tbl_detalle";
            this.tbl_detalle.Size = new System.Drawing.Size(558, 275);
            this.tbl_detalle.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "ID Detalle";
            // 
            // txt_iddetalle
            // 
            this.txt_iddetalle.Location = new System.Drawing.Point(130, 206);
            this.txt_iddetalle.Name = "txt_iddetalle";
            this.txt_iddetalle.Size = new System.Drawing.Size(121, 20);
            this.txt_iddetalle.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Examen";
            // 
            // txt_exam
            // 
            this.txt_exam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_exam.FormattingEnabled = true;
            this.txt_exam.Location = new System.Drawing.Point(127, 248);
            this.txt_exam.Name = "txt_exam";
            this.txt_exam.Size = new System.Drawing.Size(308, 21);
            this.txt_exam.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(535, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(535, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Cancelas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 661);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_exam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_iddetalle);
            this.Controls.Add(this.tbl_detalle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sieguiente);
            this.Controls.Add(this.txtpago);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.txt_paciente);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_nofactura);
            this.Controls.Add(this.txt_serie);
            this.Controls.Add(this.txt_encabezado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "factura";
            this.Text = "factura";
            ((System.ComponentModel.ISupportInitialize)(this.tbl_detalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_encabezado;
        private System.Windows.Forms.TextBox txt_serie;
        private System.Windows.Forms.TextBox txt_nofactura;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.ComboBox txt_paciente;
        private System.Windows.Forms.DateTimePicker txt_fecha;
        private System.Windows.Forms.ComboBox txtpago;
        private System.Windows.Forms.Button Sieguiente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tbl_detalle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_iddetalle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txt_exam;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}