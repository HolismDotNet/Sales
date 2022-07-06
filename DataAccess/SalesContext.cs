namespace Sales;

public class SalesContext : DatabaseContext
{
    public override string ConnectionStringName => "Sales";

    public DbSet<Sales.SoldPackage> SoldPackages { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
