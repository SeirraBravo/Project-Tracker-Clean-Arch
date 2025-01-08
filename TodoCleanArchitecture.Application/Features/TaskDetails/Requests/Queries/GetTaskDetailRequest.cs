using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using ProjectTracker.Application.DTOs.RequestDtos.Tasks;

namespace ProjectTracker.Application.Features.TaskDetails.Requests.Queries
{
    public class GetTaskDetailRequest:IRequest<TaskItemRequestDto>
    {
        public int ProjectId { get; set; }
    }
}
