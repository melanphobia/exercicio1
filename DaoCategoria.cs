using Microsoft.Data.SqlClient;
using ProjetoCrud_3.NovaPasta;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrud_3.Entidades.Dao
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
                cn.CommandText = "insert into tb_Produtos([id],[categorias])values(@id,@categoria)";

                /*envia os dados a serem gravados*/
                cn.Parameters.Add("id", SqlDbType.VarChar).Value = categoria.Id;
                cn.Parameters.Add("categorias", SqlDbType.VarChar).Value = categoria.Categorias;
               

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
                    ct.Categorias = Convert.ToString(dr["Categorias"]);
                    
                    Console.WriteLine(ct.ToString());
                }
            }
        }

       
        

        internal static void delete(object categoria)
        {
            throw new NotImplementedException();
        }

        public void GetCategoriaByID(int id)
        {
            
        }

        public bool Update(Categoria categoria)
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*criado conexão com database*/
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bd_agenda;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                con.Open();
                /*monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "update tb_Produtos set nome = @nome, preco = @preco, descricao = @descricao, where id = @id";

                /*envia os dados a serem gravados*/
                cn.Parameters.Add("id", SqlDbType.Int).Value = categoria.Id;
                cn.Parameters.Add("categorias", SqlDbType.VarChar).Value = categoria.Id;

                /*abrir a conexaõ*/

                cn.Connection = con;
                /*executa a conexão*/
                cn.ExecuteNonQuery();
                return true;
            }
        }
    }
}

