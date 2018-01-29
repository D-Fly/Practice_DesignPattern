using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy {
    class ConcreteStrategyA : Strategy {
        public override void AlgorithmInterface() {
            Console.WriteLine("algorithm A");
        }
    }

    class ConcreteStrategyB : Strategy {
        public override void AlgorithmInterface() {
            Console.WriteLine("algorithm B");
        }
    }

    class ConcreteStrategyC : Strategy {
        public override void AlgorithmInterface() {
            Console.WriteLine("algorithm C");
        }
    }
}
