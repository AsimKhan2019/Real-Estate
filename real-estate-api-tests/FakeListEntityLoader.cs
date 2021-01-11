using System.Collections.Generic;
using RealEstate.Infra;

namespace RealEstate.Api.Tests
{
    public class FakeListLoader<T> : IEntityLoader<T>
    {
        private List<T> _list;

        public FakeListLoader(List<T> list)
        {
            _list = list;
        }
        public IEnumerable<T> LoadAll()
        {
            return _list;
        }
    }
}