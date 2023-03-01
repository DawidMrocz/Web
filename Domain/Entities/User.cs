using Domain.Primitives;

namespace Domain.Entities
{
    public sealed class User : Entity
    {
        public User(Guid id, string userName) : base(id)
        {
            UserName = userName;
        }
        public string UserName { get; private set; }
        public double Price { get; private set; }
        public Cart Cart { get; set; } = null!;
    }
}
