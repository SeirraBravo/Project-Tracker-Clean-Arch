using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using ProjectTracker.Application.DTOs.CommandDtos.Tasks;

namespace ProjectTracker.Application.Features.TaskDetails.Requests.Commands
{
    public class CreateTaskCommand:IRequest<int>
    {
        public CreateTaskDto CreateTaskDto { get; set; }
    }
}
