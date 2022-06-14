using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net.Sockets;
using Conexion_Hotel.Properties;

namespace Conexion_Hotel
{
    public class TablaAimeliDAO
    {
        //Función para filtrar id/ query con parametros
        public static TablaAimeli filtrarID(int id) 
        {
            TablaAimeli NewTab = new TablaAimeli();
            string cadena = Resources.Conexion_Hotel;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT id, Nombre, Direccion, Producto, Total FROM AIMELI WHERE id = @idbuscado;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idbuscado", id);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NewTab.Id = Convert.ToInt32(reader["id"].ToString());
                        NewTab.Nombre = reader["Nombre"].ToString();
                        NewTab.Direccion = reader["Direccion"].ToString();
                        NewTab.Producto = reader["Producto"].ToString();
                       // NewTab.Total = Convert.ToDouble(reader["Total"].ToString());
                    }
                }

                connection.Close();
            }

            return NewTab; 
        }

        //Query sin parametros
        public static List<TablaAimeli> ObtenerAtributos()
        {
            List<TablaAimeli> NuevaLista = new List<TablaAimeli>();
            string cadena = Resources.Conexion_Hotel;

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT id, Nombre, Direccion, Producto FROM AIMELI";
                SqlCommand command = new SqlCommand(query, connection); 
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TablaAimeli Newtab = new TablaAimeli();
                        Newtab.Id = Convert.ToInt32(reader["id"].ToString());
                        Newtab.Nombre = reader["Nombre"].ToString();
                        Newtab.Direccion = reader["Direccion"].ToString();
                        Newtab.Producto = reader["Producto"].ToString();
                       // Newtab.Total = Convert.ToDouble(reader["Total"].ToString()); 
                        
                        NuevaLista.Add(Newtab);
                    }
                }
                connection.Close();
            }

            return NuevaLista; 
        }
        
       public static TablaAimeli filtrarNombre (string nombre)
        {
            TablaAimeli Newtab = new TablaAimeli();
            string cadena = Resources.Conexion_Hotel;

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT id, Nombre, Direccion, Producto" + " FROM AIMELI WHERE Nombre = @Nombrebuscado; ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombrebuscado", nombre); 
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Newtab.Id = Convert.ToInt32(reader["id"].ToString());
                        Newtab.Nombre = reader["Nombre"].ToString();
                        Newtab.Direccion = reader["Direccion"].ToString();
                        Newtab.Producto = reader["Producto"].ToString();
                        //Newtab.Total = Convert.ToDouble(reader["Total"].ToString()); 
                    }
                }
                connection.Close();
            }

            return Newtab;
        }

        public static bool CrearNuevoAtributo(int id, string Nombre, string Direccion, string Producto)
        {
            bool resultado = true;
            try
            {
                string cadena = Resources.Conexion_Hotel;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "INSERT INTO AIMELI (id, Nombre, Direccion, Producto)" + " VALUES (@id, @Nombre, @Direccion, @Producto);";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@Nombre", Nombre); 
                    command.Parameters.AddWithValue("@Direccion", Direccion); 
                    command.Parameters.AddWithValue("@Producto", Producto);
                    //command.Parameters.AddWithValue("@Total", Total);
                    
                    connection.Open();
                    command.ExecuteNonQuery(); 
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                resultado = false; 
            }
            return resultado; 
        }
         
    }
}
