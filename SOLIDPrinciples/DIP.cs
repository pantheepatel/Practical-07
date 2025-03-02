// Dependency Inversion Principle
namespace SOLIDPrinciples
{
    public interface IVersionControl
    {
        void CommitMsg(string message);
        void Push();
        void Pull();
    }
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
            this.versionControl = versionControl;
        }
        public void toCommit(string commitMsg)
        {
            versionControl.CommitMsg(commitMsg);
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
