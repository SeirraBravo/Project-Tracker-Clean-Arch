using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ProjectTracker.Application.DTOs;
using ProjectTracker.Application.Features.TaskDetails.Requests.Queries;
using ProjectTracker.Application.Persistance.Contracts;

namespace ProjectTracker.Application.Features.TaskDetails.Handlers.Queries
{
    public class GetTaskDetailRequestHandler : IRequestHandler<GetTaskDetailRequest, List<TaskItemDto>>
    {
        private ITaskItemRepository _taskItemRepository;
        private IMapper _mapper;
        public GetTaskDetailRequestHandler(ITaskItemRepository taskItemRepository, IMapper mapper) 
        {
            _taskItemRepository = taskItemRepository;
            _mapper = mapper;
            
        }

        public async Task<List<TaskItemDto>> Handle(GetTaskDetailRequest request, CancellationToken cancellationToken)
        {
            var taskLists = await _taskItemRepository.GetTaskDetails(request.ProjectId);
            return _mapper.Map<List<TaskItemDto>>(taskLists);
        }
    }
}
