namespace DIDemo.Services
{
    public interface IProductService
    {
        decimal CalculateDiscount(decimal price, decimal discountPercentage);
    }
}
