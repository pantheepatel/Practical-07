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
        public void CommitMsg(string msg)
        {
            Console.WriteLine($"COMMITTING: {msg}");
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
        private IVersionControl versionControl;
        public DevelopmentTeam(IVersionControl versionControl)
        {
            // assigning version control accordingly
            this.versionControl = versionControl;
        }
        public void toCommit(string commitMsg)
        {
            versionControl.CommitMsg(commitMsg); // calling method according to version control system
        }
        public void toPush()
        {
            versionControl.Push();
        }
        public void toPull()
        {
            versionControl.Pull();
        }
    }
}
