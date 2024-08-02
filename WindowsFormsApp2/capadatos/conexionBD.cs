using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.capadatos
{
    internal class conexionBD
    {
        static private string cadenaconexion = "server=MSI\\SQLEXPRESS;database= escuela24; integrated security= true";
        private SqlConnection conexion1 = new SqlConnection(cadenaconexion);

        public SqlConnection abrirconexion()
        {
            if (conexion1.State == ConnectionState.Closed)
                conexion1.Open();
            return conexion1;
        }

        public SqlConnection cerrarconexion()
        {
            if (conexion1.State == ConnectionState.Open)
                conexion1.Close();
            return conexion1;
        }

    }
}
