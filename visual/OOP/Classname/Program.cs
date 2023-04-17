using Classname;

internal class Program
{
    private static void Main(string[] args)
    {
        // Student class'indan object yaradiriq
        Student student1 = new();
        student1.Name = "Murad";
        student1.Age = 19;
        student1.Surname = "Hamzayev";

        // iki cur yaza bilerik aralarinda ferq var

        Student student2 = new()
        {
            Name = "Murad",
            Surname = "Hamzayev",
            Age = 19
        };

        Console.WriteLine(student2.Name);

        List<Student> student = new();
        student.Add(student1);
        student.Add(student2);

        foreach (var item in student)
        {
            Console.WriteLine(item.Name);
        }
    }
}