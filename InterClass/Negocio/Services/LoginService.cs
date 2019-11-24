using System;
using MySql.Data.MySqlClient;
using Negocio.DBSessao;
using Negocio.Entity;

namespace Negocio.Services
{
    public class LoginService
    {
        conexao con = new conexao();

        public static string mail;

        public void TestarUsuario(Login user)
        {
            MySqlCommand cmd = new MySqlCommand("select * from tb_login where usuario = @usuario and senha = @Senha ", con.MyConectarBD());

            cmd.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = user.Usuario;
            cmd.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = user.Senha;
            cmd.Parameters.Add("@tipo", MySqlDbType.VarChar).Value = user.Tipo;
            MySqlDataReader leitor;

            leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {
                while (leitor.Read())
                {

                    {
                        user.Usuario = Convert.ToString(leitor["usuario"]);
                        user.Senha = Convert.ToString(leitor["Senha"]);
                        user.Tipo = Convert.ToString(leitor["tipousuario"]);
                    }
                }

            }

            else
            {
                user.Usuario = null;
                user.Senha = null;
                user.Tipo = null;
            }

            con.MyDesconectarBD();
        }
     

    }
}
