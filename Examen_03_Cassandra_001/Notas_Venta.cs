using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// 
/// Código realizado por Fernando De Luna Guardiola 1726916
/// 

namespace Examen_03_Cassandra_001
{
    public partial class Notas_Venta : Form
    {
        string uuidAEliminar = "";
        Guid newGuid;
        List<Tuple<int, decimal, string>> productosNotaVenta;

        public Notas_Venta()
        {
            InitializeComponent();
        }

        private void Nom_client_TextChanged(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            bool esNuevoRegistro = Agregar.Text == "Agregar Nota";


            if (Nom_client.Text == "" || Nom_emp.Text == "")
            {
                MessageBox.Show("Faltan Campos por llenar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (esNuevoRegistro)
            {
                // aqui se agrega uno nuevo
                var nombre = Nom_client.Text;
                var nombre_empresa = Nom_emp.Text;
                //var nombre_producto = Nom_proc.Text;
                var nombre_empleado = Nom_empleado.Text;

                DateTime date = Fecha_proc.Value.Date;

                EnlaceCassandra.InsertarDatosFernando(nombre, nombre_empresa, nombre_empleado, date, productosNotaVenta);
                MessageBox.Show("Datos Agregados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // aqui se modifica o edita
                newGuid = Guid.Parse(uuidAEliminar);
                //EnlaceCassandra.ObtenerDatosText(newGuid, Nom_client,Nom_emp, Cant_proc, Precio_proc, Nom_proc);

                var nombre = Nom_client.Text;
                var nombre_empresa = Nom_emp.Text;
                var nombre_empleado = Nom_empleado.Text;
                DateTime date = Fecha_proc.Value.Date;

                EnlaceCassandra.ModificarDatosFernando(nombre, nombre_empresa, nombre_empleado, productosNotaVenta, date, newGuid);
                MessageBox.Show("Datos Modificados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LimpiarFormulario();
            CargarDatos();
        }

        private void VerDatosGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("¿Desea borrar el dato seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                // cancel the closure of the form.
                newGuid = Guid.Parse(uuidAEliminar);
                MessageBox.Show("Dato " + newGuid + " Eliminado", "Aviso", MessageBoxButtons.OK);
                EnlaceCassandra.DeleteDatosFernando(newGuid);
                LimpiarFormulario();
                CargarDatos();
            }
        }

        private void VerDatosGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                Eliminar.Enabled = false;
                uuidAEliminar = "";
                VerDatosGrid.ClearSelection();
                return;
            }

            uuidAEliminar = Convert.ToString(VerDatosGrid.Rows[e.RowIndex].Cells["idVenta"].Value);
            newGuid = Guid.Parse(uuidAEliminar);

            LimpiarFormulario("Editar Nota");
            Eliminar.Enabled = true;

            if (productosNotaVenta == null)
                productosNotaVenta = new List<Tuple<int, decimal, string>>();

            EnlaceCassandra.ObtenerDatosTextFernando(newGuid, Nom_client, Nom_emp, Nom_empleado, Fecha_proc, Productos, ref productosNotaVenta);
            Productos.ClearSelection();
        }

        private void Notas_Venta_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            List<Nota_Venta> notas = EnlaceCassandra.ObtenerNotasVentasFernando();
            VerDatosGrid.DataSource = notas;
            VerDatosGrid.ClearSelection();
        }

        private void LimpiarFormulario(string textBotonAgregar = "Agregar Nota")
        {
            Nom_client.Text = "";
            Nom_emp.Text = "";
            Nom_proc.Text = "";
            Cantidad.Text = "";
            Precio.Text = "";
            Nom_empleado.Text = "";
            Fecha_proc.Value = DateTime.Now;
            Agregar.Text = textBotonAgregar;
            AgregarProducto.Enabled = true;
            Eliminar.Enabled = false;
            RetirarProducto.Enabled = false;
            VerDatosGrid.ClearSelection();
            Productos.DataSource = null;
            productosNotaVenta = null;
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario("Agregar Nota");
        }

        private void Productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                RetirarProducto.Enabled = false;

                Nom_proc.Text = "";
                Cantidad.Text = "";
                Precio.Text = "";

                Productos.ClearSelection();
                return;
            }

            Nom_proc.Text = "";
            Cantidad.Text = "";
            Precio.Text = "";

            Nom_proc.Text = Convert.ToString(Productos.Rows[e.RowIndex].Cells[2].Value);
            Cantidad.Text = Convert.ToString(Productos.Rows[e.RowIndex].Cells[0].Value);
            Precio.Text = Convert.ToString(Productos.Rows[e.RowIndex].Cells[1].Value);

            AgregarProducto.Enabled = false;
            RetirarProducto.Enabled = true;
        }

        private void RetirarProducto_Click(object sender, EventArgs e)
        {
            if (Nom_proc.Text == "")
            {
               MessageBox.Show("Seleccione el producto a retirar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (Tuple<int, decimal, string> producto in productosNotaVenta)
            {
                if (producto.Item3 == Nom_proc.Text)
                {
                    productosNotaVenta.Remove(producto);
                    break;
                }
            }

            Productos.DataSource = null;
            Productos.DataSource = productosNotaVenta;

            Nom_proc.Text = "";
            Cantidad.Text = "";
            Precio.Text = "";

            Productos.ClearSelection();

            AgregarProducto.Enabled = true;
            RetirarProducto.Enabled = false;
        }

        private void AgregarProducto_Click(object sender, EventArgs e)
        {
            if (Nom_proc.Text == "" || Cantidad.Text == "" || Precio.Text == "")
            {
                MessageBox.Show("Campos faltantes", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tuple<int, decimal, string> producto;
            producto = new Tuple<int, decimal, string>(Convert.ToInt32(Cantidad.Text), Convert.ToDecimal(Precio.Text), Nom_proc.Text);

            if (productosNotaVenta == null)
            {
                productosNotaVenta = new List<Tuple<int, decimal, string>>();
            }

            productosNotaVenta.Add(producto);

            Productos.DataSource = null;
            Productos.DataSource = productosNotaVenta;

            Nom_proc.Text = "";
            Cantidad.Text = "";
            Precio.Text = "";

            Productos.ClearSelection();

            AgregarProducto.Enabled = true;
            RetirarProducto.Enabled = false;
        }

        private void Precio_n(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Cantidad_n(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
