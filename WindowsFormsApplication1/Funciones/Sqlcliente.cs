/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;


namespace WindowsFormsApplication1.Funciones
{
    public class Sqlcliente
    {
        protected static SqlConnection ConexionSQL()
        {
            SqlConnection  coneccion = new SqlConnection("server=.\\SQL_UAI ; database=prueba ; integrated security = true");
            return coneccion;
        }
        public  static DataTable Mostrar(string Proceso)
        {
            DataTable consulta = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection();
            con = ConexionSQL();
            cmd.Connection = con;
            cmd.CommandText = Proceso;

            try
                {
                    if (con.State == ConnectionState.Open )
                    {
                        con.Close();
                    }
                    con.Open();
                    consulta.Load(cmd.ExecuteReader());
                }
                catch (Exception ex)
                {
                    throw ex;

                }
                finally
                {
                    con.Close();
                }
            
            return consulta;

        }


        public static int Enviar(string Proceso)
        {

            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection();
            con = ConexionSQL();
            cmd.Connection = con;
            cmd.CommandText = Proceso;

            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                int resp = cmd.ExecuteNonQuery();
                return resp;
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                con.Close();
            }
        }

    }
}*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;



namespace WindowsFormsApplication1.Funciones
{
    public class Sqlcliente
    {
        protected static SqlConnection ConexionSQL()
        {
            //SqlConnection coneccion = new SqlConnection(@"Data Source=(local);Initial Catalog=prueba; user id=octilc; password=1214lcm");
            // SqlConnection coneccion = new SqlConnection("server=FEDERICO-PC\\SQLEXPRESS ; database=prueba ; integrated security = true");
            SqlConnection coneccion = new SqlConnection("server=.\\SQL_UAI ; database=prueba ; integrated security = true");
            return coneccion;

        }
        public static DataTable Mostrar(string Proceso)
        {
            DataTable consulta = new DataTable();
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection();
            con = ConexionSQL();
            cmd.Connection = con;
            cmd.CommandText = Proceso;

            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                consulta.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                con.Close();
            }

            return consulta;

        }


        public static int Enviar(string Proceso)
        {

            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection();
            con = ConexionSQL();
            cmd.Connection = con;
            cmd.CommandText = Proceso;

            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();
                int resp = cmd.ExecuteNonQuery();
                return resp;
            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                con.Close();
            }
        }


    }
    
}
