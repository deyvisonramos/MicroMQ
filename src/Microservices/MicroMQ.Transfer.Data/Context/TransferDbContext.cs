using MicroMQ.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroMQ.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public TransferDbContext(DbContextOptions options)
            :base(options)
        {
            
        }

        public DbSet<TransferLog> TranferLogs { get; set; }
    }
}