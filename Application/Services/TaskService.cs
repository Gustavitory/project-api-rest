using project_rest.Domain;
using project_rest.Domain.Interfaces.Repositories;
using project_rest.Application.Interfaces;

namespace project_rest.Application.Services;

public class TaskService : IServiceBase<Task, Guid>
{
    private readonly IRepoBase<Task, Guid> repoTask;

    public TaskService(IRepoBase<Task, Guid> _taskRepo)
    {
        repoTask = _taskRepo;
    }
    public Task Add(Task entity)
    {
        if (entity == null) throw new ArgumentNullException("Task is required");
        var resultTask = repoTask.Add(entity);
        return resultTask;
    }

    public Guid Delete(Guid entityID)
    {
        throw new NotImplementedException();
    }

    public Task Edit(Task entity)
    {
        throw new NotImplementedException();
    }

    public List<Task> Get()
    {
        throw new NotImplementedException();
    }

    public Task GetForId(Guid entityID)
    {
        throw new NotImplementedException();
    }
}