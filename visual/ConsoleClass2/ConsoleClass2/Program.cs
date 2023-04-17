using ConsoleClass2;
using ConsoleClass2.Models;

public class Program
{
    private static void Main(string[] args)
    {
        //string name1 = "Murad";
        //string surname1 = "Hamzayev";

        //string name2 = "Sanan";
        //string surname2 = "Abbasov";

        //Bele yazilmir student.cs deki kimi yazilir

        //obyekti

        //Student student1 = new(); //Student student = new Student(); ferq elemir

        //student1.Name = "Murad";
        //student1.Surname = "Hamzayev";
        //student1.Age = 19;


        //Student student2 = new()
        //{
        //    Name = "Murad",
        //    Surname = "Hamzayev",
        //    Age = 55

        //};

        ////Console.WriteLine(student2.Name);

        //List<Student> students = new(); //static classlarda new yazilmir

        //students.Add(student1);
        //students.Add(student2);

        //foreach (var item in students)
        //{
        //    Console.WriteLine(item.Name);
        //}

        Evvele:

        Menu kabab1 = new()
        {
            Name = "Lule",
            Price = 10,
            Description = "Quzu eti",
            Portion = 1,
            PhotoUrl = "img/1.png",  //meselen budu,  url qoysaqda isliyer consolda islemir saytda isliyir
            CreatedDate = DateTime.Now.AddDays(1) // 1 gun elave gelir add olmasa bugunki gun olur
        };


        Menu kabab2 = new()
        {
            Name = "Tike",
            Price = 10,
            Description = "Inek eti",
            Portion = 1,
            PhotoUrl = "img/1.png",  //meselen budu,  url qoysaqda isliyer consolda islemir saytda isliyir
            CreatedDate = DateTime.Now
        };

        List<Menu> menus = new();

        menus.Add(kabab1);
        menus.Add(kabab2);


        Console.WriteLine("1. Menu");
        Console.WriteLine("2. Add to menu");
        Console.WriteLine("3. Order");

        int userInput = Convert.ToInt32(Console.ReadLine());

        switch (userInput)
        {
            case 1:

        foreach (var item in menus)
        {
            Console.WriteLine($"{item.Name} {item.GetTax()}");
        }
                break;

                case 2:

        Console.WriteLine("Adi daxil edin: ");
        string name = Console.ReadLine();

        Console.WriteLine("Qiymeti daxil edin: ");
        decimal price = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Haqqinda: ");
        string desc = Console.ReadLine();

        Console.WriteLine("Pors daxil edin: ");
        int porsion = Convert.ToInt32(Console.ReadLine());
        

        Menu newMenu = new()
        {
            Name = name,
            Price = price,
            Description = desc,
            Portion = porsion,
        };

        menus.Add(newMenu);

                break;

                case 3:

                break;

            default:
                break;
        }
        goto Evvele;
    }
}
        //img daxil edinde stringle daxil edirik

//class members esas 3 dene idi  1.field  2.properties  3.methods