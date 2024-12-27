using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }
        // Four steps to add a table
        // 1. Create a model class
        // 2. Add DB Set
        // 3. add-migration AddDiaryEntryTable
        // 4. update-database
    }
}
