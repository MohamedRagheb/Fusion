using System.Data.Entity;

public class MyDbContext : DbContext
{
    public MyDbContext() : base("Server=localhost;Port=3306;Database=mydatabase;Uid=root;") // Name of the connection string
    {
    }

    public DbSet<User> Users { get; set; }
    // Add other DbSets for your entities here
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    // Add other properties as needed
}
