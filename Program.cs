using ProjetoCrud_3.Entidades.Dao;
using ProjetoCrud_3.NovaPasta;

namespace ProjetoCrud_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string still = "";
            while (still != "SIM")
            {
                Console.Clear();
                Console.WriteLine("1 para criar categorias\n" +
                                  "2 para listar categorias\n" +
                                  "3 para atualizar categorias\n" +
                                  "4 para deletar categoria\n" +
                                  "-------------------------\n" +
                                  "5 para criar produto\n" +
                                  "6 para listar produto\n" +
                                  "7 para atualizar produto\n" +
                                  "8 para deletar produto");
                var opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        CreateCategoria();
                        break;
                    case 2:
                        GetCategorias();
                        break;
                    case 3:
                        UpdateCategoria();
                        break;
                    case 4:
                        DeleteCategoria();
                        break;
                    case 5:
                        CreateProduto();
                        break;
                    case 6:
                        GetProdutos();
                        break;
                    case 7:
                        UpdateProduto();
                        break;
                    case 8:
                        DeleteProduto();
                        break;
                    default:
                        break;
                }

                Console.WriteLine("encerrar programa? (Sim)");
                still = Console.ReadLine();
            }

            Console.ReadKey();
        }

        static void CreateCategoria()
        {
           Categoria categoria = new Categoria();
            DaoCategoria daoCategoria = new DaoCategoria();

            Console.WriteLine("digite a descrição da categoria:");
            categoria.Categorias = Console.ReadLine();
            daoCategoria.salvar(categoria);

            if (daoCategoria.salvar(categoria))
            {
                Console.WriteLine("categoria salva com sucesso");
            }
        }

        static void GetCategorias()
        {
            /*
            var categorias = DaoCategoria.GetCategorias();

            foreach (var categoria in categorias)
            {
                Console.WriteLine(categoria);
            }
            */
        }

        static void UpdateCategoria()
        {
            DaoCategoria daocategoria = new DaoCategoria();
            //daocategoria.consultar();
            Console.WriteLine("Digite o ID da categoria a ser atualizada:");
            var id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual novo nome voce desejada dar a categoria?");
            string categoria = Console.ReadLine();
            Categoria categorias1 = new Categoria() { Categorias = categoria, Id = id };
            daocategoria.Update(categorias1);

        }

        static void DeleteCategoria()
        {
            /*
            Console.WriteLine("Digite o ID da categoria que deseja excluir:");
            var id = Convert.ToInt32(Console.ReadLine());
            var categoria = DaoCategoria.GetCategoriaByID(id);

            if (id == categoria.Id)
            {
                Console.Clear();
                Console.WriteLine(categoria);
                Console.WriteLine("Tem certeza que seja excluir permanentemente esta categoria?(SIM)");
                var r = Console.ReadLine();
                if (r.ToUpper() == "SIM")
                {
                    DaoCategoria.Delete(categoria);
                    Console.WriteLine("Categoria deletada.");
                }
            }
            */
        }

       /*produto*/

        static void CreateProduto()
        {
            /*
            Produto produto = new Produto();

            Console.WriteLine("digite o nome do produto escolhido:");
            produto.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite a descricao do produto escolhido:");
            produto.Descricao = Console.ReadLine();
            Console.WriteLine("digite o preço do produto escolhido:");
            produto.Preco = Console.ReadLine();

            Console.WriteLine("digite o id da categoria do produto:");
            var id = Convert.ToInt32(Console.ReadLine());
            var categoria = DaoCategoria.GetCategoriaByID(id);
            produto.Categoria = categoria;

            if (DaoProduto.Salvar(produto))
            {
                Console.WriteLine("produto salvo com sucesso");
            }
            */
        }

        static void GetProdutos()
        {
            var produtos = DaoProduto.GetProdutos();

            foreach (var produto in produtos)
            {
                Console.WriteLine(produto);
            }
        }

        static void UpdateProduto()
        {
            /*
            Console.WriteLine("Digite o ID do produto a ser atualizado:");
            var id = Convert.ToInt32(Console.ReadLine());
            var produto = DaoProduto.GetProdutoByID(id);

            if (id == produto.Id)
            {
                Console.Clear();
                Console.WriteLine(produto);
                Console.WriteLine("\nDigite o novo nome:");
                var newId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o novo valor:");
                var newDescricao = Console.ReadLine();
                Console.WriteLine("Digite o novo estoque:");
                var newPreco = Console.ReadLine();
                Console.WriteLine("Digite o novo ID de categoria:");
                var newCatID = Convert.ToInt32(Console.ReadLine());
                DaoProduto.Update(produto, new Produto(newId, newDescricao, newPreco, DaoCategoria.GetCategoriaByID(newCatID)));
            }
            */
        }

        static void DeleteProduto()
        {
            /*
            Console.WriteLine("digite o id da categoria que será excluida: ");
            var id = Convert.ToInt32(Console.ReadLine());
            var produto = DaoProduto.GetProdutoByID(id);


            if (id == produto.Id)
            {
                Console.Clear();
                Console.WriteLine(produto);
                Console.WriteLine("Tem certeza que seja excluir esta categoria?(Sim)");
                var r = Console.ReadLine();
                if (r.ToUpper() == "SIM")
                {
                    DaoProduto.Delete(produto);
                    Console.WriteLine("produto deletado com sucesso");
                }
            }
            */
        }
    }
}