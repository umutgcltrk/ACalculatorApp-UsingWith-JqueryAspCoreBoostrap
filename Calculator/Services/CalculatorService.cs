using Calculator.Models.DbConnection;
using System;

namespace Calculator.Services
{
    public class CalculatorService
    {
        public void Transactions(Models.Calculator calculator)
        {
            using var c = new DatabaseContext();
            calculator.CreateTime = DateTime.Now.ToString();
            if (calculator.Number1 != null && calculator.Number2 != null && calculator.Operator != null)
            {
                if (calculator.Operator == "+")
                {
                    var x = calculator.Number1 + calculator.Number2;
                    calculator.Result = x;
                }
                else if (calculator.Operator == "-")
                {
                    var x = calculator.Number1 - calculator.Number2;
                    calculator.Result = x;
                }
                else if (calculator.Operator == "*")
                {
                    var x = calculator.Number1 * calculator.Number2;
                    calculator.Result = x;
                }
                else if (calculator.Operator == "/")
                {
                    var x = (calculator.Number1) / (calculator.Number2);
                    calculator.Result = x;
                }
                c.Add(calculator);
                c.SaveChanges();
            }
        }
    }
}
