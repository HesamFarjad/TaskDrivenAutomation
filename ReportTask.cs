using TaskManagementSystem.ITask;

namespace TaskManagementSystem.ReportT;

public class ReportTask : ITask<string>
{
    public string ReportName { get; set; }
    public string Perform()
    {
        return $"Report {ReportName} generated successfully.";
    }
}