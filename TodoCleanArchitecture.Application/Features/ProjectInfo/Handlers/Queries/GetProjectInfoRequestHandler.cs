﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ProjectTracker.Application.DTOs.RequestDtos.Projects;
using ProjectTracker.Application.Features.ProjectInfo.Requests.Queries;
using ProjectTracker.Application.Persistance.Contracts;

namespace ProjectTracker.Application.Features.ProjectInfo.Handlers.Queries
{
    public class GetProjectInfoRequestHandler : IRequestHandler<GetProjectInfoRequest, ProjectRequestDto>
    {
        private IProjectRepository _projectRepository;
        private IMapper _mapper;

        public GetProjectInfoRequestHandler(IProjectRepository projectRepository, IMapper mapper)
        {
            _projectRepository = projectRepository;
            _mapper = mapper;
        }
        public async Task<ProjectRequestDto> Handle(GetProjectInfoRequest request, CancellationToken cancellationToken)
        {
            var project = await _projectRepository.Get(request.id);
            return _mapper.Map<ProjectRequestDto>(project);
        }
    }
}
