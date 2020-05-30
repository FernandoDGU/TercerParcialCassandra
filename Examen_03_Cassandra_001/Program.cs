using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Código realizado por Fernando De Luna Guardiola 1726916
/// </summary>

namespace Examen_03_Cassandra_001
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // conectamos con cassandra
            new EnlaceCassandra();

            Application.Run(new Notas_Venta());
        }
    }
}
