namespace Patterns.OCP.Specifications
{
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
}