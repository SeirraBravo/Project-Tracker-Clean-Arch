using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTracker.Domain.Data;

namespace ProjectTracker.Application.Persistance.Contracts
{
    public interface ITaskItemRepository:IGenericRepository<TaskItem>
    {
    }
}
