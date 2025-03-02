// Interface Segregation Principle - A class should not be forced to implement interfaces it does not use.
namespace SOLIDPrinciples
{
    // 3 different interfaces have different methods to implement by derived class
    public interface IPrinter
    {
        void Print();
    }

    public interface IScanner
    {
        void Scan();
    }

    public interface IFax
    {
        void Fax();
    }

    // simple printer might only support printing so implementing only that interface
    public class SimplePrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }
    }

    // A Multifunction Printer implements all three interfaces because it supports all
    public class MultiFunctionPrinter : IPrinter, IScanner, IFax
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning document...");
        }

        public void Fax()
        {
            Console.WriteLine("Faxing document...");
        }
    }

}
