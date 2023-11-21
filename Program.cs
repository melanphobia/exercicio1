namespace projeto_crud
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto ct = new Produto(1, "higiene", "19");

            DaoProduto daoContato = new DaoProduto();
             if (daoContato.salvar(ct))
             {
                 Console.WriteLine("Contato salvo com sucesso");
             }
            daoContato.consultar();

            Console.ReadKey();
        }
    }
}