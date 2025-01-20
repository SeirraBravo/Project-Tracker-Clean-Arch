using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ProjectTracker.Application.Contracts.Persistance;
using ProjectTracker.Application.Features.ProjectInfo.Requests.Commands;
using ProjectTracker.Domain.Data;

namespace ProjectTracker.Application.Features.ProjectInfo.Handlers.Commands
{
    public class UpdateProjectCommandHandler : IRequestHandler<UpdateProjectCommand, Unit>
    {
        private IProjectRepository _projectRepository;
        private IMapper _mapper;
        public UpdateProjectCommandHandler(IProjectRepository projectRepository, IMapper mapper)
        {
            _projectRepository = projectRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await _projectRepository.Get(request.updateProjectDto.id);

            _mapper.Map(request.updateProjectDto, project);

            await _projectRepository.Update(project);

            return Unit.Value;

        }
    }
}
