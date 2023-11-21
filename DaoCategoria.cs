using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_crud_2
{
    internal class DaoCategoria
    {
        public bool salvar(Categoria categoria)
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*criado conexão com database*/
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bd_agenda;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                con.Open();
                /*monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "insert into tb_Produtos([id],[nome],[preco],[descricao])values(@id,@nome,@preco,@descricao)";

                /*envia os dados a serem gravados*/
                cn.Parameters.Add("id", SqlDbType.VarChar).Value = categoria.Id;
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = categoria.Nome;
                cn.Parameters.Add("preco", SqlDbType.VarChar).Value = categoria.Preco;
                cn.Parameters.Add("descricao", SqlDbType.VarChar).Value = categoria.Descricao;

                /*abrir a conexaõ*/

                cn.Connection = con;
                /*executa a conexão*/
                return cn.ExecuteNonQuery() > 0;
            }
        }

        public void consultar()
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*criado conexão com database*/
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bd_agenda;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                con.Open();
                /*monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "select * from tb_Produtos";

                /*abrir a conexaõ*/
                cn.Connection = con;

                /*executa a conexão*/
                SqlDataReader dr;
                dr = cn.ExecuteReader();
                while (dr.Read())
                {
                    Categoria ct = new Categoria();
                    ct.Id = Convert.ToInt32(dr["id"]);
                    ct.Nome = Convert.ToString(dr["nome"]);
                    ct.Preco = Convert.ToString(dr["preco"]);
                    ct.Descricao = Convert.ToString(dr["descricao"]);
                    Console.WriteLine(ct.ToString());
                }
            }
        }
    }
}
