using System.Diagnostics;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class PullRequestEventPayload : ActivityPayload
    {
        public string Action { get; protected set; }
        public int Number { get; protected set; }
        public Label Label { get; protected set; }
        public User RequestedReviewer { get; protected set; }
        public User Assignee { get; protected set; }
        public string Before { get; set; }
        public string After { get; set; }

        public PullRequest PullRequest { get; protected set; }
    }
}
