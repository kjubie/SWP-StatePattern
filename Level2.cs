using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_StatePattern {
    class Level2 : IState {
        public Flipper Flipper { get; set; }

        public Level2(Flipper flipper) {
            Flipper = flipper;

            Console.WriteLine("Level 2: ");

            Random r = new Random();
            Flipper.BallPlace = r.Next(0, 2);
            SwitchBall();
        }

        public void AddCredit() {
            Console.WriteLine("Can't add Credits while in Game!");
        }

        public void FlipLeft() {
            if (Flipper.BallPlace == 0) {
                Random r = new Random();
                int roll = r.Next(1, 11);

                int s;

                if (roll == 1) {
                    s = Flipper.ObstaclesRight[r.Next(0, 16)];
                    Flipper.Score += s;
                } else {
                    s = Flipper.ObstaclesLeft[r.Next(0, 16)];
                    Flipper.Score += s;
                }

                Console.WriteLine("You got " + s + " Points!");

                if (Flipper.Score >= 280) {
                    Console.WriteLine("You Won! Score: " + Flipper.Score);
                    Flipper.SwitchState(new Restarting(Flipper));
                    return;
                }

                Flipper.BallPlace = r.Next(0, 3);
                SwitchBall();
            } else {
                Console.WriteLine("Game Over! Your Score: " + Flipper.Score);
                Flipper.SwitchState(new Restarting(Flipper));
            }
        }

        public void FlipRight() {
            if (Flipper.BallPlace == 1) {
                Random r = new Random();
                int roll = r.Next(1, 11);

                int s;

                if (roll == 1) {
                    s = Flipper.ObstaclesRight[r.Next(0, 16)];
                    Flipper.Score += s;
                } else {
                    s = Flipper.ObstaclesLeft[r.Next(0, 16)];
                    Flipper.Score += s;
                }

                Console.WriteLine("You got " + s + " Points!");

                if (Flipper.Score >= 280) {
                    Console.WriteLine("You Won! Score: " + Flipper.Score);
                    Flipper.SwitchState(new Restarting(Flipper));
                    return;
                }

                Flipper.BallPlace = r.Next(0, 3);
                SwitchBall();
            } else {
                Console.WriteLine("Game Over! Your Score: " + Flipper.Score);
                Flipper.SwitchState(new Restarting(Flipper));
            }
        }

        private void SwitchBall() {
            switch (Flipper.BallPlace) {
                case 0:
                    Console.WriteLine("Ball falls to the left!");
                    break;
                case 1:
                    Console.WriteLine("Ball falls to the right!");
                    break;
                case 2:
                    Console.WriteLine("Ball falls through the middle! Game Over! Your Score: " + Flipper.Score);
                    Flipper.SwitchState(new Restarting(Flipper));
                    break;
            }
        }

        public void Start() {
            Console.WriteLine("Game already running!");
        }
    }
}
