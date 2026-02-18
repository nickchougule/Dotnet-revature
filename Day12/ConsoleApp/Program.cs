using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

CrmContext _context = new CrmContext();

// var customers = _context.Customers.ToList();

// _context.Customers.Add(new Customer {Name="MaheshBabu",Email="MaheshbabuSupremecy@gmail.com"});
// _context.SaveChanges();




// foreach (var customer in customers)
// {
//     Console.WriteLine($"Id: {customer.Id} Customer: {customer.Name}, Email: {customer.Email}");
// }

class CrmContext : DbContext
{
    // public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=CrmDB;User Id=sa;Password=Nikhil@1234;TrustServerCertificate=True");
        // optionsBuilder.UseMySQL("YourConnectionStringHere");
        // optionsBuilder.UsePostgreql("YourConnectionStringHere");
    }
}

public class Order
{
    [Key]
    public int OrderId { get; set; }

    [Required]
    [MaxLength(100)]
    [MinLength(3)]
    public string Product { get; set; }

    [Required]
    [Precision(18, 2)]
    public decimal Price { get; set; }

    [ForeignKey("CustomerId")]
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
}



public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}