using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Objetos;
using WindowsFormsApplication1.Funciones;
using System.Data.SqlClient;

namespace WindowsFormsApplication1.Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection coneccion = new SqlConnection("server=FEDERICO-PC\\SQLEXPRESS ; database=prueba ; integrated security = true");
        public void Logear(string usuarionom, string contraseña)
        {
            try
            {
                coneccion.Open();
                SqlCommand cmd = new SqlCommand("SELECT usuarionom from usuario where usuarionom= @nomusu  AND contraseña = @pass", coneccion);
                cmd.Parameters.AddWithValue("nomusu", usuarionom);
                cmd.Parameters.AddWithValue("pass", contraseña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("linda rey");
                }

            }
            catch (Exception ex)

            {
                throw ex;
            }
            finally
            {
                coneccion.Close();
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logear(this.textBox1.Text, this.textBox2.Text);

        }
    }
}
