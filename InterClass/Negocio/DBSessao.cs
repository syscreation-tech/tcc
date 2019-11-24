using MySql.Data.MySqlClient;
using System;

namespace Negocio.DBSessao
{
    public class conexao
    {
        MySqlConnection cn = new MySqlConnection("Server=db4free.net;DataBase=syscreationdb;User=syscreationuser;pwd=syscreationpwd");
        public static string msg;

        public MySqlConnection MyConectarBD()
        {

            try
            {
                cn.Open();
            }

            catch (Exception erro)
            {
                msg = "Ocorreu um erro ao se conectar" + erro.Message;
            }
            return cn;
        }

        public MySqlConnection MyDesconectarBD()
        {

            try
            {
                cn.Close();
            }

            catch (Exception erro)
            {
                msg = "Ocorreu um erro ao se conectar" + erro.Message;
            }
            return cn;
        }

    }
}
