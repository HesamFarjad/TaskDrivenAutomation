using TaskManagementSystem.EmailT;
using TaskManagementSystem.ReportT;
using TaskManagementSystem.TaskP;

namespace TaskManagementSystem.Program
{
    public class Program
    {
        static void Main()
        {
            var emailTask = new EmailTask()
            {
                Message = "Hi, this is a test Email.",
                Receptor = "example@exp.com",
            };

            var reportTask = new ReportTask
            {
                ReportName = "Annual report"
            };

            var emailProcessor = new TaskProcessor<EmailTask, string>(emailTask);
            var reportProcessor = new TaskProcessor<ReportTask, string>(reportTask);

            Console.WriteLine(emailProcessor.Execute());
            Console.WriteLine(reportProcessor.Execute());


        }
    }
}

