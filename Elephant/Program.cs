using System;

namespace Elephant
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant { Name = "Lucinda", EarSize = 33 };
            Elephant lloyd = new Elephant { Name = "Lloyd", EarSize = 40 };

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
            
            while (true)
            {
                char pressed = Console.ReadKey(true).KeyChar;
                Console.WriteLine($"You pressed {pressed}");
                if (pressed == '1')
                {
                    lloyd.WhoAmI();
                }
                else if (pressed == '2')
                {
                    lucinda.WhoAmI();
                }
                else if (pressed == '3')
                {
                    Elephant holder;
                    holder = lloyd;
                    lloyd = lucinda;
                    lucinda = holder;
                    Console.WriteLine("Reference have been swapped");
                }
                else return;
                Console.WriteLine();
            }
           
            
        }
    }
}
