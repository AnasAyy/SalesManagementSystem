using SalesManagementSystem.Models;
using System.Data.Entity;
public class DataBaseContext : DbContext
{
    public DataBaseContext() : base("Data Source=Anas;Initial Catalog=salesmanagment;TrustServerCertificate=True")
    {
    }
  
    public DbSet<Bill> Bills { get; set; }
    public DbSet<BillItem> BillItems { get; set; }
    public DbSet<FinancialBond> FinancialBonds { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<ItemHistory> ItemHistories { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<PublicList> PublicLists { get; set; }
    public DbSet<Account> Accounts { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(
    //   "Data Source=DESKTOP-60E6PO8;Initial Catalog=SalesManagment;User Id=Sa;Password=A1234@1234;TrustServerCertificate=True"
    //   "Data Source=SQL8006.site4now.net;Initial Catalog=db_a91af3_salesmanagment;User Id=db_a91af3_salesmanagment_admin;Password=A1234@1234;TrustServerCertificate=True"
    //   "Data Source=DESKTOP-A7P1U3G;Initial Catalog=SalesManagment;User Id=sa;Password=123;TrustServerCertificate=True"
    //    );



}