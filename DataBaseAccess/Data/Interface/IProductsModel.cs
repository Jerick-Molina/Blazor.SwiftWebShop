namespace DataBaseAccess.Data.Models
{
    public interface IProductsModel
    {
         int ProductId { get; set; }
        string ProductBrand { get; set; }
        float ProductCost { get; set; }
        string ProductDescription { get; set; }
        string ProductGenre { get; set; }
        string ProductName { get; set; }
    }
}