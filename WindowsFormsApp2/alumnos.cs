using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class alumnos : Form
    {
        public alumnos()
        {
            InitializeComponent();
        }
        public static SqlConnection conectar()
        {
            SqlConnection cn = new SqlConnection("server=MSI\\SQLEXPRESS;database= escuela24; integrated security= true");
            cn.Open();
            return cn;
        }
        public DataTable llenar_grid()
        {
            conexion.conectar();
            DataTable dt = new DataTable();
            string consulta = "select *from alumnos";
            SqlCommand cmd = new SqlCommand(consulta, conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void alumnos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'escuela24DataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.escuela24DataSet.Alumnos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.conectar();
            string insertar = "insert into Alumnos(codigo_estudiante,Nombreal,Nombreal2,Apellidoal,Apellidoal2, fecha_nacimientoal,FechaIngresoal,FechaSalidaal )" +
                "values(@codigo_estudiante,@Nombreal,@Nombreal2,@Apellidoal,@Apellidoal2, @fecha_nacimientoal,@FechaIngresoal,@FechaSalidaal )";
            SqlCommand cmd1 = new SqlCommand(insertar, conexion.conectar());

            cmd1.Parameters.AddWithValue("@nombreal", nombre1text.Text);
            cmd1.Parameters.AddWithValue("@nombreal2", nombre2text.Text);
            cmd1.Parameters.AddWithValue("@apellidoal", apellido1text.Text);
            cmd1.Parameters.AddWithValue("@apellidoal2", apellido2text.Text);
            cmd1.Parameters.AddWithValue("@fecha_nacimientoal", fechanaci.Value);
            cmd1.Parameters.AddWithValue("@FechaIngresoal", fechaing.Value);
            cmd1.Parameters.AddWithValue("@FechaSalidaal", fechasa.Value);
            cmd1.Parameters.AddWithValue("@codigo_estudiante", codestext.Text);



            cmd1.ExecuteNonQuery();


            MessageBox.Show("los datos fueron anadidos");
            dataGridView1.DataSource = llenar_grid();
        }
    }
}
