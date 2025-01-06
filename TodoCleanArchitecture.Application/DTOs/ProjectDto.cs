using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTracker.Application.DTOs.Common;
using ProjectTracker.Domain.Data;

namespace ProjectTracker.Application.DTOs
{
    public class ProjectDto:BaseDto
    {
        public int Title { get; set; }
        public string? Description { get; set; }
        public ICollection<TaskItemDto> Tasks { get; set; }
    }
}
