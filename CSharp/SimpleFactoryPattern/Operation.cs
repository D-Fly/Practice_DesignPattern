﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern {
    public class Operation {
        private double numberA = 0;
        private double numberB = 0;

        public double NumberA { get => numberA; set => numberA = value; }
        public double NumberB { get => numberB; set => numberB = value; }

        public virtual double GetResult() {
            double result = 0;
            return result;
        }
    }
}