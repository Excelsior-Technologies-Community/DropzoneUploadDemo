using DropzoneUploadDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace DropzoneUploadDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<UploadedFile> UploadedFiles { get; set; }
    }
}
