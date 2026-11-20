namespace Cafeteria_El_buen_sabor
{
    public partial class frmPedidos : Form
    {
        // constantes de negocio
        private const decimal RECARGO_GRANDE = 25m;
        private const decimal RECARGO_PORCION_EXTRA = 30m;
        private const decimal PORCENTAJE_DESCUENTO_FRECUENTE = 0.10m;
        private const decimal COSTO_EMPAQUE_LLEVAR = 20m;
        private const decimal TASA_ITBIS = 0.18m;

        // Anchos de columnas para encabezado y lista de productos
        private const int ANCHO_CANT = 6;
        private const int ANCHO_PRODUCTO = 24;
        private const int ANCHO_PRECIO = 10;
        private const int ANCHO_TOTAL = 12;

        // acumulador del subtotal del pedido
        private decimal subtotal = 0m;

        public frmPedidos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarEncabezado();
            LimpiarPedido();
        }

        private void lblEncabezado_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                MessageBox.Show("Debes ingresar el nombre del producto.", "Dato faltante",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProducto.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precioBase) || precioBase <= 0)
            {
                MessageBox.Show("Ingresa un precio numérico válido mayor que 0.", "Precio inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;
            }

            int cantidad = (int)nudCantidad.Value;
            decimal precioUnitario = CalcularPrecioUnitario(precioBase);
            decimal totalLinea = precioUnitario * cantidad;

            subtotal += totalLinea;

            string etiquetaDetalle = ObtenerEtiquetaDetalle();
            string descripcion = $"{txtProducto.Text.Trim()} ({etiquetaDetalle})";

            if (descripcion.Length > ANCHO_PRODUCTO - 1)
            {
                descripcion = descripcion.Substring(0, ANCHO_PRODUCTO - 1);
            }

            string lineaPedido = cantidad.ToString().PadRight(ANCHO_CANT) +
                                 descripcion.PadRight(ANCHO_PRODUCTO) +
                                 precioUnitario.ToString("N2").PadLeft(ANCHO_PRECIO) +
                                 totalLinea.ToString("N2").PadLeft(ANCHO_TOTAL);

            lstPedido.Items.Add(lineaPedido);
            lblSubtotal.Text = $"RD$ {subtotal:N2}";

            ReiniciarControlesProducto();


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (lstPedido.Items.Count == 0)
            {
                MessageBox.Show("Agrega al menos un producto antes de calcular el total.", "Pedido vacío",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProducto.Focus();
                return;
            }

            decimal descuento = chkFrecuente.Checked ? subtotal * PORCENTAJE_DESCUENTO_FRECUENTE : 0m;
            decimal empaque = rbtLlevar.Checked ? COSTO_EMPAQUE_LLEVAR : 0m;
            decimal baseImponible = subtotal - descuento + empaque;
            decimal itbis = baseImponible * TASA_ITBIS;
            decimal totalPagar = baseImponible + itbis;

            lblSubtotal.Text = $"RD$ {subtotal:N2}";
            lblDescuento.Text = $"RD$ {descuento:N2}";
            lblEmpaque.Text = $"RD$ {empaque:N2}";
            lblItbis.Text = $"RD$ {itbis:N2}";
            lblTotal.Text = $"RD$ {totalPagar:N2}";

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarPedido();
        }
        //nesesita consirmacion para salir de la aplicacion
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Deseas salir de la aplicación?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void ConfigurarEncabezado()
        {
            lblEncabezado.Text = "Cant".PadRight(ANCHO_CANT) +
                                 "Producto".PadRight(ANCHO_PRODUCTO) +
                                 "Precio".PadLeft(ANCHO_PRECIO) +
                                 "Total".PadLeft(ANCHO_TOTAL);
        }

        private decimal CalcularPrecioUnitario(decimal precioBase)
        {
            decimal precioFinal = precioBase;

            if (rbtGrande.Checked)
            {
                precioFinal += RECARGO_GRANDE;
            }

            if (chkPorcionExtra.Checked)
            {
                precioFinal += RECARGO_PORCION_EXTRA;
            }

            return precioFinal;
        }

        private string ObtenerEtiquetaDetalle()
        {
            if (rbtGrande.Checked)
            {
                return "Grande";
            }

            if (chkPorcionExtra.Checked)
            {
                return "Extra";
            }

            return "Normal";
        }

        private void ReiniciarControlesProducto()
        {
            txtProducto.Clear();
            txtPrecio.Clear();
            nudCantidad.Value = 1;
            rbtNormal.Checked = true;
            chkPorcionExtra.Checked = false;
            txtProducto.Focus();
        }

        private void LimpiarPedido()
        {
            txtCliente.Clear();
            dtpFecha.Value = DateTime.Now;
            chkFrecuente.Checked = false;
            rbtLocal.Checked = true;

            lstPedido.Items.Clear();
            subtotal = 0m;

            lblSubtotal.Text = "RD$ 0.00";
            lblDescuento.Text = "RD$ 0.00";
            lblEmpaque.Text = "RD$ 0.00";
            lblItbis.Text = "RD$ 0.00";
            lblTotal.Text = "RD$ 0.00";

            ReiniciarControlesProducto();
            txtCliente.Focus();
        }

        private void nudCantidad_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }


}  
