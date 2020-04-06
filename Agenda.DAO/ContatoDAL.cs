using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.DAL;
using System.Data.SqlClient;
using System.Data;
using Agenda.DTO;

namespace Agenda.DAL
{
    public static class ContatoDAL
    {
        public static int InserirContatoDAL(Contato objContato)
        {
            SqlConnection Conexao = new SqlConnection();
            Conexao.ConnectionString = Agenda.DAO.Properties.Settings.Default.ConexaoBD;

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = Conexao;
            Comando.CommandText = "INSERT TB_CONTATO (NM_CONTATO, NR_TEL_CONTATO, NM_EMAIL) VALUES (@Nome, @Telefone, @Email)";
            Comando.Parameters.Add("Nome", SqlDbType.VarChar).Value = objContato.Nome;
            Comando.Parameters.Add("Telefone", SqlDbType.VarChar).Value = objContato.Telefone;
            Comando.Parameters.Add("Email", SqlDbType.VarChar).Value = objContato.Email;

            Conexao.Open();
            return Comando.ExecuteNonQuery();
        }
    }
}
