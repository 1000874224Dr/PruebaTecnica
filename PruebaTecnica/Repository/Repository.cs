using PruebaTecnica.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaTecnica.Pages;
namespace PruebaTecnica.Repository
{
    public class Repository
    {
        public static string cadenaConexion = "Data Source=DESKTOP-RC4H24A;Initial Catalog=PruebaTecnica; Integrated Security=true";

        SqlConnection _connection = new SqlConnection(cadenaConexion);
        public string AgregarElemento(List<Elemento> elementos)
        {
            try
            {
                _connection.Open();

                SqlCommand command;
                SqlDataReader reader;
                string sql = "";
                foreach (var item in elementos)
                {

                sql = ($"insert into PruebaTecnica (Nombre,Calorias,Peso) values({item.Nombre},'{item.Calorias}','{item.Peso}')");
                command = new SqlCommand(sql, _connection);
                reader = command.ExecuteReader();
                 command.Dispose();
                }
                
                return ("Se agrego el elemento exitosamente");

            }
            catch (Exception e)
            {
                return e.Message;
            }
            finally
            {
                _connection.Close();
            }

        }

    }
}
