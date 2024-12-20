namespace search_algo.DesignPatterns.Creational;

public class JobInterview
{
    public string Requirement { get; private set; }
    public string JobPost { get; private set; }
    public string InterviewStatus { get; private set; }
    public bool HireStatus { get; private set; }

    public JobInterview(
        string requirement,
        string jobPost,
        string interviewStatus,
        bool hireStatus)
    {
        Requirement = requirement;
        JobPost = jobPost;
        InterviewStatus = interviewStatus;
        HireStatus = hireStatus;
    }
}

public class JobBuilder
{

    private string requirement;
    private string jobPost;
    private string interviewStatus;
    private bool hireStatus;

    public JobBuilder()
    {

    }
    public JobInterview Build()
    {
        return new JobInterview(requirement, jobPost, interviewStatus, hireStatus);
    }


    public JobBuilder GetJDOfCandidate(string a)
    {
        requirement = a;
        return this;
    }
    public JobBuilder PostJob(string a)
    {
        jobPost = a;
        return this;
    }
    public JobBuilder CandidateInterview(string a)
    {
        interviewStatus = a;
        return this;
    }
    public JobBuilder Finalizing(bool a)
    {
        hireStatus = a;
        return this;
    }

}

public static class BuilderPatternExecution
{
    public static void Execute()
    {
        var finalObj = new JobBuilder()
                            .CandidateInterview("Some Day")
                            .GetJDOfCandidate(".net")
                            .PostJob("Developer Role")
                            .Finalizing(false)
                            .Build();

    }

}