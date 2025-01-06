using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTracker.Domain.Common;

namespace ProjectTracker.Domain.Data
{
    public class TaskItem : BaseEntity
    {
        public string Title { get; set; }
        public string Remarks { get; set; }
        public bool IsCompleted { get; set; }
        [ForeignKey("Project")]
        public int ProjectId {  get; set; }
        public Project Project { get; set; }



    }
}
