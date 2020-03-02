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

    public class ColorSpecification : Specification<Product>
    {
        public Color Color { get; }

        public ColorSpecification(Color color)
        {
            Color = color;
        }
        public override bool IsSatisfied(Product p)
        {
            return p.Color == Color;
        }
    }

    public abstract class Specification<T>
    {
        public abstract bool IsSatisfied(T item);

        public static Specification<T> operator &(Specification<T> first, Specification<T> second)
        {
            return new AndSpecification<T>(first, second);
        }
    }


    public class SizeSpecification : Specification<Product>
    {
        public Size Size { get; }

        public SizeSpecification(Size size)
        {
            Size = size;
        }
        public override bool IsSatisfied(Product p)
        {
            return p.Size == Size;
        }
    }
}
