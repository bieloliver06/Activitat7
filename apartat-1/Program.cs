namespace Apartat1
{
    class Program
    {
        static void Main()
        {
            string? input;
            while (true)
            {
                Console.WriteLine("Introdueix la paraula que desitges veures si es un palíndrom : ");
                input = Console.ReadLine();
                if (input != null)
                {
                    bool isPalindrome = getPalindrome(input);
                    if (isPalindrome == true)
                    {
                        Console.WriteLine($"{input} és un palíndrom.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{input} no és un palíndrom.");
                        break;
                    }
                }

            }
        }
        public static bool getPalindrome(string inputString)
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