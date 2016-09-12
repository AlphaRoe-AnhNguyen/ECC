using System.Data.Entity;


namespace ECC.Infrastructure.Classes
{
    public class ECCContext : DbContext
    {
        public ECCContext()
            : base("ECC")
        { }

        public DbSet<Resistor> Resistors { get; set; }
    }
}
