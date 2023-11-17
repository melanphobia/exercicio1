namespace Arquivo
{
    internal class Program
    {
        static string path = @"C:\Users\gabriel.leuthauser\Desktop\Nova pasta\teste1.txt";
        static void Main(string[] args)
        {
            bool r = false;
            while (!r)
            {
                CriarArquivo();
                Console.WriteLine("digite 1 para criar um produto ////// Digite 2 para contatar os produtos listados");
                int opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1: 
                        CriarProduto();
                        break;
                    case 2:
                        LerLista();
                        break;
                    default:
                        Console.WriteLine("produto invalida");
                    break;
                }
                Console.WriteLine("Deseja continuar o cadastro dos produtos? (Sim) (Não)");
                string aux = Console.ReadLine().ToLower();
                if (aux == "sim")
                {
                    r = false;
                }
                else
                {
                    r = true;
                }
            }
            Console.ReadKey();
        }
        static void CriarArquivo()
        {
            if (!File.Exists(path))
            {
                // File.CreateText(path);
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("produtos listados:");
                }
            }
        }
        static void LerLista()
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        static void CriarProduto()
        {
            Console.WriteLine("Digite o nome do produto: ");
            string contato = Console.ReadLine();
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(contato);
            }
            Console.Clear();
        }
    }
}