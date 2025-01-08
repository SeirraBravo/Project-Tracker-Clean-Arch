using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Application.DTOs.CommandDtos.Tasks
{
    public class CreateTaskDto
    {
        public string Title { get; set; }
        public string Remarks { get; set; }
        public bool IsCompleted { get; set; }
        public int ProjectId { get; set; }
    }
}
