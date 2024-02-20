using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Domain.Enum
{
    public enum Priority
    {
        [Display(Name = "Проста")]
        Eesy = 1,
        [Display(Name = "Важлива")]
        Medium = 2,
        [Display(Name = "Критична")]
        Hard = 3
    }
}
