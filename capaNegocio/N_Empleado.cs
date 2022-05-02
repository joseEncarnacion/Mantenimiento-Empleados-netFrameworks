using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//importamos las clases de nuestas capas
using capaDatos;
using capaEntidad;

//importamos esta dependencia para poder usar el datatable 
using System.Data;

namespace capaNegocio
{
    public class N_Empleado
    {
        //creamos una instancia del objeto D_Empleado 
        D_Empleados objdatos = new D_Empleados();

        public DataTable N_listado()
        {
            return objdatos.D_listado();
        }

        public void N_Insertar(E_Empleado emp)
        {
            objdatos.D_Insertar(emp);
        }

        public void N_Eliminar(int code)
        {
            objdatos.D_Eliminar(code);
        }

        public void N_Editar(E_Empleado emp)
        {
            objdatos.D_Editar(emp);
        }

    }
}
