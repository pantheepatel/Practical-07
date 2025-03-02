namespace SOLIDPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            // PRINCIPLE 1: Single-Responsibility Principle
            Developer Developer1 = new("Panthee", "patel.panthee.18@gmail.com", 45000); // creating 1 Developer
            DeveloperAddToDB addDeveloper1 = new();
            EmailService emailDeveloper1 = new();

            Console.WriteLine("\nPrinciple 1");
            addDeveloper1.Save(Developer1);
            emailDeveloper1.SendEmail(Developer1);

            // PRINCIPLE 2: Open-Closed Principle
            Junior calcIncDeveloper1 = new();
            double updatedSalary = calcIncDeveloper1.Apply(Developer1.Salary);
            Console.WriteLine("\nPrinciple 2");
            Console.WriteLine("Updated salary: " + updatedSalary);

            // PRINCIPLE 3: Liskov Substitution Principle
            IShape rect = new Rectangle(4, 5);
            IShape square = new Square(4);
            Console.WriteLine("\nPrinciple 3");
            Console.WriteLine($"Rectangle Area: {rect.GetArea()}");
            Console.WriteLine($"Square Area: {square.GetArea()}");

            // PRINCIPLE 4: Interface Segregation Principle
            Console.WriteLine("\nPrinciple 4");
            IPrinter printer = new SimplePrinter();
            printer.Print();
            MultiFunctionPrinter mfp = new MultiFunctionPrinter();
            mfp.Print();
            mfp.Scan();
            mfp.Fax();

            // PRINCIPLE 5: Dependency Inversion Principle
            Console.WriteLine("\nPrinciple 5");
            GitVersionControl git = new();
            DevelopmentTeam team1 = new(git);
            team1.toCommit("Commit 1");
            team1.toPush();
            team1.toPull();
        }
    }
}