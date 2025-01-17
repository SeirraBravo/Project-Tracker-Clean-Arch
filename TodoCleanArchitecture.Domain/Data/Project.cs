﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTracker.Domain.Common;

namespace ProjectTracker.Domain.Data
{
    public class Project : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public int Title { get; set; }
        public string? Description { get; set; }
        public string ProjectType { get; set; }
        public float? CostEstimated { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? StartDate { get; set; }
        public float HoursAllotted { get; set; }

        public ICollection<TaskItem> Tasks { get; set; }
    }
}
