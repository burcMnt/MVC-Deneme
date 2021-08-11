using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoAppMVC.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string UserName { get; set; }
        [Required,MaxLength(20)]
        public string Password { get; set; }
        public virtual ICollection<Task> Tasks { get; set; } = new HashSet<Task>();
    }
}
