using System;

namespace IntersectonChainOfResponsibilities
{
    public class PoliceOfficerOperator : IIntersectionOperator
    {
        public IIntersectionOperator NextOperator { get; set; }

        public void Operation(
            Intersection intersection)
        {
            if(intersection.IsPoliceOfficerPresent)
            {
                Console.WriteLine("Policjant obsługuje skrzyżowanie!");
            }
            else
            {
                NextOperator.Operation(intersection);
            }
        }
    }
}