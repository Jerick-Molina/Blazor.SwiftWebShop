using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataBaseAccess.Data.Models
{
    public class ClothingProducts: IProductsModel
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public float ProductCost { get; set; }
        public string ProductGenre { get; set; }
        public string ProductBrand { get; set; }
        public string ProductDescription { get; set; }
    }
}
