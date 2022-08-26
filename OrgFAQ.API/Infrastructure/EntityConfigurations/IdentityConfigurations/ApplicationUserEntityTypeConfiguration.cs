namespace OrgFAQ.API.Infrastructure.EntityConfigurations.IdentityConfigurations;

class ApplicationUserEntityTypeConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> userBuilder)
    {
        userBuilder.ToTable("User", OrgFAQContext.DEFAULT_SCHEMA);

        userBuilder.Property(b => b.FirstName)
            .HasMaxLength(40)
            .IsRequired();
        userBuilder.Property(b => b.LastName)
           .HasMaxLength(40)
           .IsRequired();

        userBuilder.HasMany(user => user.Questions)
            .WithOne(question => question.User)
            .HasForeignKey(question => question.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        userBuilder.HasMany(user => user.Comments)
            .WithOne(question => question.User)
            .HasForeignKey(question => question.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
