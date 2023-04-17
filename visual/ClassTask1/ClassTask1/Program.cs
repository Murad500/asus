
using ClassTask1;

internal class Program
{
    private static void Main(string[] args)
    {
    Evvele:

        Masin masin1 = new()
        {
            Name = "Mercedes",
            Model = "c200",
            Mator = 2,
            Price = 12000,
            Age = 1998
        };

        Masin masin2 = new()
        {
            Name = "Lifan",
            Model = "320",
            Mator = 1.3,
            Price = 5000,
            Age = 2015
        };


        List<Masin> masins = new();

        masins.Add(masin1);
        masins.Add(masin2);


        Console.WriteLine("1. List");
        Console.WriteLine("2. Add");

        int userInput = Convert.ToInt32(Console.ReadLine());

        switch (userInput)
        {
            case 1:
                foreach (var item in masins)
                {
                    Console.WriteLine(item.Name);
                }
                break;

            case 2:
                Console.WriteLine("Adi daxil edin: ");
                string name = Console.ReadLine();

                Console.WriteLine("Model daxil edin: ");
                string model = Console.ReadLine();

                Console.WriteLine("Mator daxil edin: ");
                double mator = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Qiymeti daxil edin: ");
                int price = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ili daxil edin: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Masin newMasin = new()
                {
                    Name = name,
                    Model = model,
                    Age = age,
                    Price = price,
                    Mator = mator
                };

                masins.Add(newMasin);
                break;

            default:
                break;

        }
                goto Evvele;
    }
}