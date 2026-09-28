namespace prySeguraGimnasio
{
    partial class FrmInscripcion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpdatospersonales = new GroupBox();
            chkEstudiante = new CheckBox();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            lbledad = new Label();
            lblnombre = new Label();
            grpPlan = new GroupBox();
            lblmeses = new Label();
            chkCasillero = new CheckBox();
            lblturno = new Label();
            lblplan = new Label();
            txtMeses = new TextBox();
            cboTurno = new ComboBox();
            cboPlan = new ComboBox();
            grpPago = new GroupBox();
            cboCuotas = new ComboBox();
            rbtTarjeta = new RadioButton();
            rbtEfectivo = new RadioButton();
            btnCalcular = new Button();
            BtnLimpiar = new Button();
            grpdatospersonales.SuspendLayout();
            grpPlan.SuspendLayout();
            grpPago.SuspendLayout();
            SuspendLayout();
            // 
            // grpdatospersonales
            // 
            grpdatospersonales.Controls.Add(chkEstudiante);
            grpdatospersonales.Controls.Add(txtEdad);
            grpdatospersonales.Controls.Add(txtNombre);
            grpdatospersonales.Controls.Add(lbledad);
            grpdatospersonales.Controls.Add(lblnombre);
            grpdatospersonales.Location = new Point(69, 31);
            grpdatospersonales.Name = "grpdatospersonales";
            grpdatospersonales.Size = new Size(235, 159);
            grpdatospersonales.TabIndex = 0;
            grpdatospersonales.TabStop = false;
            grpdatospersonales.Text = "Datos Personales";
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(40, 120);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(81, 19);
            chkEstudiante.TabIndex = 4;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(111, 56);
            txtEdad.MaxLength = 3;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 3;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(111, 19);
            txtNombre.MaxLength = 30;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // lbledad
            // 
            lbledad.AutoSize = true;
            lbledad.Location = new Point(20, 59);
            lbledad.Name = "lbledad";
            lbledad.Size = new Size(33, 15);
            lbledad.TabIndex = 1;
            lbledad.Text = "Edad";
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Location = new Point(20, 27);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(51, 15);
            lblnombre.TabIndex = 0;
            lblnombre.Text = "Nombre";
            // 
            // grpPlan
            // 
            grpPlan.Controls.Add(lblmeses);
            grpPlan.Controls.Add(chkCasillero);
            grpPlan.Controls.Add(lblturno);
            grpPlan.Controls.Add(lblplan);
            grpPlan.Controls.Add(txtMeses);
            grpPlan.Controls.Add(cboTurno);
            grpPlan.Controls.Add(cboPlan);
            grpPlan.Location = new Point(69, 205);
            grpPlan.Name = "grpPlan";
            grpPlan.Size = new Size(235, 145);
            grpPlan.TabIndex = 1;
            grpPlan.TabStop = false;
            grpPlan.Text = "Plan";
            // 
            // lblmeses
            // 
            lblmeses.AutoSize = true;
            lblmeses.Location = new Point(6, 91);
            lblmeses.Name = "lblmeses";
            lblmeses.Size = new Size(40, 15);
            lblmeses.TabIndex = 6;
            lblmeses.Text = "Meses";
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(53, 120);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(158, 19);
            chkCasillero.TabIndex = 5;
            chkCasillero.Text = "Casillero ($3000 por mes)";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // lblturno
            // 
            lblturno.AutoSize = true;
            lblturno.Location = new Point(6, 57);
            lblturno.Name = "lblturno";
            lblturno.Size = new Size(39, 15);
            lblturno.TabIndex = 4;
            lblturno.Text = "Turno";
            // 
            // lblplan
            // 
            lblplan.AutoSize = true;
            lblplan.Location = new Point(6, 25);
            lblplan.Name = "lblplan";
            lblplan.Size = new Size(30, 15);
            lblplan.TabIndex = 3;
            lblplan.Text = "Plan";
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(68, 83);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(100, 23);
            txtMeses.TabIndex = 2;
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cboTurno.Location = new Point(57, 54);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(121, 23);
            cboTurno.TabIndex = 1;
            // 
            // cboPlan
            // 
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FormattingEnabled = true;
            cboPlan.Items.AddRange(new object[] { "Musculacion", "Funcional", "Natacion" });
            cboPlan.Location = new Point(57, 22);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(121, 23);
            cboPlan.TabIndex = 0;
            // 
            // grpPago
            // 
            grpPago.Controls.Add(cboCuotas);
            grpPago.Controls.Add(rbtTarjeta);
            grpPago.Controls.Add(rbtEfectivo);
            grpPago.Location = new Point(69, 380);
            grpPago.Name = "grpPago";
            grpPago.Size = new Size(235, 122);
            grpPago.TabIndex = 2;
            grpPago.TabStop = false;
            grpPago.Text = "Forma de pago";
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cboCuotas.Location = new Point(47, 93);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(121, 23);
            cboCuotas.TabIndex = 3;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Location = new Point(70, 52);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(60, 19);
            rbtTarjeta.TabIndex = 1;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "Tarjeta";
            rbtTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(68, 22);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(67, 19);
            rbtEfectivo.TabIndex = 0;
            rbtEfectivo.TabStop = true;
            rbtEfectivo.Text = "Efectivo";
            rbtEfectivo.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(89, 532);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Location = new Point(194, 532);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(75, 23);
            BtnLimpiar.TabIndex = 4;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            // 
            // FrmInscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 576);
            Controls.Add(BtnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(grpPago);
            Controls.Add(grpPlan);
            Controls.Add(grpdatospersonales);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo - Inscripcion";
            Load += FrmInscripcion_Load;
            grpdatospersonales.ResumeLayout(false);
            grpdatospersonales.PerformLayout();
            grpPlan.ResumeLayout(false);
            grpPlan.PerformLayout();
            grpPago.ResumeLayout(false);
            grpPago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpdatospersonales;
        private CheckBox chkEstudiante;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private Label lbledad;
        private Label lblnombre;
        private GroupBox grpPlan;
        private Label lblturno;
        private Label lblplan;
        private TextBox txtMeses;
        private ComboBox cboTurno;
        private ComboBox cboPlan;
        private Label lblmeses;
        private CheckBox chkCasillero;
        private GroupBox grpPago;
        private RadioButton rbtTarjeta;
        private RadioButton rbtEfectivo;
        private ComboBox cboCuotas;
        private Button btnCalcular;
        private Button BtnLimpiar;
    }
}
