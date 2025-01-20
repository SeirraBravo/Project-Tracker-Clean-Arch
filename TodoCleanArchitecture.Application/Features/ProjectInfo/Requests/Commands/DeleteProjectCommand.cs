using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ProjectTracker.Application.Features.ProjectInfo.Requests.Commands
{
    public class DeleteProjectCommand:IRequest<Unit>
    {
        public int ProjectId { get; set; }
    }
}
