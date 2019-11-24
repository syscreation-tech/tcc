using MySql.Data.MySqlClient;
using Negocio.DBSessao;
using Negocio.Entity;

namespace Negocio.Services
{
    public class Cadastrar
    {
        conexao con = new conexao();
        public void Insert(Usuario usuario)
        {
            MySqlCommand cmd = new MySqlCommand("insert into USUARIO(NOME_USUARIO,LOGIN,SENHA,EMAIL values ('@Nome', '@Login', '@Senha', '@Email');",con.MyConectarBD());
            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = usuario.Nome_Usuario;
            cmd.Parameters.Add("@Login", MySqlDbType.VarChar).Value = usuario.Login;
            cmd.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = usuario.Senha;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = usuario.Email;

            cmd.ExecuteNonQuery();
            con.MyDesconectarBD();
        }
        public void InsereDadosCartao(Produto produto)
        {
            MySqlCommand cmd = new MySqlCommand("insert into InfoCartao(NumCartao,CodCardSegu,NomeProp,DataValid) values('@NumCartao', '@CodCardSegu', '@NomeProp', '@DataValid');",con.MyConectarBD());

            cmd.Parameters.Add("@NumCartao", MySqlDbType.VarChar).Value = produto.NumCartao;
            cmd.Parameters.Add("@CodCartao",MySqlDbType.Int16).Value = produto.CodCardSegu;
            cmd.Parameters.Add("@NomeProp",MySqlDbType.VarChar).Value = produto.NomeProp;
            cmd.Parameters.Add("@DataValid",MySqlDbType.VarChar).Value = produto.DataValid;

        }
     

    }
}