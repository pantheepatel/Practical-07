// Dependency Inversion Principle - High-level modules should not depend on low-level modules. Both should depend on abstractions(abstract class/interface)
namespace SOLIDPrinciples
{
    // interface on which other version control system will be implemented
    public interface IVersionControl
    {
        void CommitMsg(string message);
        void Push();
        void Pull();
    }
    // defining methods of IVersionControl for GitVersionControl class
    class GitVersionControl : IVersionControl
    {
        public void CommitMsg(string message)
        {
            Console.WriteLine($"COMMITTING: {message}");
        }
        public void Push()
        {
            Console.WriteLine("Pushing commits...");
        }
        public void Pull()
        {
            Console.WriteLine("Pulling changes...");
        }
    }
    class DevelopmentTeam
    {
        private readonly IVersionControl versionControl;
        public DevelopmentTeam(IVersionControl versionControl)
        {
            // assigning version control accordingly
            this.versionControl = versionControl;
        }
        public void ToCommit(string commitMsg)
        {
            versionControl.CommitMsg(commitMsg); // calling method according to version control system
        }
        public void ToPush()
        {
            versionControl.Push();
        }
        public void ToPull()
        {
            versionControl.Pull();
        }
    }
}
