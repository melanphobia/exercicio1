namespace exericicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            produto();
        }
        static void produto()
        {
         List<string> produtos = new List<string>();
         bool opcao = false;
         while (!opcao)
         {
                Console.WriteLine("escreva seu protudo escolhido");
                string x = Console.ReadLine();
                if (
                    produtos.Contains(x))
                {
                    Console.WriteLine($"o produto {x} ja foi armazenado");
                }
                else
                {
                    produtos.Add(x);
                }
                 Console.WriteLine("adicionar outro produto?  \n\n\n (sim) (não)");
                string confirma = Console.ReadLine().ToLower();
                if (confirma == "sim")
                {  
                  Console.WriteLine("Lista:\n");
                 for (int i = 0; i < produtos.Count; i++)
                 {
                  Console.WriteLine($"{produtos[i]}");
                 }
                  Console.Clear();
                }
                else
                {
                 Console.WriteLine("Lista:\n");
                 for (int i = 0; i < produtos.Count; i++)
                 {
                  Console.WriteLine($"{produtos[i]}");
                 }
                 opcao = true;
                 break;
                }
         }
        }
    }
}

