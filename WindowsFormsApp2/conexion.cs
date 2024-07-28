using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class conexion
    {


        public static SqlConnection conectar()
        {
            SqlConnection cn = new SqlConnection("server=MSI\\SQLEXPRESS;database= escuela24; integrated security= true");
            cn.Open();
            return cn;

        }

    }
}
