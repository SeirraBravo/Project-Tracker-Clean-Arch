using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ProjectTracker.Application.Contracts.Persistance;
using ProjectTracker.Application.Features.TaskDetails.Requests.Commands;
using ProjectTracker.Domain.Data;

namespace ProjectTracker.Application.Features.TaskDetails.Handlers.Commands
{
    public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, int> 
    {
        private ITaskItemRepository _taskItemRepository;
        private IMapper _mapper;

        public CreateTaskCommandHandler(ITaskItemRepository taskItemRepository, IMapper mapper)
        {
            _taskItemRepository = taskItemRepository;
            _mapper = mapper;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<int> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var newTask = _mapper.Map<TaskItem>(request.CreateTaskDto);
            newTask = await _taskItemRepository.Add(newTask);
            return newTask.Id;

        }
    }
}
