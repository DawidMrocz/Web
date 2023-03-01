using Domain.Primitives;

namespace Domain.Entities
{
    public sealed class Product:Entity
    {
        public Product(Guid id,string name,double price) :base(id)
        {
            Name = name;
            Price = price;   
        }
        public string Name { get; private set; }
        public double Price { get; private set;}
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
