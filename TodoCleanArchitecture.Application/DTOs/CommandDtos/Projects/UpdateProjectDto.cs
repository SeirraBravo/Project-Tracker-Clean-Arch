using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.Common;

namespace Application.DTOs.CommandDtos.Projects
{
    public class UpdateProjectDto : BaseDto
    {
        public int Title { get; set; }
        public string? Description { get; set; }
        public string ProjectType { get; set; }
        public float? CostEstimated { get; set; }
        public float HoursAllotted { get; set; }
        public DateTime? StartDate { get; set; }
    }
}
