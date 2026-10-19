namespace DIDemo.Services
{
    public class ProductService : IProductService
    {
        public decimal CalculateDiscount(decimal price, decimal discountPercentage)
        {
            return price * (discountPercentage / 100);
        }
    }
}
