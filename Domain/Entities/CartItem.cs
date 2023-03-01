using Domain.Primitives;

namespace Domain.Entities
{
    public sealed class CartItem : Entity
    {
        public CartItem(Guid id) : base(id) { }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public Guid CartId { get; set; }
        public Cart Cart { get; set; } = null!;
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
