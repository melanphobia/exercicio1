namespace AULA_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto(2, "milho", 5);
            CrudProduto crudProduto = new CrudProduto();
            crudProduto.salvar(produto);
        }
    }
}