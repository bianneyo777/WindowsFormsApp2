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
    public partial class secciones : Form
    {
        public secciones()
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
            string consulta = "select *from secciones";
            SqlCommand cmd = new SqlCommand(consulta, conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.conectar();
            string insertar = "Insert into secciones(nombrese)" +
                 "Values(@nombrese)";
            SqlCommand cmd1 = new SqlCommand(insertar, conexion.conectar());

            cmd1.Parameters.AddWithValue("@nombrese", textBox1.Text);


            cmd1.ExecuteNonQuery();


            MessageBox.Show("los datos fueron anadidos");
            dataGridView1.DataSource = llenar_grid();
        }
    }
}
