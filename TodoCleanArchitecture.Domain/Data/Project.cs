using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTracker.Domain.Common;

namespace ProjectTracker.Domain.Data
{
    public class Project : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public int Title { get; set; }
        public string? Description { get; set; }
        public bool IsDeleted { get; set; } = false;
        public ICollection<TaskItem> Tasks { get; set; }
    }
}
