namespace OrgFAQ.API.Infrastructure.EntityConfigurations;

class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> categoryBuilder)
    {
        categoryBuilder.ToTable("Category", OrgFAQContext.DEFAULT_SCHEMA);

        categoryBuilder.HasKey(b => b.Id);

        categoryBuilder.Property(b => b.Id)
            .UseHiLo("CategorySqc", OrgFAQContext.DEFAULT_SCHEMA);

        categoryBuilder.Property(b => b.Name)
            .HasMaxLength(250)
            .IsRequired();
          
        categoryBuilder.HasMany(category => category.Questions)
            .WithOne(question => question.Category)
            .HasForeignKey(question => question.CategoryId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
