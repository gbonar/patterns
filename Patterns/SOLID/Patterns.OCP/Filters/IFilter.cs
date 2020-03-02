using System.Collections.Generic;
using Patterns.OCP.Specifications;

namespace Patterns.OCP.Filters
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, Specification<T> spec);
    }
}