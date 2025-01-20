using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.RequestDtos.Tasks;
using MediatR;

namespace ProjectTracker.Application.Features.TaskDetails.Requests.Queries
{

    public class GetTaskDetailRequest:IRequest<IList<TaskItemRequestDto>>
    {
        /// <summary>
        /// 
        /// </summary>
        public int ProjectId { get; set; }
    }
}
