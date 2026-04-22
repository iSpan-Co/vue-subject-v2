using server.Data;
using server.Dto;

namespace server.Services
{
    public class ProductService
    {
        private readonly List<ProductDto> _products = ProductData.datas;

        public List<ProductDto> GetAll() => _products;

        public ProductDto? GetById(int id) =>
            _products.FirstOrDefault(p => p.id == id);

        public ProductDto Create(ProductFormDto form)
        {
            var product = new ProductDto
            {
                id = _products.Any() ? _products.Max(p => p.id) + 1 : 1,
                name = form.name,
                category = form.category,
                price = form.price,
                stock = form.stock,
                desc = form.desc,
                imageUrl = form.imageUrl,
            };
            _products.Add(product);
            return product;
        }

        public ProductDto? Update(int id, ProductFormDto form)
        {
            var product = _products.FirstOrDefault(p => p.id == id);
            if (product == null) return null;
            product.name = form.name;
            product.category = form.category;
            product.price = form.price;
            product.stock = form.stock;
            product.desc = form.desc;
            product.imageUrl = form.imageUrl;
            return product;
        }

        public bool Delete(int id)
        {
            var product = _products.FirstOrDefault(p => p.id == id);
            if (product == null) return false;
            _products.Remove(product);
            return true;
        }
    }
}
