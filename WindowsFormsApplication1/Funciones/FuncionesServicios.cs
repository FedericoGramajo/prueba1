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
    public static class FuncionesServicios
    {
       

            public static List<Servicio> Mostrar()
            {
                List<Servicio> lista = new List<Servicio>();
                try
                {
                    DataTable tabla = Sqlcliente.Mostrar("select * from servicio order by nomcorto ");
                    if (tabla.Rows.Count != 0)
                    {
                        DataRow filas = tabla.Select().FirstOrDefault();
                        string objserializado = JsonConvert.SerializeObject(filas.Table);
                        //si es lista el objeto para deserializarlo va con los corchetes [] , si es solo un objeto va sin ellos
                        lista = JsonConvert.DeserializeObject<List<Servicio>>(objserializado);
                    }
                    return lista;
                }
                catch (Exception ex)
                {
                    return lista;
                    throw ex;

                }
            }

            public static Boolean Agregar(Servicio servicio)
            {
                try
                {

                    int FilasAfectadas = Sqlcliente.Enviar("insert into servicio (nomcorto, descripcion, unmedida, montoxunmedida, fechaDato) " +
                                                           $"values ('{servicio.nomcorto}','{servicio.descripcion}','{servicio.unmedida}','{servicio.montoxunmedida}', '{servicio.fechaDato}') ");

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

            public static Boolean Modificar(Servicio servicio )
            {
                try
                {
                                                             
                    int FilasAfectadas = Sqlcliente.Enviar($"update servicio set nomcorto= '{servicio.nomcorto}' ,descripcion = '{servicio.descripcion}' ,unmedida = '{servicio.unmedida}' ,montoxunmedida = '{servicio.montoxunmedida}', fechaDato='{servicio.fechaDato}' where idservicio = '{servicio.idservicio}' ");
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


            public static Boolean Eliminar(int Idservicio)
            {
                try
                {

                    int FilasAfectadas = Sqlcliente.Enviar($"delete from servicio where idservicio = '{Idservicio}' ");
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

