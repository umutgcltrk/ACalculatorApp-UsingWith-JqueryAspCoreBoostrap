using System;

namespace Calculator.Models
{
    public class Calculator
    {
        public int CalculatorId { get; set; }
        public float Number1 { get; set; }
        public float Number2 { get; set; }
        public string Operator { get; set; }
        public float Result { get; set; }
        public string CreateTime { get; set; }
    }
}
