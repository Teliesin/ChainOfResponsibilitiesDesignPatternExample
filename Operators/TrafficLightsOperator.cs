using System;

namespace IntersectonChainOfResponsibilities.Operators
{
    public class TrafficLightsOperator : IIntersectionOperator
    {
        public IIntersectionOperator NextOperator { get; set; }

        public void Operation(
            Intersection intersection)
        {
            if (intersection.AreTrafficLightsPresent)
            {
                Console.WriteLine("Przejazd zgodnie z światłami dogowymi");
            }
            else
            {
                NextOperator.Operation(intersection);
            }
        }
    }
}