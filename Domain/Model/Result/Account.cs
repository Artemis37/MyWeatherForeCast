using Microsoft.EntityFrameworkCore;

namespace Domain.Model.Result
{
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string? Fullname { get; set; }
        public string? Email { get; set; }
        public int? Age { get; set; }
        public bool? Gender { get; set; }
    }

    public static class AccountModelBuilderExtension
    {
        public static void BuildAccountModel(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("Username")
                    .HasColumnType("nvarchar(50)")
                    .HasMaxLength(50);

                entity.Property(e => e.Age)
                    .HasColumnName("Age")
                    .HasColumnType("int")
                    .HasAnnotation("MinValue", 0)
                    .HasAnnotation("MaxValue", 100);

                entity.Property(e => e.Email)
                    .HasColumnName("Email")
                    .HasColumnType("nvarchar(100)")
                    .HasMaxLength(100);

                entity.Property(e => e.Fullname)
                    .HasColumnName("Fullname")
                    .HasColumnType("nvarchar(100)")
                    .HasMaxLength(100);
            });
        }
    }
}
