using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.Common;
using ProjectTracker.Domain.Data;

namespace Application.DTOs.RequestDtos.Projects
{
    public class ProjectRequestDto : BaseDto
    {
        public int Title { get; set; }
        public string? Description { get; set; }
        public string ProjectType { get; set; }
        public float HoursAllotted { get; set; }
        public DateTime? StartDate { get; set; }

    }
}
