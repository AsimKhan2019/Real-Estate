using System;
using System.Collections.Generic;

namespace RealEstate.Infra
{
    public interface IEntityLoader<T>
    {
        public IEnumerable<T> LoadAll();
    }
}
