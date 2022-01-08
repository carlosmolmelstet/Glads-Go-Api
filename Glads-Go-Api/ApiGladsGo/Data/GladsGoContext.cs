using ApiMySql.Data.Entities.EmergencyContacts;
using ApiMySql.Data.Entities.Positions;
using ApiMySql.Data.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace TechWeekFatecSul.Data
{
    public class GladsGoContext : DbContext
    {
        public GladsGoContext(DbContextOptions<GladsGoContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<EmergencyContact> EmergencyContacts { get; set; }
        public DbSet<Position> Positions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region
            var user = modelBuilder.Entity<User>();
            user.Property(e => e.Name).HasMaxLength(100).IsRequired();
            user.Property(e => e.Surname).HasMaxLength(100).IsRequired();
            user.Property(e => e.CPF).HasMaxLength(20).IsRequired();
            user.Property(e => e.RG).HasMaxLength(20).IsRequired();
            user.Property(e => e.Height).HasMaxLength(4).IsRequired();
            user.Property(e => e.Weight).HasMaxLength(3).IsRequired();
            user.Property(e => e.JerseyNumber).HasMaxLength(3);
            user.Property(e => e.Phone).HasMaxLength(20).IsRequired();
            user.Property(e => e.Email).HasMaxLength(50).IsRequired();
            user.Property(e => e.CEP).HasMaxLength(20);
            user.Property(e => e.Address).HasMaxLength(50).IsRequired();
            user.Property(e => e.AddressNumber).HasMaxLength(10).IsRequired();
            user.Property(e => e.City).HasMaxLength(30).IsRequired();
            user.Property(e => e.State).HasMaxLength(30).IsRequired();
            user.Property(e => e.Password).HasMaxLength(30).IsRequired();
            user.Property(e => e.Role).IsRequired();
            user.Property(e => e.PositionId).IsRequired();

            user.HasMany<EmergencyContact>(s => s.EmergencyContacts)
                .WithOne(g => g.User)
                .HasForeignKey(s => s.UserId);
            user.HasOne<Position>(s => s.Position)
               .WithMany(g => g.Users)
               .HasForeignKey(s => s.PositionId);
            #endregion

            #region
            var position = modelBuilder.Entity<Position>();
            position.Property(e => e.Name).HasMaxLength(50).IsRequired();
            position.Property(e => e.ShortName).HasMaxLength(4).IsRequired();
            #endregion

            #region
            var emergencyContacts = modelBuilder.Entity<EmergencyContact>();
            emergencyContacts.Property(e => e.Name).HasMaxLength(50).IsRequired();
            emergencyContacts.Property(e => e.Phone).HasMaxLength(20).IsRequired();
            emergencyContacts.Property(e => e.UserId).IsRequired();
            #endregion
        }
    }
}
