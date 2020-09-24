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
        public PullRequestChanges Changes { get; protected set; }
    }

    public class PullRequestChanges
    {
        public PullRequestBaseChanges Base { get; set; }
        public PullRequestValueChanges Title { get; set; }
    }

    public class PullRequestBaseChanges
    {
        public PullRequestValueChanges Ref { get; set; }
        public PullRequestValueChanges Sha { get; set; }
    }

    public class PullRequestValueChanges
    {
        public string From { get; set; }
    }
}
