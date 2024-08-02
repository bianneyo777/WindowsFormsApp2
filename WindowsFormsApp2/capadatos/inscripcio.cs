using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.capadatos
{
    internal class inscripcio
    {
        private conexionBD conexion1 = new conexionBD();
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader leeefilas;



        public DataTable listargrados()
        {

            DataTable tabla = new DataTable();
            comando.Connection = conexion1.abrirconexion();
            comando.CommandText = "listargrado";
            comando.CommandType = CommandType.StoredProcedure;
            leeefilas = comando.ExecuteReader();
            tabla.Load(leeefilas);
            leeefilas.Close();
            conexion1.cerrarconexion();
            return tabla;
      
        }
        public DataTable listarturno()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion1.abrirconexion();
            comando.CommandText = "listarturno";
            comando.CommandType = CommandType.StoredProcedure;
            leeefilas = comando.ExecuteReader();
            tabla.Load(leeefilas);
            leeefilas.Close();
            conexion1.cerrarconexion();
            return tabla;
        }

        public DataTable listarseccione()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion1.abrirconexion();
            comando.CommandText = "listarseccione";
            comando.CommandType = CommandType.StoredProcedure;
            leeefilas = comando.ExecuteReader();
            tabla.Load(leeefilas);
            leeefilas.Close();
            conexion1.cerrarconexion();
            return tabla;
        }

        public DataTable listaralumno()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion1.abrirconexion();
            comando.CommandText = "listaralumno";
            comando.CommandType = CommandType.StoredProcedure;
            leeefilas = comando.ExecuteReader();
            tabla.Load(leeefilas);
            leeefilas.Close();
            conexion1.cerrarconexion();
            return tabla;
        }



    }
}
