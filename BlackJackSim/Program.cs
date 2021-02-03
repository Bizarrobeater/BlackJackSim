using System;

namespace BlackJackSim
{
    class Program
    {
        static void Main(string[] args)
        {
            CardShoe test = new CardShoe();
            test.InitialiseShoe();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(test.ToString());
        }
    }
}
