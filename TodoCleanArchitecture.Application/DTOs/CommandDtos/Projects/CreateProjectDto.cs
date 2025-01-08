using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTracker.Application.DTOs.Common;

namespace ProjectTracker.Application.DTOs.CommandDtos.Projects
{
    public class CreateProjectDto
    {
        public int Title { get; set; }
        public string? Description { get; set; }
        public string ProjectType { get; set; }
        public float? CostEstimated { get; set; }
        public DateTime? StartDate { get; set; }
    }
}
