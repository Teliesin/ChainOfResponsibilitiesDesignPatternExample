using IntersectonChainOfResponsibilities.Operators;
using System;

namespace IntersectonChainOfResponsibilities
{
    class Program
    {
        static void Main(string[] args)
        {
            Intersection intersection = new Intersection();

            intersection.IsPoliceOfficerPresent = true;
            intersection.AreRoadSignsPresent = true;
            intersection.AreRoadSignsPresent = true;

            IIntersectionOperator rightHandRuleOperator = new RightHandRuleOperator();

            IIntersectionOperator roadSignsOperator = new RoadSignsOperator();
            roadSignsOperator.NextOperator = rightHandRuleOperator;

            IIntersectionOperator trafficLightsOperator = new TrafficLightsOperator();
            trafficLightsOperator.NextOperator = roadSignsOperator;

            IIntersectionOperator policeOfficerOperator = new PoliceOfficerOperator();
            policeOfficerOperator.NextOperator = trafficLightsOperator;

            IIntersectionOperator mainOperator = policeOfficerOperator;

            mainOperator.Operation(intersection);

            Console.ReadKey();
        }
    }
}