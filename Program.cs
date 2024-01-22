namespace examen2;

class Program
{
    static void Main(string[] args)
    {
        Person[] personarray = new Person[5];
        for(int i=0;i<personarray.Length;i++)
        {
            personarray[i].FirstName = Console.ReadLine();
            personarray[i].LastName = Console.ReadLine();
            personarray[i].YearOfBirth = int.Parse(Console.ReadLine());
            personarray[i].Age = DateTime.Now.Year - personarray[i].YearOfBirth;
        }
        Console.WriteLine(PersonProcessor.oldest(personarray));
        Console.WriteLine(personarray[0].FirstName);
        Console.WriteLine(personarray[0].LastName);
        Console.WriteLine(personarray[0].YearOfBirth);
        Console.WriteLine(personarray[0].Age);
    }
}

