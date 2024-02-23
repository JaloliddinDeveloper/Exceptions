internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ismingizni kiriting: ");
        string name = Console.ReadLine();
       Console.WriteLine("Yoshingizni kiriting:");
        string age =Console.ReadLine();
        while(!TypeCheckInt(age))
        {
            Console.WriteLine("Yoshingizni sonda kiriting:");
            age = Console.ReadLine();
        }
        Console.WriteLine($"Ismingiz {name}. Yoshingiz {age}.");
    }
    static bool TypeCheckInt(String input)
    {
        int number = 0;
        return int.TryParse(input, out number);
    }
}