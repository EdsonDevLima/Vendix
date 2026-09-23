using backend.Doamin.Entity;
using Microsoft.EntityFrameworkCore;

namespace backend.Infraestructure.database{
    
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options){}

        DbSet<CompanyAdress> CompanyAdresses{get;set;}
        DbSet<Company> Company{get;set;}
        DbSet<CompanySettings> CompanySettings{get;set;}

        DbSet<Product> Product{get;set;}
        DbSet<UserAdress> UserAdress{get;set;}
        DbSet<UserOrder> Orders{get;set;}
        DbSet<User>


    }
}