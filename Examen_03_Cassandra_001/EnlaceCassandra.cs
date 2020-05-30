using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using System.Configuration;
using System.Windows.Forms;
using Cassandra.Mapping;

/// 
/// Código realizado por Fernando De Luna Guardiola 1726916
/// 

namespace Examen_03_Cassandra_001
{
    class EnlaceCassandra
    {
        static private string _dbServer { set; get; }

        static private string _dbKeySpace { set; get; }

        static private string _dbKeySpace2 { set; get; }

        static private Cluster _cluster;

        static private ISession _session { get; set; }

        static private ISession _session2 { get; set; }

        static private IMapper _mapper { get; set; }

        public EnlaceCassandra()
        {
            if (_session == null && _session2 == null)
            {
                _dbServer = ConfigurationManager.AppSettings["Cluster"].ToString();
                _dbKeySpace = ConfigurationManager.AppSettings["KeySpace"].ToString();
                //_dbKeySpace2 = ConfigurationManager.AppSettings["CSharp_Project"].ToString();

                 _cluster = Cluster.Builder()
                    .AddContactPoint(_dbServer)
                    .Build();

                _session = _cluster.Connect(_dbKeySpace);
                _mapper = new Mapper(_session);
                //_session2 = _cluster.Connect(_dbKeySpace2);
            }
            
        }

        public static void InsertarDatosFernando(string Nom_cliente, string Nom_Empresa, string Nom_Empleado, DateTime date,
            List<Tuple<int, decimal, string>> productos)
        {
            try
            {
                Nota_Venta notaNueva = new Nota_Venta();

                notaNueva.idVenta = Guid.NewGuid();
                notaNueva.Nombre_Empleado = Nom_Empleado;
                notaNueva.Nom_cliente = Nom_cliente;
                notaNueva.Nom_Empresa = Nom_Empresa;
                notaNueva.Producto = productos;
                notaNueva.Fecha_Compra = date;
                notaNueva.Total_final = 0;

                foreach (Tuple<int, decimal, string> producto in productos)
                {
                    notaNueva.Total_final += producto.Item2 * producto.Item1;
                }

                _mapper.Insert(notaNueva);


                //string query = "";

                //query = string.Format("INSERT INTO Nota_Venta (idVenta, Nom_cliente, Nom_Empresa, Producto, Fecha_Compra, Total_final) " +
                //    "VALUES ({0}, '{1}', '{2}', ({3}, {4}, '{5}'), '{6}', {7})", 
                //    Guid.NewGuid(), Nom_cliente, Nom_Empresa, Producto, date.ToString("yyyy-MM-dd"), 0);

                //_session.Execute(query);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

        public static void ModificarDatosFernando(string Nom_cliente, string Nom_Empresa, string Nom_Empleado, List<Tuple<int, decimal, string>> productos,
            DateTime date, Guid id_ventas)
        {
            try
            {

                Nota_Venta notaNueva = _mapper.FirstOrDefault<Nota_Venta>("WHERE idVenta = ?", id_ventas);

                notaNueva.Nombre_Empleado = Nom_Empleado;
                notaNueva.Nom_cliente = Nom_cliente;
                notaNueva.Nom_Empresa = Nom_Empresa;
                notaNueva.Producto = productos;
                notaNueva.Fecha_Compra = date;
                notaNueva.Total_final = 0;

                foreach (Tuple<int, decimal, string> producto in productos)
                {
                    notaNueva.Total_final += producto.Item2 * producto.Item1;
                }

                _mapper.Update<Nota_Venta>(notaNueva);

                //string query = "";

                //query = string.Format("UPDATE Nota_Venta SET Nom_cliente = '{0}', Nom_Empresa = '{1}', Producto = ({2},{3},'{4}')," +
                //    " Fecha_Compra = '{5}', Total_final = {6} WHERE idVenta = {7}",
                //    Nom_cliente, Nom_Empresa, 0, 0, Producto, date.ToString("yyyy-MM-dd"), 0, id_ventas);

                //_session.Execute(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }

        }

        public static void DeleteDatosFernando(Guid id_ventas)
        {
            try
            {
                string query = "";

                query = string.Format("DELETE FROM Nota_Venta WHERE idVenta = {0}", id_ventas);
                _session.Execute(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally{

            }
        }

        public static void ObtenerDatosTextFernando( Guid Id_ventas, TextBox Name_C, TextBox Name_E,
            TextBox Nom_empleado, DateTimePicker fecha, DataGridView productos, ref List<Tuple<int, decimal, string>> listaProducto)
        {
            try
            {
                Nota_Venta nota = _mapper.FirstOrDefault<Nota_Venta>("WHERE idVenta = ?", Id_ventas);

                Name_C.Text = Convert.ToString(nota.Nom_cliente);
                Name_E.Text = Convert.ToString(nota.Nom_Empresa);
                Nom_empleado.Text = Convert.ToString(nota.Nombre_Empleado);
                fecha.Value = nota.Fecha_Compra;
                productos.DataSource = nota.Producto;
                listaProducto = nota.Producto;

                //string query = "";
                //query = string.Format("SELECT * from Nota_Venta WHERE idVenta = {0}", Id_ventas);
                //RowSet rs = _session.Execute(query);

                //foreach (Row row in rs)
                //{
                //    var id = row.GetValue<Guid>("idventa");
                //    var nombre = row.GetValue<string>("nom_cliente");
                //    var nombre_empresa = row.GetValue<string>("nom_empresa");
                //    var fecha_compra = row.GetValue<DateTime>("fecha_compra");
                //    //var Cantidad = row.GetValue<Tuple<int>>("Producto");
                //    //var Precio = row.GetValue<Tuple<decimal>>("Producto");
                //    //var Nombre_proc = row.GetValue<Tuple<string>>("Producto");
                //    var producto = row.GetValue<Tuple<int, decimal, string>>("producto");

                //    Name_C.Text = Convert.ToString(nombre);
                //    Name_E.Text = Convert.ToString(nombre_empresa);
                //    Cant_proc.Text = Convert.ToString(producto.Item1);
                //    Prec_proc.Text = Convert.ToString(producto.Item2);
                //    Nom_proc.Text = Convert.ToString(producto.Item3);
                //    fecha.Value = fecha_compra;
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static List<Nota_Venta> ObtenerNotasVentasFernando()
        {
            // var statement = new SimpleStatement("SELECT * from Nota_Venta");
            // List<Notas_Venta> notas = new List<Notas_Venta>();

            //RowSet rs = _session.Execute(statement);

            //foreach (Row row in rs)
            //{
            //    Notaventa notaventa = new Notaventa();

            //    notaventa.id_ventas = row.GetValue<Guid>("idventa");
            //    notaventa.producto = row.GetValue<Tuple<int, decimal, string>>("producto");
            //    notaventa.Nombre_cliente = row.GetValue<string>("nom_cliente");
            //    notaventa.Nombre_empresa = row.GetValue<string>("nom_empresa");
            //    notaventa.Nombre_empleado = row.GetValue<string>("nombre_empleado");
            //    notaventa.Fecha_compra = row.GetValue<DateTime>("fecha_compra");
            //    notaventa.Total_Final = row.GetValue<decimal>("total_final");
            //    notas.Add(notaventa);
            //}

            return _mapper.Fetch<Nota_Venta>().ToList();
        }

    }


}
