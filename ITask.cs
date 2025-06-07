namespace TaskManagementSystem.ITask;

public interface ITask<T>
{
    T Perform();
}
