using System.Collections.Generic;

namespace Apartat3
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            while (true)
            {
                int i_input;
                while (true)
                {
                    Console.WriteLine("Que vols fer? : (1) Afageix paraula (2) Llegir definicio (3) Sortir ");
                    string? input = Console.ReadLine();
                    if (input != null)
                    {
                        try
                        {
                            i_input = int.Parse(input);
                            if (i_input >= 1 || i_input <= 3) break;
                            else Console.WriteLine("El que has introduit no és una opció valida");
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("El que has introduit no és valid");
                        }
                    }
                }
                if (i_input == 1)
                {
                    string word;
                    string definition;
                    while (true)
                    {
                        Console.WriteLine("Introdueix la paraula que vols afagir al diccionari : ");
                        string? input = Console.ReadLine();
                        if (input != null)
                        {
                            word = input;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("El que has introduit no és valid");
                        }
                    }
                    while (true)
                    {
                        Console.WriteLine($"Introdueix la definició de {word} : ");
                        string? input = Console.ReadLine();
                        if (input != null)
                        {
                            definition = input;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("El que has introduit no és valid.");
                        }
                    }

                    try
                    {
                        dict.Add(word, definition);
                        Console.WriteLine($"{word} : {definition}");
                    }
                    catch (System.ArgumentException)
                    {
                        Console.WriteLine("La paraula ja estava afagida...");
                    }
                }
                else if (i_input == 2)
                {
                    string word;
                    while (true)
                    {
                        Console.WriteLine("Escriu la paraula que vols llegir la definiciió : ");
                        string? input = Console.ReadLine();
                        if (input != null)
                        {
                            word = input;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("El que has introduit no és valid.");
                        }
                    }
                    try
                    {
                        Console.WriteLine($"{word} : {dict[word]}");
                    } catch (System.Collections.Generic.KeyNotFoundException)
                    {
                        Console.WriteLine($"{word} no es present en el diccionari");
                    }

                }
                else if (i_input == 3)
                {
                    break;
                }
            }

        }
    }
}