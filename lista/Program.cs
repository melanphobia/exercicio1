using System;

namespace lista
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<Car> cars = new List<Car>();
            cars.Add(new Car() { Id = 1, Placa = "chrevolet" });
            cars.Add(new Car() { Id = 2, Marca = "citroen" });
            cars.Add(new Car() { Id = 3, Modelo = "bmw" });
            cars.Add(new Car() { Id = 4, Cor = "bmw" });

            foreach (Car car in cars)
            {
                    Console.WriteLine(car.ToString());
            }
            Console.WriteLine("diga o que deseja adicionar: ");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    int y = 0;
                    string off = "sim";
                    while(off == "sim")
                    {
                        y++;
                        Console.WriteLine("insira a placa desejada");
                        string placa = Console.ReadLine();
                        Console.WriteLine("insira o marca do carro");
                        string marca = Console.ReadLine();
                        Console.WriteLine("insira o modelo do carro");
                        string modelo = Console.ReadLine();
                        Console.WriteLine("insira o cor do carro");
                        string cor = Console.ReadLine();
                        
                        cars.Add(new Car() { Id = y, Placa = placa, Modelo = modelo, Marca = marca, Cor = cor});

                        Console.WriteLine("deseja cadastrar algum carro novamente?");
                        off = Console.ReadLine();

                    }
                   break;

            }
        }
        
    }
}