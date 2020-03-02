namespace Patterns.OCP.Specifications
{
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