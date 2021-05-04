using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_StatePattern {
    class Ready : IState {
        public Flipper Flipper { get; set; }

        public Ready(Flipper flipper) {
            Flipper = flipper;
            Console.WriteLine("Game ready!");
        }

        public void AddCredit() {
            Flipper.Credits++;
            Console.WriteLine("You added one Credit!");
        }

        public void FlipLeft() {
            Console.WriteLine("Please start the game first!");
        }

        public void FlipRight() {
            Console.WriteLine("Please start the game first!");
        }

        public void Start() {
            Flipper.Credits--;

            Console.WriteLine("Game Started!");

            Random r = new Random();

            for (int i = 0; i < 16; ++i) {
                Flipper.ObstaclesLeft[i] = r.Next(10, 101);
                Flipper.ObstaclesRight[i] = r.Next(10, 101);
            }

            Flipper.SwitchState(new Level1(Flipper));
        }
    }
}
