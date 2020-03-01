using DataBaseAccess.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseAccess.Data.Services
{
    public class AllProductsAccess : IClothingProductsAccess, IShoeProductsAccess
    {
        public SqlDataAccess _db;

        public AllProductsAccess(SqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ClothingProducts>> GetClothingProducts()
        {
            string sqlCommand = "Select * From ClothingProducts";
            return _db.ConnectSql<ClothingProducts, dynamic>(sqlCommand, new { });
        }

        public Task<List<ShoeProducts>> GetShoeProducts()
        {
            string sqlCommand = "Select * From ShoeProducts";

            return _db.ConnectSql<ShoeProducts, dynamic>(sqlCommand, new { });
        }
    }
}
