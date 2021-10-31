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
        public void HearMessage(string message, Elephant whoSaidIt)
        {
            Console.WriteLine(Name + " heard a message");
            Console.WriteLine(whoSaidIt.Name + " said this: " + message);
        }
        public void SpeakTo(Elephant whoToTalkTo,string message)
        {
            whoToTalkTo.HearMessage(message, this);
        }
    }
}
