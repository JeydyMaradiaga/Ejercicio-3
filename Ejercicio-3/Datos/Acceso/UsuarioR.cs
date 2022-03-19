using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Acceso
{
    public class UsuarioR
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=registro; Uid=root; Pwd=#_xd2002_18#;";
        MySqlConnection conn;
        MySqlCommand cmd;

        public Usuario Login(string nomUsuario, string clave)
        {
            Usuario user = null;
            try
            {
                string sql = "SELECT * FROM Usuario WHERE NomUsuario = @NomUsuario AND Clave = @Clave;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@NomUsuario", nomUsuario);
                cmd.Parameters.AddWithValue("@Clave", clave);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    user = new Usuario();
                    user.NomUsuario = reader[0].ToString();
                    user.Nombre = reader[1].ToString();
                    user.Clave = reader[2].ToString();
                   
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {

            }
            return user;
        }

        public DataTable ListarUsuarios()
        {
            DataTable listaUsuariosDT = new DataTable();

            try
            {
                string sql = "SELECT * FROM usuario;";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                listaUsuariosDT.Load(reader);
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return listaUsuariosDT;
        }

    }
}