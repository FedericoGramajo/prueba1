/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApplication1.Objetos;
using Newtonsoft.Json;
using System.Data.SqlClient;
using WindowsFormsApplication1.Funciones;
using System.Windows.Forms;


namespace WindowsFormsApplication1.Funciones
{
    class FuncionesLogin
    {
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


    }
}
*/