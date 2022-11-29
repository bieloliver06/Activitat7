namespace Apartat4
{
    class Program
    {
        static void Main()
        {
            string? input;
            string[] words = new String[] {};
            Console.WriteLine("Introdueix el text : ");
            input = Console.ReadLine();
            if (input != null)
            {
                words = input.Split(' ');
            }

            Array.Sort(words);

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {words[i]}");
            }
        }
    }
}