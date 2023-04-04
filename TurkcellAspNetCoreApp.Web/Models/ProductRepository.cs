namespace TurkcellAspNetCoreApp.Web.Models;

public class ProductRepository
{
    private static List<Product> _products = new List<Product>()
    {
        new(){ Id = 1, Name = "Pen 1", Price = 100, Stock = 200 },
        new(){ Id = 2, Name = "Pen 2", Price = 200, Stock = 200 },
        new(){ Id = 3, Name = "Pen 3", Price = 300, Stock = 200 }
    };

    public List<Product> GetAll() => _products;
    public void Add(Product product) => _products.Add(product);
    public void Remove(int id) => _products.RemoveAll(x => x.Id == id);
}
