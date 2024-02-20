using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Domain.Enum
{
    public enum StatusCode
    {
        TaskIsHasAlready = 1,
        TaskNotFound = 2,
        OK = 200,
        InternalServerError = 500,
    }
}
