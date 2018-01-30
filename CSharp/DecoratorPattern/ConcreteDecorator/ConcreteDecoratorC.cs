using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern {
    class ConcreteDecoratorC :Decorator{
        public override void Operation() {
            base.Operation();
            string active = AddedBehavior("New Behavior");
            Console.WriteLine(active);
        }

    private string AddedBehavior(string active) {
            return active;
        }
    }
}
