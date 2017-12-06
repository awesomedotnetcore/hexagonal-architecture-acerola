﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Threading.Tasks;

namespace Acerola.Application.Queries
{
    public interface IAccountsQueries
    {
        Task<ExpandoObject> GetAsync(Guid id);
        Task<IEnumerable<ExpandoObject>> GetAsync();
    }
}
