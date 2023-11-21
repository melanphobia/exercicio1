using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_crud
{
    public class DaoProduto
    {
        public bool salvar(Produto produto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*criado conexão com database*/
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=vendas;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                con.Open();
                /*monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "insert into tb_contatos([id],[descricao],[preco])values(@id,@descricao,@id)";

                /*envia os dados a serem gravados*/
                cn.Parameters.Add("id", SqlDbType.VarChar).Value = produto.Id;
                cn.Parameters.Add("descricao", SqlDbType.VarChar).Value = produto.Descricao;
                cn.Parameters.Add("id", SqlDbType.VarChar).Value = produto.Preco;

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
                    Produto ct = new Produto();
                    ct.Id = Convert.ToInt32(dr["id"]);
                    ct.Descricao = Convert.ToString(dr["descricao"]);
                    ct.Preco = Convert.ToString(dr["preco"]);
                    Console.WriteLine(ct.ToString());
                }
            }
        }
    }
}