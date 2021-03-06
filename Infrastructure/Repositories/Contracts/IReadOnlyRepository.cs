﻿using System;
using System.Collections.Generic;

namespace Infrastructure.Repositories.Contracts
{
    public interface IReadOnlyRepository<T>
    {
        T Find(Guid id);
        IEnumerable<T> Get();
    }
}
