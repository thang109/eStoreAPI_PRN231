using SocialNetwork.Models;

namespace SocialNetwork.Interfaces
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsAsync();
    }
}
