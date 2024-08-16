using System.Xml.Linq;
using test_app.Server.Models;

public class ProductService
{
    private readonly List<Product> _products = new();

    public ProductService()
    {
        // Seed with some data
        _products.Add(new Product { Id = 1, Name = "Laptop", Price = 999.99m });
        _products.Add(new Product { Id = 2, Name = "Smartphone", Price = 499.99m });
    }

    public IEnumerable<Product> GetAllProducts() => _products;

    public Product? GetProductById(int id) => _products.FirstOrDefault(p => p.Id == id);

    public void AddProduct(Product product) => _products.Add(product);

    public bool DeleteProduct(int id)
    {
        var product = GetProductById(id);
        if (product != null)
        {
            _products.Remove(product);
            return true;
        }
        return false;
    }
}
