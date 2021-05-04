using System;

namespace SWP_StatePattern {
    class Program {
        static void Main(string[] args) {
            Flipper flipper = new();

            Console.WriteLine("Flipper!");
            Console.WriteLine("Inputs: 'c' = Add Credit, 's' = Start Game, 'l' = Flip Left, 'r' = Flip Right");

            while (true) {
                flipper.DoUserInput(char.Parse(Console.ReadLine()));
            } 
        }
    }
}
