using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Domain.Entity;
using ToDoList.Domain.Filters.Task;
using ToDoList.Domain.Response;
using ToDoList.Domain.ViewModels.Task;

namespace ToDoLIst.Service.Interfaces
{
    public interface ITaskService
    {
        Task<IBaseResponse<IEnumerable<TaskViewModel>>> CalculateCompletedTasks();
        Task<IBaseResponse<IEnumerable<TaskCompletedViewModel>>> GetCompletedTasks();
        Task<IBaseResponse<TaskEntity>> Create(CreateTaskViewModel model);
        Task<IBaseResponse<bool>> EndTask(long id);
        Task<DataTableResult> GetTasks(TaskFilter filter);

    }
}
