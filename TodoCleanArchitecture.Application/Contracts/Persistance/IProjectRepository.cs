using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTracker.Domain.Data;

namespace ProjectTracker.Application.Contracts.Persistance
{
    public interface IProjectRepository : IGenericRepository<Project>
    {
    }
}
