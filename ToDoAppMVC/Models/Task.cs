using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAppMVC.Models
{
    public class Task
    {

        [ForeignKey("User")]
        public int Id { get; set; }
        public string Description { get; set; }

        public virtual User User { get; set; }
    }
}
