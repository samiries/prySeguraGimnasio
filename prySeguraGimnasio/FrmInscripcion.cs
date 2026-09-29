

namespace prySeguraGimnasio
{
    public partial class FrmInscripcion : Form
    {
        public FrmInscripcion()
        {
            InitializeComponent();
            chkEstudiante.Checked = false;
            chkCasillero.Checked = false;

            txtNombre.TextChanged += validarbtncalcular;
            txtEdad.TextChanged += validarbtncalcular;
            txtMeses.TextChanged += validarbtncalcular;

        }

        public struct SOCIO
        {
            public string nombre;
            public int edad;
            public string categoria;
            public string plan;
            public string horario;
            public int meses;
            public string formadepago;
            public decimal total;
            public decimal valorcuota;


        }

        const int PRECIO_MUSCULACION = 15000;
        const int PRECIO_FUNCIONAL = 18000;
        const int PRECIO_NATACION = 22000;
        const int PRECIO_CASILLERO = 3000;

        const int EDAD_MINIMA = 14;

        const int DESCUENTO_ESTUDIANTE = 15;
        const int DESCUENTO_MENOR18 = 25;
        const int DESCUENTO_MAYOROIGUAL65 = 30;

        const int DESCUENTO_EFECTIVO = 10;

        const int RECARGO_TARJETA_1CUOTA = 0;
        const int RECARGO_TARJETA_3CUOTAS = 10;
        const int RECARGO_TARJETA_6CUOTAS = 20;


        private void EstadoInicial()
        {
            txtEdad.Clear();
            txtNombre.Clear();
            txtMeses.Text = "1";
            chkCasillero.Checked = false;
            chkEstudiante.Checked = false;
            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;
            cboCuotas.SelectedIndex = -1;
            cboCuotas.Enabled = false;
            rbtEfectivo.Checked = true;
            rbtTarjeta.Checked = false;
            btnCalcular.Enabled = false;


        }

        private void FrmInscripcion_Load(object sender, EventArgs e)
        {
            EstadoInicial();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);


            int meses = int.Parse(txtMeses.Text);

            if (edad < EDAD_MINIMA)
            {
                MessageBox.Show("No se puede Inscribir, no llega a la edad minima de " + EDAD_MINIMA, "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (meses < 1 || meses > 12)
            {
                MessageBox.Show("Los meses deben estar entre 1 y 12.", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int precio_Mensual = 0;
            int precio_casillero = 0;
            Decimal subtotal = 0;
            int descuento = 0;

            switch (cboPlan.Text)
            {
                case "Musculacion":
                    precio_Mensual = PRECIO_MUSCULACION;
                    break;
                case "Funcional":
                    precio_Mensual = PRECIO_FUNCIONAL;
                    break;
                case "Natacion":
                    precio_Mensual = PRECIO_NATACION;
                    break;
                default:
                    MessageBox.Show("Plan invalido");
                    precio_Mensual = 0;
                    break;
            }

            string horario = "";

            switch (cboTurno.SelectedIndex)
            {
                case 0:
                    horario = "7 a 12 h";
                    break;
                case 1:
                    horario = "14 a 18 h";
                    break;
                case 2:
                    horario = "18 a 23 h";
                    break;
                default:
                    horario = "";
                    break;
            }

            if (chkCasillero.Checked) precio_Mensual += PRECIO_CASILLERO;

            if (edad < 18)
            {
                descuento = DESCUENTO_MENOR18;
            }
            else
            {
                if (edad >= 65)
                {
                    descuento = DESCUENTO_MAYOROIGUAL65;
                }
                else
                {
                    if (chkEstudiante.Checked)
                    {
                        descuento = DESCUENTO_ESTUDIANTE;
                    }
                    else
                    {
                        descuento = 0;
                    }
                }
            }

            subtotal = precio_Mensual * meses;
            decimal importeConDescuento = subtotal - (subtotal * descuento / 100);

            decimal ajuste = 0;
            decimal total = 0;

            if (rbtEfectivo.Checked)
            {
                ajuste = DESCUENTO_EFECTIVO;
                total = importeConDescuento - (importeConDescuento * ajuste / 100);
            }
            else
            {
                int cuotas = int.Parse(cboCuotas.Text);

                if (cuotas == 1)
                {
                    ajuste = RECARGO_TARJETA_1CUOTA;
                }
                else if (cuotas == 3)
                {
                    ajuste = RECARGO_TARJETA_3CUOTAS;
                }
                else if (cuotas == 6)
                {
                    ajuste = RECARGO_TARJETA_6CUOTAS;
                }

                total = importeConDescuento + (importeConDescuento * ajuste / 100);
            }
            int cuotasElegidas = rbtTarjeta.Checked ? int.Parse(cboCuotas.Text) : 1;
            string textoPago = rbtEfectivo.Checked ? "Efectivo" : "Tarjeta en " + cuotasElegidas + " cuotas";
            decimal valorCuota = rbtEfectivo.Checked ? total : total / cuotasElegidas;
            string CondicionEdadSocio = edad >= 18 ? "Mayor" : "Menor";

            SOCIO socio;
            socio.nombre = nombre;
            socio.edad = edad;
            socio.categoria = CondicionEdadSocio;
            socio.plan = cboPlan.Text;
            socio.horario = horario;
            socio.meses = meses;
            socio.formadepago = textoPago;
            socio.total = total;
            socio.valorcuota = valorCuota;

            string mensaje = "Socio: " + socio.nombre + "\n" +
                              "Edad: " + socio.edad + " (" + socio.categoria + ")" + "\n" +
                              "Plan: " + socio.plan + "\n" +
                              "Turno: " + socio.horario + "\n" +
                              "Meses: " + socio.meses + "\n" +
                              "Forma de pago: " + socio.formadepago + "\n" +
                              "Total: " + socio.total.ToString("C") + "\n" +
                              "Valor de cuota: " + socio.valorcuota.ToString("C");

            MessageBox.Show(mensaje, "Inscripción registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

            EstadoInicial();


        }

        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTarjeta.Checked)
            {
                cboCuotas.Enabled = true;
                cboCuotas.SelectedIndex = 0;
            }
            else
            {
                cboCuotas.Enabled = false;
                cboCuotas.SelectedIndex = -1;
            }
        }

        private void txtMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void validarbtncalcular(object sender, EventArgs e)
        {
            btnCalcular.Enabled = txtNombre.Text != "" && txtEdad.Text != "" && txtMeses.Text != "" ? true : false;
        }
    }
}
