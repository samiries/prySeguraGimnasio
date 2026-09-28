namespace prySeguraGimnasio
{
    public partial class FrmInscripcion : Form
    {
        public FrmInscripcion()
        {
            InitializeComponent();
            chkEstudiante.Checked = false;
            chkCasillero.Checked = false;

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

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);
            int meses = int.Parse(txtMeses.Text);
            int precio_mensual = 0;
            int precio_casillero = 0;
            Decimal subtotal = 0;
            int descuento = 0;

            switch (cboPlan.SelectedIndex)
            {
                case 0:
                    precio_mensual = PRECIO_MUSCULACION;
                    break;
                case 1:
                    precio_mensual = PRECIO_FUNCIONAL;
                    break;
                case 2:
                    precio_mensual = PRECIO_NATACION;
                    break;
                default:
                    precio_mensual = 0;
                    break;
            }

            if (chkCasillero.Checked)
            {
                precio_casillero = PRECIO_CASILLERO;
            }
            else
            {
                precio_casillero = 0;
            }

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

            subtotal = (precio_mensual + precio_casillero) * meses;

        }
    }
}
