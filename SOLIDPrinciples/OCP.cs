// Open/Closed Principle - a class should be open for extension but closed for modification.
namespace SOLIDPrinciples
{
    public interface IIncrement
    {
        double Apply(double salary);
    }
    class Manager : IIncrement
    {
        public double Apply(double salary)
        {
            return salary * 1.5; // 50% raise
        }
    }
    class Junior : IIncrement
    {
        public double Apply(double salary)
        {
            return salary * 1.2; // 20% raise
        }
    }
}
