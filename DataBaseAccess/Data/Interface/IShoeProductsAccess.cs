using DataBaseAccess.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataBaseAccess.Data.Services
{
    public interface IShoeProductsAccess
    {
        Task<List<ShoeProducts>> GetShoeProducts();
    }
}