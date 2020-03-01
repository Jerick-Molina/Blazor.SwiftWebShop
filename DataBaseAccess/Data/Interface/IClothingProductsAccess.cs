using DataBaseAccess.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataBaseAccess.Data.Services
{
    public interface IClothingProductsAccess
    {
        Task<List<ClothingProducts>> GetClothingProducts();
        
    }
}