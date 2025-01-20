using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.CommandDtos.Projects;
using MediatR;

namespace ProjectTracker.Application.Features.ProjectInfo.Requests.Commands
{
    public class CreateProjectCommand : IRequest<int>
    {
        public CreateProjectDto ProjectDto { get; set; }
    }
}
