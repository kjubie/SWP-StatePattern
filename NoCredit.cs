using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_StatePattern {
    class NoCredit : IState {
        public Flipper Flipper { get; set; }

        public NoCredit(Flipper flipper) {
            Flipper = flipper;
            Console.WriteLine("Insert Credit to Start!");
        }

        public void AddCredit() {
            Flipper.Credits++;
            Console.WriteLine("You added one Credit!");

            Flipper.SwitchState(new Ready(Flipper));
        }

        public void FlipLeft() {
            Console.WriteLine("Please start the game first!");
        }

        public void FlipRight() {
            Console.WriteLine("Please start the game first!");
        }

        public void Start() {
            Console.WriteLine("You don't have enough Credits!");
        }
    }
}
