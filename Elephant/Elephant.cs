using System;
namespace Elephant
{
    public class Elephant
    {
        public int EarSize;
        public string Name;

        public void WhoAmI()
        {
            Console.WriteLine($"My name is {Name}.");
            Console.WriteLine($"My years are {EarSize} inches tall.");
        }
    }
}
