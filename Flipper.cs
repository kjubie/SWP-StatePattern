using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_StatePattern {
    class Flipper {
        private IState State;
        public int Credits;
        public int Score;
        public int BallPlace = -1;

        public int[] ObstaclesLeft = new int[16];
        public int[] ObstaclesRight = new int[16];

        public Flipper() {
            Credits = 0;
            Score = 0;
            State = new NoCredit(this);
        }

        public void DoUserInput(char c) {
            switch (c) {
                case 's':
                    State.Start();
                    break;
                case 'l':
                    State.FlipLeft();
                    break;
                case 'r':
                    State.FlipRight();
                    break;
                case 'c':
                    State.AddCredit();
                    break;
                default:
                    Console.WriteLine("Invalid Input!");
                    break;
            }
        }

        public void SwitchState(IState state) {
            State = state;
        }
    }
}
