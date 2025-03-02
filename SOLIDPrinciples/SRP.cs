// Single Responsibility Principle - a class should have only one job or responsibility.
namespace SOLIDPrinciples
{
    // main class to have fields related to Developer
    class Developer
    {
        public string Name { get; }
        public string Email { get; }
        public double Salary { get; }
        // Developer creation
        public Developer(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
    // RESPONSIBILITY: to save Developer into database only
    class DeveloperAddToDB
    {
        public void Save(Developer Developer)
        {
            Console.WriteLine($"Saving {Developer.Name} to the database.");
        }
    }
    // RESPONSIBILITY: send email to specified address
    class EmailService
    {
        public void SendEmail(Developer Developer)
        {
            Console.WriteLine($"Sending an email to {Developer.Email}.");
        }
    }
}
