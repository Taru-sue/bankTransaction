using Microsoft.EntityFrameworkCore;

namespace bankTransaction.Models
{
    public class transactionDbContext:DbContext 
    {
        public transactionDbContext(DbContextOptions<transactionDbContext> options) : base(options)
        {
        
        }
        public DbSet<Transaction> Transactions { get; set; }

    }
    }

