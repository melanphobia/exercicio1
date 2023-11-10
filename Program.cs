namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            exercicio3();
        }
        static void exercicio3()
        {
                Dictionary<string, List<Produto>> categoria = new Dictionary<string, List<Produto>>();

                adicionarProduto(categoria, "comidas", new Produto("macarrao", 4.99));
                adicionarProduto(categoria, "veiculos", new Produto("chevrolet", 49.679));
                adicionarProduto(categoria, "higiene", new Produto("detergente", 15.42));
                Console.ReadLine();
        }

            static void adicionarProduto(Dictionary<string, List<Produto>> categorias, string categoria, Produto produto)
            {
                if (!categorias.ContainsKey(categoria))
                {
                    categorias[categoria] = new List<Produto>();
                }
                categorias[categoria].Add(produto);
            }

            static void exibirprodutoscategoria(Dictionary<string, List<Produto>> categorias)
            {
                foreach (var categoria in categorias)
                {
                    Console.WriteLine($"Categoria: {categoria.Key}");

                    foreach (var produto in categoria.Value)
                    {
                        Console.WriteLine($"  {produto}");
                    }

                    Console.WriteLine();
                }
            }
    }
}