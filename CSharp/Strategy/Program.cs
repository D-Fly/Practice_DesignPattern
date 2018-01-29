using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy {
    class Program {
        static void Main(string[] args) {
            Context contextA;
            Context contextB;
            Context contextC;

            contextA = new Context(new ConcreteStrategyA());
            contextA.ContextInterface();

            contextB = new Context(new ConcreteStrategyB());
            contextB.ContextInterface();

            contextC = new Context(new ConcreteStrategyC());
            contextC.ContextInterface();

            Console.ReadKey();
        }
    }
}
