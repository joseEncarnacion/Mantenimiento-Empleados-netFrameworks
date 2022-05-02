using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using capaEntidad;
using capaNegocio;

namespace capaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListarEmpleado();
        }

        N_Empleado objNegocio = new N_Empleado();
        E_Empleado objEntidad = new E_Empleado();
    void ListarEmpleado()
    {
            DataTable dt = objNegocio.N_listado();
            dataGridView1.DataSource = dt;
    }
    }

}
