using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotNet8Authentication.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : IdentityDbContext(options)
    {
    }
}





















