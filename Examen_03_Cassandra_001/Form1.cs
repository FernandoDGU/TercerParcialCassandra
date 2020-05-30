using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_03_Cassandra_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void N_Ventas_Click(object sender, EventArgs e)
        {
            Form NotasV = new Notas_Venta();
            NotasV.ShowDialog();
        }

        private void N_Compras_Click(object sender, EventArgs e)
        {
            
            //Form NotasC = new testForms.FormDarien();
            //NotasC.ShowDialog(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
