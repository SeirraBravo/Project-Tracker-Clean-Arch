using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using ProjectTracker.Application.DTOs.CommandDtos.Projects;
using ProjectTracker.Domain.Data;

namespace ProjectTracker.Application.Features.ProjectInfo.Requests.Commands
{
    public class UpdateProjectCommand:IRequest<Unit>
    {
        public UpdateProjectDto updateProjectDto { get; set; }
    }
}
