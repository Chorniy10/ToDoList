namespace ToDoList.Domain.Filters.Task;

public class PagingFilter
{
    public int PageSize { get; set; }
    
    public int Skip { get; set; }
}