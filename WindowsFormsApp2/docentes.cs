using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class docentes : Form
    {
        public docentes()
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
            string consulta = "select *from maestros";
            SqlCommand cmd = new SqlCommand(consulta, conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.conectar();
            string insertar = "Inser into Maestros(Nombrema,Nombrema2,Apellidoma,Apellidoma2,Direccionma,Cedularma, Celular_maestro,Fechaingresoma,FechaSalidaMa)"+
                 "Values(@Nombrema,@Nombrema2,@Apellidoma,@Apellidoma2,@Direccionma,@Cedulama,@Celular_maestro,@Fechaingresoma,@FechaSalidaMa)";
            SqlCommand cmd1 = new SqlCommand(insertar, conexion.conectar());

            cmd1.Parameters.AddWithValue("@nombrema", PNombretext.Text);
            cmd1.Parameters.AddWithValue("@nombrema2", SNombretext.Text);
            cmd1.Parameters.AddWithValue("@apellidoma", PApellidotext.Text;
            cmd1.Parameters.AddWithValue("@apellidoma2", SApellidotext.Text);
            cmd1.Parameters.AddWithValue("@Fechaingresoma", fechain.Value);
            cmd1.Parameters.AddWithValue("@FechaSalidaMa", fechasali.Value);
            cmd1.Parameters.AddWithValue("@Celulama", Cedulatext.Text); 
            cmd1.Parameters.AddWithValue("@celular_maestro",Celulartext.Text);
            cmd1.Parameters.AddWithValue("@direccionma", Direcciontext.Text);



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void docentes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'escuela24DataSet1.Maestros' Puede moverla o quitarla según sea necesario.
            this.maestrosTableAdapter.Fill(this.escuela24DataSet1.Maestros);

        }
    }
}
