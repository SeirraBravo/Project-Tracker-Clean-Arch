using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using ProjectTracker.Application.DTOs.RequestDtos.Projects;

namespace ProjectTracker.Application.Features.ProjectInfo.Requests.Queries
{
    public class GetProjectInfoRequest : IRequest<ProjectRequestDto>
    {
        public int id { get; set; }
    }
}
