using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using Cassandra.Mapping.Attributes;

/// 
/// Código realizado por Fernando De Luna Guardiola 1726916
/// 

namespace Examen_03_Cassandra_001
{
    public class Nota_Venta
    {
        [PartitionKey] // lo puse porque me salia un error al actualizar con mapper
        public Guid idVenta { get; set; }
        public string Nom_cliente { get; set; }
        public string Nom_Empresa { get; set; }
        public string Nombre_Empleado { get; set; }
        public List<Tuple<int, decimal, string>> Producto { get; set; }
        public DateTime Fecha_Compra { get; set; }
        public decimal Total_final { get; set; }

        

        //Nom_cliente, Nom_Empresa, Producto, Fecha_Compra, Total_final
    }
}
