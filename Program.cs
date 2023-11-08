using System.Security.Cryptography.X509Certificates;

namespace agregacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
        static void colecaolist()
        {
            List<Categoria> categorias = new List<Categoria>();
            
        }
        static void agregar()
        {
            Categoria cereais = new Categoria(1, "cereais");
            Console.WriteLine(cereais.ToString());

            Produto milho = new Produto()
            {
                Id = 10,
                Descricao = "Milho",
                Preco = 15.50,
                categoria = cereais
            };

            Console.WriteLine(milho.ToString());
        }
    }
}