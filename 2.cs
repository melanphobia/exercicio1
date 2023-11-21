using System.Net.Http.Headers;

namespace projeto_crud_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("deseja:" + "criar produto \n" + "ler produto \n" + "atualizar produto \n" + "deletar produto \n");
            Console.ReadLine();
            createcategoria();
        }
        static void createcategoria()
        {
                Categoria ct = new  Categoria(1, "objeto", "17", "papel");
                DaoCategoria daoContato = new DaoCategoria();
                if (daoContato.salvar(ct))
                {
                    Console.WriteLine("Contato salvo com sucesso");
                }
                daoContato.consultar();
                Console.ReadKey();
        }
        static void readcategoria()
        {

        }
        static void updatecategoria()
        {

        }
        static void deletecategoria()
        {

        }
    }
}