using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ProjectTracker.Application.DTOs.RequestDtos.Tasks;
using ProjectTracker.Application.Features.TaskDetails.Requests.Queries;
using ProjectTracker.Application.Persistance.Contracts;

namespace ProjectTracker.Application.Features.TaskDetails.Handlers.Queries
{
    public class GetTaskDetailRequestHandler : IRequestHandler<GetTaskDetailRequest, TaskItemRequestDto>
    {
        private ITaskItemRepository _taskItemRepository;
        private IMapper _mapper;
        public GetTaskDetailRequestHandler(ITaskItemRepository taskItemRepository, IMapper mapper) 
        {
            _taskItemRepository = taskItemRepository;
            _mapper = mapper;
            
        }

        public async Task<TaskItemRequestDto> Handle(GetTaskDetailRequest request, CancellationToken cancellationToken)
        {
            var taskLists = await _taskItemRepository.Get(request.ProjectId);
            return _mapper.Map<TaskItemRequestDto>(taskLists);
        }
    }
}
