using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern {
    class OperationAdd : Operation {
        public override double GetResult() {
            return NumberA + NumberB;
        }
    }

    class OperationSub : Operation {
        public override double GetResult() {
            return NumberA - NumberB;
        }
    }

    class OperationMul : Operation {
        public override double GetResult() {
            return NumberA * NumberB;
        }
    }

    class OperationDiv : Operation {
        public override double GetResult() {
            if (NumberB == 0) {
                throw new Exception("除数不能为零");
            }
            return NumberA / NumberB;
        }
    }
}
