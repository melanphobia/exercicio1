namespace agregacaodesafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pessoas();
        }
        static void pessoas()
        {
            SortedList<string, Pessoa> nomes = new SortedList<string, Pessoa>();
            Pessoa pessoa = new Pessoa(25, "sumeria", 1783449902);

            nomes.Add("enki", pessoa);

            Object[] valores = nomes.Values.ToArray();
            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }

            IList<string> key = nomes.Keys;
            foreach (string k in key)
            {
                Console.WriteLine($"Key:{k}  {nomes[k].ToString()}");
            }
        }
    }
}