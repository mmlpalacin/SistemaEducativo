using SistemaEducativo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Controllers
{
    public class DocentesController
    {
        List<Docente> lista = new List<Docente>();
        Conexion conexion = new Conexion();
        DataTable DT = new DataTable();
        SqlCommand comando = new SqlCommand();

        public List<Docente> DatosDocentes()
        {
            try
            {
                comando.Connection = conexion.abrir();
                comando.CommandText = "Select * from docentes WHERE date_delete IS NULL";

                using (SqlDataReader leer = comando.ExecuteReader()) // Using para asegurar el cierre
                {
                    while (leer.Read())
                    {
                        Docente addTD = new Docente
                        {
                            id = (int)leer["id"],
                            IdDocente = leer["id_docente"].ToString() ?? string.Empty,
                            NombreDocente = leer["nombre_docente"].ToString() ?? string.Empty,
                            GeneroDocente = leer["genero_docente"].ToString() ?? string.Empty,
                            DireccionDocente = leer["direccion_docente"].ToString() ?? string.Empty,
                            StatusDocentes = leer["status_docente"].ToString() ?? string.Empty,
                            ImagenesDocente = leer["foto_docente"].ToString() ?? string.Empty,
                            InsertarFecha = leer["insertar_fecha"].ToString() ?? string.Empty,
                            ActualizarFecha = leer["actualizar_fecha"].ToString() ?? string.Empty
                        };
                        lista.Add(addTD);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectarse a la base de datos: " + ex);
            }
            finally
            {
                conexion.cerrar();
            }
            return lista;
        }
    }
}
