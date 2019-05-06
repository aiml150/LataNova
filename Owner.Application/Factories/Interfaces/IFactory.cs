using System;
using System.Collections.Generic;
using System.Text;

namespace Owner.Application.Factories.Interfaces
{
    public interface IFactory<T>
    {
        T Create();
    }
}
