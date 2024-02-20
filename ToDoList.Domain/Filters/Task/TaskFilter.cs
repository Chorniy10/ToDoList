using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Domain.Enum;

namespace ToDoList.Domain.Filters.Task
{
    public class TaskFilter : PagingFilter
    {
        public string Name { get; set; }
        public Priority? Priority { get; set; }

    }
}
