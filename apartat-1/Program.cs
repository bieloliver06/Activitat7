namespace apartat_1
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Introdueix la paraula que desitges veures si es un palíndrom : ");
                string? input = Console.ReadLine();
                if (input != null)
                {
                    bool isPalindrome = GetPalindrome(input);
                    if (isPalindrome)
                    {
                        Console.WriteLine($"{input} és un palíndrom.");
                        break;
                    }
                    elsesw
                    {
                        Console.WriteLine($"{input} no és un palíndrom.");
                        break;
                    }
                }

            }
        }
        public static bool GetPalindrome(string inputString)
        {
            string first = inputString.Substring(0, inputString.Length / 2);
            char[] arr = inputString.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }
    }
}