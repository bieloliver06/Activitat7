namespace Apartat2
{
    class Program
    {
        static void Main()
        {
            string? searchTerm;

            string? text;

            while (true)
            {
                Console.WriteLine("Introdueix el text: ");
                text = Console.ReadLine();
                if (text != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("El que has introduit no és valid.");
                }
            }

            while (true)
            {
                Console.WriteLine("Introdueix la paraula que vols trobar dins el text : ");
                searchTerm = Console.ReadLine();
                if (searchTerm != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("El que has introduit no és valid.");
                }
            }

            string[] source = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var matchQuery = from word in source
                             where word.Equals(searchTerm, StringComparison.InvariantCultureIgnoreCase)
                             select word;

            int wordCount = matchQuery.Count();
            Console.WriteLine($"S'han trobat {wordCount} vegades la paraula \"{searchTerm}\".");
        }
    }
}