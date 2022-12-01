namespace Apartat4
{
    class Program
    {
        static void Main()
        {
            string? input;
            var words = new List<string>();
            
            Console.WriteLine("Introdueix la primera paraula : ");
            input = Console.ReadLine();
            if (input != null) words.Add(input);

            Console.WriteLine("Introdueix la segona paraula : ");
            input = Console.ReadLine();
            if (input != null) words.Add(input);

            words.Sort();

            Console.WriteLine(String.Join(", ", words));
        }
    }
}