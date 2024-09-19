using AutoMapper.Execution;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.Interfaces;
using SocialNetwork.Models;

namespace SocialNetwork.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(SocialMockContext context) : base(context)
        {

        }


        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
