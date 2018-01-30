using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern {
    class Program {
        static void Main(string[] args) {
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA concreteDecoratorA = new ConcreteDecoratorA();
            ConcreteDecoratorB concreteDecoratorB = new ConcreteDecoratorB();
            ConcreteDecoratorC concreteDecoratorC = new ConcreteDecoratorC();

            concreteDecoratorA.SetComponent(c);
            concreteDecoratorB.SetComponent(concreteDecoratorA);
            concreteDecoratorC.SetComponent(concreteDecoratorB);

            concreteDecoratorC.Operation();

            Console.ReadKey();
            
        }
    }
}
