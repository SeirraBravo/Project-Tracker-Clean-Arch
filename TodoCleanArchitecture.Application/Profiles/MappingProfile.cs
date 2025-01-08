using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ProjectTracker.Application.DTOs;
using ProjectTracker.Application.DTOs.RequestDtos.Projects;
using ProjectTracker.Application.DTOs.RequestDtos.Tasks;
using ProjectTracker.Domain.Data;

namespace ProjectTracker.Application.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Project,ProjectRequestDto>().ReverseMap();
            CreateMap<TaskItem,TaskItemRequestDto>().ReverseMap();
        }
    }
}
