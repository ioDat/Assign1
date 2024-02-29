using System.Runtime.CompilerServices;

namespace Assignment1;

class TextDecorator
{
    static void Main(string[] args)
    {
        /*if (args.Length < 2)
        {
            Console.WriteLine("Not enough arguments");
            return;
        }
        */
        Console.WriteLine("skriv noe");
        string hei = Console.ReadLine();
        
        // decoration type applied to desired
        // not case sensitive

        // unknown decoration argument or too few arguments => feedback from system
        // "help" => help function, used as an argument


        // Block mode - # Around text #
        static void BlockMode(string text)
        {
            string blocks = new string('#', text.Length + 4);
            Console.WriteLine(blocks);
            Console.WriteLine($"# {text} #");
            Console.WriteLine(blocks);
        }
        
        
        // Alternate Case Mode - sPoNgE BoB
        static void AltMode(string text)
        {
            char[] chars = text.ToCharArray();
            bool upperCase = true;

            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsLetter(chars[i]))
                {
                    if (upperCase)
                        chars[i] = char.ToUpper(chars[i]);
                    else
                        chars[i] = char.ToLower(chars[i]);

                    // Toggle upperCase only if the current character is not a space
                    if (chars[i] != ' ')
                        upperCase = !upperCase;
                }
            }

            Console.WriteLine(new string(chars));
        }
        BlockMode(hei);
        AltMode(hei);

        //  Pig Latin - Where is my hat? = Erewhay isyay ymay athay?

        
    }
}


