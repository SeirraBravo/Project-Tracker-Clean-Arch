using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ProjectTracker.Application.Contracts.Persistance;
using ProjectTracker.Application.Exceptions;
using ProjectTracker.Application.Features.ProjectInfo.Requests.Commands;
using ProjectTracker.Domain.Data;

namespace ProjectTracker.Application.Features.ProjectInfo.Handlers.Commands
{
    public class DeleteProjectCommandHandler : IRequestHandler<DeleteProjectCommand,Unit>
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IMapper _mapper;

        public DeleteProjectCommandHandler(IProjectRepository projectRepository,IMapper mapper)
        {
            _projectRepository = projectRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _projectRepository.Get(request.ProjectId);
            if (project == null)
            {
                throw new NotFoundException(nameof(Project),request.ProjectId);
            }
            await _projectRepository.Delete(project);
            return   Unit.Value;
        }

  
    }
}
