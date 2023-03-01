using Domain.Primitives;

namespace Domain.Entities
{
    public sealed class Cart : Entity
    {
        public Cart(Guid id) :base(id) { }
        public int TotalQuantity { get; set; }
        public double TotalPrice { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

        public List<CartItem> CartItems = new List<CartItem>(); 

    }
}
