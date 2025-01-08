using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace ProjectTracker.Application.DTOs.CommandDtos.Projects.Validators
{
    public class ProjectValidator:AbstractValidator<CreateProjectDto>
    {
        public ProjectValidator()
        {
            RuleFor(p => p.Title)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull();


            RuleFor(p => p.CostEstimated)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .GreaterThan(0);

        }
    }
}
