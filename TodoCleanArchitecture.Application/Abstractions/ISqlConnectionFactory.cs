﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Application.Abstractions
{
    public interface ISqlConnectionFactory
    {
       IDbConnection CreateConnection();
    }
}