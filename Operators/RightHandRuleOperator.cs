using System;

namespace IntersectonChainOfResponsibilities.Operators
{
    public class RightHandRuleOperator : IIntersectionOperator
    {
        public IIntersectionOperator NextOperator { get; set; }

        public void Operation(
            Intersection intersection)
        {
            Console.WriteLine("Stosujemy zasadę prawej ręki!1!");
        }
    }
}