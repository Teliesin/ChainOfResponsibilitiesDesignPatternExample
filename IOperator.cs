namespace IntersectonChainOfResponsibilities
{
    public interface IIntersectionOperator
    {
        IIntersectionOperator NextOperator { get; set; }

        void Operation(Intersection intersection);
    }
}