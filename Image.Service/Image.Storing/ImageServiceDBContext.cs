using Microsoft.EntityFrameworkCore;
using Image.Domain.Models;

namespace Image.Storing
{

  public partial class ImageServiceDBContext : DbContext
  {
    public ImageServiceDBContext()
    {
    }

    public ImageServiceDBContext(DbContextOptions Options) : base(Options) { }

    //table
    public DbSet<ImageModel> Images { get; set; }

    protected override void OnConfiguring(DbContextOptinsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder.UseSqlServer("--connection string-- can ignore in .gitignore");
      }
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {

      builder.Entity<ImageModel>(entity =>
               {
                 entity.HasKey(e => e.Id);

                 entity.Property(e => e.Url)
                       .IsRequired()
                       .HasMaxLength(300);

                 entity.Property(e => e.Name)
                       .IsRequired()
                       .HasMaxLength(100);
               });

    }





  }

}