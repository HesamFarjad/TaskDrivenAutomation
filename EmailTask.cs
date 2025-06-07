using TaskManagementSystem.ITask;

namespace TaskManagementSystem.EmailT;

public class EmailTask : ITask<string>
{
    public string Message { get; set; }
    public string Receptor { get; set; }

    public string Perform()
    {
        return $"The message from {Receptor} with the content of {Message} has been sent.";
    }
}
