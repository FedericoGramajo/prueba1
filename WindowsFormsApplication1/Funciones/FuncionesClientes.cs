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
   public static class FuncionesClientes
    {

        
        public static List<Cliente> Mostrar()
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                DataTable tabla = Sqlcliente.Mostrar("select * from cliente order by nombre ");
               if (tabla.Rows.Count != 0 )
                {
                   DataRow filas = tabla.Select().FirstOrDefault();
                    string objserializado = JsonConvert.SerializeObject(filas.Table);
                    //si es lista el objeto para deserializarlo va con los corchetes [] , si es solo un objeto va sin ellos
                    lista = JsonConvert.DeserializeObject<List<Cliente>>(objserializado);
                }
               return lista;
            }
            catch (Exception ex)
            {
                return lista;
                throw ex;
              
            }
       }

        public static Boolean Agregar(Cliente cliente)
        {
            try
            {
               
                int FilasAfectadas = Sqlcliente.Enviar("insert into cliente (nombre,direccion,dni,telefono) " +
                                                       $"values ('{cliente.Nombre}','{cliente.Direccion}','{cliente.Dni}','{cliente.Telefono}') ");
                
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

        public static Boolean Modificar(Cliente cliente)
        {
            try
            {

                int FilasAfectadas = Sqlcliente.Enviar($"update cliente set nombre= '{cliente.Nombre}' ,direccion = '{cliente.Direccion}' ,dni = '{cliente.Dni}' ,telefono = '{cliente.Telefono}' where idcliente = '{cliente.Idcliente}' ");
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


        public static Boolean Eliminar(Cliente cliente )
        {
            try
            {

                int FilasAfectadas = Sqlcliente.Enviar($"delete from cliente where idcliente = '{cliente.Idcliente}' ");
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
