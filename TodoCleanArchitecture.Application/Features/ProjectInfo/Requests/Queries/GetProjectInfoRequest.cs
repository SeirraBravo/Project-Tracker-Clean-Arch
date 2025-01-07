using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using ProjectTracker.Application.DTOs;

namespace ProjectTracker.Application.Features.ProjectInfo.Requests.Queries
{
    public class GetProjectInfoRequest : IRequest<ProjectDto>
    {
        public int id { get; set; }
    }
}
