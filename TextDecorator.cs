using System.Runtime.CompilerServices;

namespace Assignment1;

class TextDecorator
{
    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Not enough arguments");
            return;
        }

        Console.WriteLine("skriv noe");
        //string hei = Console.ReadLine();

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


        // Alternate Case Mode - sPoNgE bOb
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
        
        // Pig Latin - Where is my hat? = Erewhay isyay ymay athay?
        // From what I get of pig latin its supposed to be "Hereway isyay ymay athay?" and not what's in the description
        static void PigMode(string text)
        {
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                string onlyWord = word.TrimEnd(',', '.', '?', ';', ':');
                string punctation = word.Substring(onlyWord.Length);
                if (onlyWord.Length > 1)
                {
                    string firstLetter = onlyWord.Substring(0, 1);
 
                    string restOfWord = onlyWord.Substring(1);

                    string pigWord;

                    if (isVowel(firstLetter[0]))
                    {
                        pigWord = firstLetter + restOfWord + "yay";
                    }
                    else
                    {
                        pigWord = restOfWord + firstLetter.ToLower() + "ay";
                    }

                    if (char.IsUpper(word[0]))
                    {
                        pigWord = char.ToUpper(pigWord[0]) + pigWord.Substring(1);
                    }

                    Console.Write(pigWord + punctation + " ");
                }
                else
                {
                    Console.Write(word + " ");
                }
            }

            static bool isVowel(char letter)
            {
                return "aeiouAEIOU".IndexOf(letter) != -1;
            }
        }
    }
}
