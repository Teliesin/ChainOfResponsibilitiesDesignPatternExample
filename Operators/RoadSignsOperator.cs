using System;

namespace IntersectonChainOfResponsibilities.Operators
{
    public class RoadSignsOperator : IIntersectionOperator
    {
        public IIntersectionOperator NextOperator { get; set; }

        public void Operation(
            Intersection intersection)
        {
            if (intersection.AreRoadSignsPresent)
            {
                Console.WriteLine("Pierwszeństo mają znaki drogowe");
            }
            else
            {
                NextOperator.Operation(intersection);
            }
        }
    }
}
