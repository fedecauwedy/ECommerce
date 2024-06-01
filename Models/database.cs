using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using Cau.Tumidei._5h.ECommerce.Models;
public class Database : DbContext{
    private readonly DbContextOptions? _options;
    public Database(){}

        protected override void
        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=database.db");

        public DbSet<Jersey> Maglie { get; set; }
       public DbSet<Utente> Utenti { get; set; }
    }
