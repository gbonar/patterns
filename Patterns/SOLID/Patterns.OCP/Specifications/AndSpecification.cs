using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.OCP.Specifications
{
    public class AndSpecification<T> : Specification<T>
    {
        private readonly Specification<T> first, second;
        public AndSpecification(Specification<T> first, Specification<T> second)
        {
            this.first = first;
            this.second = second;
        }
        public override bool IsSatisfied(T t)
        {
            return first.IsSatisfied(t) && second.IsSatisfied(t);
        }
    }
}
