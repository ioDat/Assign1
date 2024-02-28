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
        static void BlockMode(string tekst)
        {
            string blocks = new string('#', tekst.Length + 4);
            Console.WriteLine(blocks);
            Console.WriteLine($"# {tekst} #");
            Console.WriteLine(blocks);
        }
        
        
        
        
        
        
        // Alternate Case Mode - sPoNgE BoB

        //  Pig Latin - Where is my hat? = Erewhay isyay ymay athay?

    }
}


