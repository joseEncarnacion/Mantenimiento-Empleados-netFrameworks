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
    public partial class P_Mantenimiento : Form
    {
        public P_Mantenimiento()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void P_Mantenimiento_Load(object sender, EventArgs e)
        {
            ListarEmpleado();
        }

        N_Empleado objNegocio = new N_Empleado();
        E_Empleado objEntidad = new E_Empleado();
        void ListarEmpleado()
        {
            DataTable dt = objNegocio.N_listado();
            stageMantenimiento.DataSource = dt;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            Insertar();
            ListarEmpleado();
            limpiar();


        }

        void Insertar()
        {
            objEntidad.nom = nombreBox.Text;
            objEntidad.edad = Convert.ToInt32(edadBox.Text);
            objEntidad.sexo = sexoBox.Text;
            objEntidad.sueldo = Convert.ToDouble(sueldoBox.Text);

            objNegocio.N_Insertar(objEntidad);

            MessageBox.Show("Registro insertado con exito");
        }


        void limpiar()
        {
            codeBox.Text = "";
            nombreBox.Text = "";
            edadBox.Text = "";
            sexoBox.Text = "";
            sueldoBox.Text = "";
        }

        private void stageMantenimiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (stageMantenimiento.Rows[e.RowIndex].Cells["Eliminar"].Selected)
            {
                int eliminar = Convert.ToInt32(stageMantenimiento.Rows[e.RowIndex].Cells["codeEmp"].Value.ToString());
                objNegocio.N_Eliminar(eliminar);
                ListarEmpleado();
            }
            else if (stageMantenimiento.Rows[e.RowIndex].Cells["Editar"].Selected)
            {
                codeBox.Text = stageMantenimiento.Rows[e.RowIndex].Cells["codeEmp"].Value.ToString();
                nombreBox.Text = stageMantenimiento.Rows[e.RowIndex].Cells["nomEmp"].Value.ToString();
                edadBox.Text = stageMantenimiento.Rows[e.RowIndex].Cells["edadEmp"].Value.ToString();
                sexoBox.Text = stageMantenimiento.Rows[e.RowIndex].Cells["sexoEmp"].Value.ToString();
                sueldoBox.Text = stageMantenimiento.Rows[e.RowIndex].Cells["sueldoEmp"].Value.ToString();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Editare();
            limpiar();
            ListarEmpleado();
        }

        void Editare()
        {
            objEntidad.cod = Convert.ToInt32(codeBox.Text);
            objEntidad.nom = nombreBox.Text;
            objEntidad.edad = Convert.ToInt32(edadBox.Text);
            objEntidad.sexo = sexoBox.Text;
            objEntidad.sueldo = Convert.ToDouble(sueldoBox.Text);

            objNegocio.N_Editar(objEntidad);
            ListarEmpleado();

            MessageBox.Show("Registro Editado con exito");
        }
    }
}
