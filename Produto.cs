using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrud_3.NovaPasta
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Preco { get; set; }
        public object Categoria { get; internal set; }

        public Produto() { }
        public Produto(int id, string descricao, string preco, object v)
        {
            Id = id;
            Descricao = descricao;
            Preco = preco;
        }

        static string path = @"C:\Users\gabriel.leuthauser\Desktop\Nova pasta (3)\Produto.txt";
        public static void CreateProduct(List<Produto> produtos)
        {
            CreateFile();
            try
            {
                Console.WriteLine("Digite o id do produto ");
                var id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite a descrição do produto ");
                var descricao = Console.ReadLine();

                Console.WriteLine("Digite o preço do produto ");
                var preco = Console.ReadLine();

                for (int i = 0; i < produtos.Count; i++)
                {
                    if (id == produtos[i].Id)
                    {
                        Console.WriteLine("Código inválida ");
                        throw new FormatException();
                    }
                }
                Produto product = new Produto() { Id = id, Descricao = descricao, Preco = preco };
                produtos.Add(product);
                WriteInFile(produtos);


                Console.Clear();
                ReadProducts(produtos);

            }
            catch (FormatException)
            {
            }
        }
        public static void CreateFile()
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                }
            }
        }
        public static void WriteInFile(List<Produto> products)
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                foreach (var produto in products)
                {
                    sw.WriteLine(produto);
                }
            }
        }
        public static void ReadInFile(List<Produto> products)
        {
            products.Clear();
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                int linha = 1;
                int id = 0;
                string descricao = "";
                string preco = "";

                while ((s = sr.ReadLine()) != null)
                {
                    if (linha == 1)
                    {
                        int posI = s.IndexOf("|");
                        id = Convert.ToInt32(s.Substring(0, posI));

                        s = s.Remove(0, posI + 2);
                        posI = s.IndexOf("|");
                        descricao = s.Substring(0, posI);

                        s = s.Remove(0, posI + 2);
                        posI = s.IndexOf("|");
                        preco = s.Substring(0, posI);
               
                        products.Add(new Produto { Id = id, Descricao = descricao, Preco = preco });

                    }

                }
                foreach (var item in products)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public static void ReadProducts(List<Produto> products)
        {
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
        }

        public static void UpdateProducts(List<Produto> products)
        {
            Console.WriteLine("digite o id do produto que deseja editar: ");
            var cod = Convert.ToInt32(Console.ReadLine());

            try
            {
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].Id.Equals(cod))
                    {

                        Console.WriteLine("digite a descrição do produto ");
                        var desc = Console.ReadLine();

                        Console.WriteLine("digite o preco do produto ");
                        var preco = Console.ReadLine();

                        products[i] = new Produto() { Id = products[i].Id, Descricao = desc, Preco = preco };

                        WriteInFile(products);
                    }
                }

            }
            catch (FormatException)
            {

            }
        }
        public static void DeleteProducts(List<Produto> products)
        {
            Console.WriteLine("digite o id do produto para ser excluído: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Id.Equals(codigo))
                {
                    products.Remove(products[i]);
                    Console.WriteLine("produto removido com sucoesso ");
                }
            }
            WriteInFile(products);
        }
        public override string ToString()
        {
            return $"{Id} | {Descricao} | {Preco} ";
        }
    }
}
