using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using ProjectTracker.Application.DTOs.CommandDtos.Projects;

namespace ProjectTracker.Application.Features.ProjectInfo.Requests.Commands
{
    public class CreateProjectCommand : IRequest<int>
    {
        public CreateProjectDto ProjectDto { get; set; }
    }
}
