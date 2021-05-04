using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_StatePattern {
    interface IState {
        public Flipper Flipper { get; set; }
        void FlipLeft();
        void FlipRight();
        void Start();
        void AddCredit();
    }
}
