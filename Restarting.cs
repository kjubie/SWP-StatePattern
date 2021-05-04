using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SWP_StatePattern {
    class Restarting : IState {
        public Flipper Flipper { get; set; }

        public Restarting(Flipper flipper) {
            Flipper = flipper;
            Restart();
        }

        private void Restart() {
            Console.WriteLine("Restarting Game! Please wait..");

            Thread.Sleep(5000);

            Flipper.Score = 0;
            Flipper.BallPlace = -1;

            Console.WriteLine("Game Restarted! Press 's'");
        }

        public void AddCredit() {
            Console.WriteLine("Please wait while the Game restarts!");
        }

        public void FlipLeft() {
            Console.WriteLine("Please wait while the Game restarts!");
        }

        public void FlipRight() {
            Console.WriteLine("Please wait while the Game restarts!");
        }

        public void Start() {
            if (Flipper.Credits > 0)
                Flipper.SwitchState(new Ready(Flipper));
            else
                Flipper.SwitchState(new NoCredit(Flipper));
        }
    }
}