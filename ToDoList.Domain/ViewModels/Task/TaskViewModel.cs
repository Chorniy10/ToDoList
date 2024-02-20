using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Domain.ViewModels.Task
{
    public class TaskViewModel
    {
        public long Id { get; set; }

        [Display(Name = "Назва")]
        public string Name { get; set; }

        [Display(Name = "Готовність")]
        public string IsDone {  get; set; }

        [Display(Name = "Пріоритет")]
        public string Priority {  get; set; }

        [Display(Name = "Опис")]
        public string Description {  get; set; }

        [Display(Name = "Дата створення")]
        public string Created {  get; set; }

    }
}
