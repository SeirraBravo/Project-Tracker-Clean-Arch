using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTracker.Application.DTOs.Common;

namespace ProjectTracker.Application.DTOs
{
    public class TaskItemDto : BaseDto
    {
        public string Title { get; set; }
        public ProjectDto? Project { get; set; }

        public int ProjectId { get; set; }
    }
}
