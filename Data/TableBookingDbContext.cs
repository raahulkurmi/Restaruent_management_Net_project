using Final_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Data
{
    public class TableBookingDbContext : DbContext
    {
        public TableBookingDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<TableBooking> BookingTable { get; set; }
    }
}
