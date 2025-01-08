﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ProjectTracker.Application.DTOs.CommandDtos.Projects.Validators;
using ProjectTracker.Application.Features.ProjectInfo.Requests.Commands;
using ProjectTracker.Application.Persistance.Contracts;
using ProjectTracker.Domain.Data;

namespace ProjectTracker.Application.Features.ProjectInfo.Handlers.Commands
{
    internal class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, int>
    {
        private IProjectRepository _projectRepository;
        private IMapper _mapper;
        public CreateProjectCommandHandler(IProjectRepository projectRepository, IMapper mapper)
        {
            _projectRepository = projectRepository;
            _mapper = mapper;

        }
        public async Task<int> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            var validator = new ProjectValidator();
            var validationStatus = validator.Validate(request.ProjectDto);
            if (validationStatus.IsValid == false)
            {
                throw new Exception();
            }
            else
            {
                var newProject = _mapper.Map<Project>(request.ProjectDto);
                newProject = await _projectRepository.Add(newProject);
                return newProject.Id;
            }

        }
    }
}