﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.Common;

namespace Application.DTOs.RequestDtos.Tasks
{
    public class TaskItemRequestDto : BaseDto
    {
        public string Title { get; set; }
        public string Remarks { get; set; }
        public bool IsCompleted { get; set; }
        public int ProjectId { get; set; }
    }
}
