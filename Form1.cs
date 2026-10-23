using System.ComponentModel;

namespace examen_2
{
    public partial class Form1 : Form
    {
        private BindingList<Producto> listaProductos = new BindingList<Producto>();
        private BindingList<Pedido> listaPedidos = new BindingList<Pedido>();

        public Form1()
        {
            InitializeComponent();
            InicializarDatosYControles();
        }

        private void InicializarDatosYControles()
        {
            listaProductos.Add(new Producto("Cafe", 30.00m));
            listaProductos.Add(new Producto("Tw", 25.00m));
            listaProductos.Add(new Producto("Sandwich", 55.00m));
            listaProductos.Add(new Producto("Galletas", 20.00m));

            cbProd.DataSource = listaProductos;

            dgPedReg.DataSource = listaPedidos;

            if (dgPedReg.Columns["Subtotal"] != null)
            {
                dgPedReg.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
            }

            ActualizarPrecioUnitario();
            ActualizarTotalGeneral();
        }

        private void ActualizarPrecioUnitario()
        {
            if (cbProd.SelectedItem is Producto productoSeleccionado)
            {
                txbPrecioU.Text = productoSeleccionado.Precio.ToString("C2");
            }
            else
            {
                txbPrecioU.Text = string.Empty;
            }
        }

        private void ActualizarTotalGeneral()
        {
            decimal total = listaPedidos.Sum(p => p.Subtotal);
            lblTotal.Text = $"Total: {total:C2}";
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (cbProd.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Producto producto = (Producto)cbProd.SelectedItem;
            int cantidad = (int)numUDCant.Value;
            bool paraLlevar = chebToGo.Checked;

            Pedido nuevoPedido = new Pedido(producto, cantidad, paraLlevar);
            listaPedidos.Add(nuevoPedido);

            ActualizarTotalGeneral();

            numUDCant.Value = 1;
            chebToGo.Checked = false;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgPedReg.CurrentRow != null && dgPedReg.CurrentRow.DataBoundItem is Pedido pedidoSeleccionado)
            {
                listaPedidos.Remove(pedidoSeleccionado);
                ActualizarTotalGeneral();
            }
            else
            {
                MessageBox.Show("Seleccione una fila completa de la lista para eliminar");
            }
        }

        private void btnVaciar_Click_1(object sender, EventArgs e)
        {
            if (listaPedidos.Count == 0)
            {
                MessageBox.Show("No hay pedidos capturados para vaciar.");
                return;
            }

            listaPedidos.Clear();
            ActualizarTotalGeneral();
        }
    }
}

