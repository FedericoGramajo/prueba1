using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApplication1.Objetos;
using Newtonsoft.Json;




namespace WindowsFormsApplication1.Funciones
{
    public static class FuncionesUsuarios
    {


        public static List<Usuario> Mostrar()
        {
            List<Usuario> lista = new List<Usuario>();
            try
            {
                DataTable tabla = Sqlcliente.Mostrar("select * from usuario order by nombre ");
                if (tabla.Rows.Count != 0)
                {
                    DataRow filas = tabla.Select().FirstOrDefault();
                    string objserializado = JsonConvert.SerializeObject(filas.Table);
                    //si es lista el objeto para deserializarlo va con los corchetes [] , si es solo un objeto va sin ellos
                    lista = JsonConvert.DeserializeObject<List<Usuario>>(objserializado);
                }
                return lista;
            }
            catch (Exception ex)
            {
                return lista;
                throw ex;

            }
        }











        public static Boolean Agregar(Usuario usuario)
        {
            try
            {
                int FilasAfectadas = Sqlcliente.Enviar("insert into usuario (nombre, direccion, dni, telefono, usuarionom, contraseña) " +
                                                      $"values ('{usuario.Nombre}','{usuario.Direccion}','{usuario.Dni}','{usuario.Telefono}', '{usuario.UsuarioNom}', '{usuario.Contraseña}') ");
                if (FilasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return true;
                throw ex;
            }
           
        }

        public static Boolean Modificar(Usuario usuario)
        {
            try
            {

                int FilasAfectadas = Sqlcliente.Enviar($"update usuario set nombre= '{usuario.Nombre}' ,direccion = '{usuario.Direccion}', dni = '{usuario.Dni}' ,telefono = '{usuario.Telefono}', usuarionom='{usuario.UsuarioNom}', contraseña='{usuario.Contraseña}' where idusuario = '{usuario.IdUsuario}'  ");
                if (FilasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public static Boolean Eliminar(Usuario usuario)
        {
            try
            {

                int FilasAfectadas = Sqlcliente.Enviar($"delete from usuario where idusuario = '{usuario.IdUsuario}' ");
                if (FilasAfectadas > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
    }
}
