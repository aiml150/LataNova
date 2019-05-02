using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Factories.Interfaces
{
    public interface IFactory<T>
    {
        T Create();
    }
}
