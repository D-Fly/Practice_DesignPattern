using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern {
    class Program {
        static void Main(string[] args) {
            Operation oper;
            oper = OperationFactory.creatOperation("+");
            oper.NumberA = 12;
            oper.NumberB = 1;
            double result = oper.GetResult();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
