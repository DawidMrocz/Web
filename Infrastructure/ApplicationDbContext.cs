using Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public sealed class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}