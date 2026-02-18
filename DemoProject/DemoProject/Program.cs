using Microsoft.EntityFrameworkCore;

var _context = new CrmDbContext();

var leads = _context.Leads
    .Include(l => l.SalesRepresentative)
    .Include(l => l.Interactions)
    .ToList();

foreach (var l in leads)
{
    Console.WriteLine($"LeadName: {l.Name}");
    Console.WriteLine($"Company: {l.Company}");
    Console.WriteLine($"Rep: {l.AssignedRepId}");

    foreach (var i in l.Interactions)
    {
        Console.WriteLine($"Details: {i.Details}");
    }
}






class CrmDbContext : DbContext
{
    public DbSet<Lead> Leads { get; set; }

    public DbSet<SalesRepresentative> SalesRepresentatives { get; set; }

    public DbSet<LeadInteraction> LeadInteractions { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost;Database=LeadManagementSystem;User Id=sa;Password=Nikhil@1234;TrustServerCertificate=True");
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Lead>()
            .HasKey(l => l.LeadID);

        modelBuilder.Entity<SalesRepresentative>()
            .HasKey(sr => sr.RepId);

        modelBuilder.Entity<LeadInteraction>()
            .HasKey(li => li.InteractionId);


        modelBuilder.Entity<Lead>()
            .HasOne(l => l.SalesRepresentative)
            .WithMany(sr => sr.Leads)
            .HasForeignKey(l => l.AssignedRepId)
            .OnDelete(DeleteBehavior.Cascade);


        modelBuilder.Entity<LeadInteraction>()
            .HasOne(li => li.Lead)
            .WithMany(l => l.Interactions)
            .HasForeignKey(li => li.LeadId)
            .OnDelete(DeleteBehavior.Cascade);



        modelBuilder.Entity<SalesRepresentative>().HasData(
            new SalesRepresentative
            {
                RepId = 1,
                Name = "Nikhil",
                Email = "nikhil@gmail.com",
                Department = "Sales"
            },
            new SalesRepresentative
            {
                RepId = 2,
                Name = "Amit",
                Email = "amit@gmail.com",
                Department = "Sales"
            }
        );


        modelBuilder.Entity<Lead>().HasData(
            new Lead
            {
                LeadID = 1,
                Name = "Rahul Sharma",
                PhoneNo = "9999999999",
                Company = "Infosys",
                Position = "Manager",
                Status = "New",
                Source = "Website",
                Priority = "High",
                CreatedDate = new DateTime(2024, 1, 1),
                AssignedRepId = 1
            },
            new Lead
            {
                LeadID = 2,
                Name = "Priya Verma",
                PhoneNo = "8888888888",
                Company = "TCS",
                Position = "Director",
                Status = "Contacted",
                Source = "Referral",
                Priority = "Medium",
                CreatedDate = new DateTime(2024, 2, 1),
                AssignedRepId = 2
            }
        );


        modelBuilder.Entity<LeadInteraction>().HasData(
            new LeadInteraction
            {
                InteractionId = 1,
                LeadId = 1,
                InteractionType = "Call",
                Details = "Initial discussion completed",
                InteractionDate = new DateTime(2024, 1, 2),
                FollowUpDate = new DateTime(2024, 1, 5)
            },
            new LeadInteraction
            {
                InteractionId = 2,
                LeadId = 2,
                InteractionType = "Email",
                Details = "Proposal shared",
                InteractionDate = new DateTime(2024, 2, 2),
                FollowUpDate = new DateTime(2024, 2, 6)
            }
        );
    }
}







class Lead
{
    public int LeadID { get; set; }

    public string Name { get; set; }

    public string PhoneNo { get; set; }

    public string Company { get; set; }

    public string Position { get; set; }

    public string Status { get; set; }

    public string Source { get; set; }

    public string Priority { get; set; }

    public DateTime CreatedDate { get; set; }

    public int AssignedRepId { get; set; }

    public SalesRepresentative SalesRepresentative { get; set; }

    public List<LeadInteraction> Interactions { get; set; }
}



class LeadInteraction
{
    public int InteractionId { get; set; }

    public string InteractionType { get; set; }

    public string Details { get; set; }

    public DateTime InteractionDate { get; set; }

    public DateTime FollowUpDate { get; set; }

    public int LeadId { get; set; }

    public Lead Lead { get; set; }
}



class SalesRepresentative
{
    public int RepId { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string Department { get; set; }

    public List<Lead> Leads { get; set; }
}
