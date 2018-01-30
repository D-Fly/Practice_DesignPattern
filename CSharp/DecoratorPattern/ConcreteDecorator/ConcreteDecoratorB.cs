using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern {
    class ConcreteDecoratorB :Decorator{
        public override void Operation() {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("具体操作B");

        }

        private void AddedBehavior() { }
    }
}
