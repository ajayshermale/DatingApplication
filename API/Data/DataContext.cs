using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AddUser> Users {get; set;}

}