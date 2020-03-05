using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Objetos
{
    class FuncionesPedido
    {
       /* public static class AutoCompleClass
        {
            //metodo para cargar los datos de la bd
            public static DataTable Datos()
            {
                DataTable dt = new DataTable();

                SqlConnection con = new SqlConnection("server=.\\SQL_UAI ; database=prueba ; integrated security = true");

                string consulta = "SELECT * from cliente"; //consulta a la tabla paises
                SqlCommand comando = new SqlCommand(consulta, con);

                SqlDataAdapter adap = new SqlDataAdapter(comando);

                adap.Fill(dt);
                return dt;
            }

            //metodo para cargar la coleccion de datos para el autocomplete
            public static AutoCompleteStringCollection Autocomplete()
            {
                DataTable dt = Datos();

                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                AutoCompleteStringCollection coleccion1 = new AutoCompleteStringCollection();

                //recorrer y cargar los items para el autocompletado
                foreach (DataRow row in dt.Rows)
                {
                    coleccion.Add(Convert.ToString(row["idcliente"]));
                    coleccion1.Add(Convert.ToString(row["nombre"]));
                }

                return coleccion;
               
            }
        }*/
    }
}
