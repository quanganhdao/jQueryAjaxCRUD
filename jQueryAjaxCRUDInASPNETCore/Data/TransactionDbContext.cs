using jQueryAjaxCRUDInASPNETCore.Models;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace jQueryAjaxCRUDInASPNETCore.Data
{
  public class TransactionDbContext : DbContext
  {
    public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
    {
    }
    public DbSet<TransactionModel> Transactions { get; set; }
  }
}
