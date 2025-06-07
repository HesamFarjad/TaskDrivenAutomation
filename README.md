# TaskDrivenAutomation
 A C# console application for automating task execution with generics and interfaces, focusing on email and report processing.

# GenericTaskProcessor

A simple and extensible C# console application that demonstrates how to use generics and interfaces to process different types of tasks (e.g. email sending, report generation) in a reusable and type-safe way.

## 🧩 Project Structure

- `ITask<T>` – Generic interface that defines a task with a `Perform()` method returning type `T`.
- `EmailTask` – Implements `ITask<string>`, simulates sending an email.
- `ReportTask` – Implements `ITask<string>`, simulates generating a report.
- `TaskProcessor<TTask, TResult>` – Generic processor that executes any task implementing `ITask<TResult>`.
- `Program` – Entry point demonstrating usage of the processor with two task types.

## ▶️ Sample Output

```text
== Task Results ==
The message from example@exp.com with the content of Hi, this is a test Email. has been sent.
Report 'Annual report' generated successfully.
