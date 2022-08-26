namespace OrgFAQ.API.Infrastructure.EntityConfigurations;

class TagEntityTypeConfiguration : IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> tagBuilder)
    {
        tagBuilder.ToTable("Tag", OrgFAQContext.DEFAULT_SCHEMA);

        tagBuilder.HasKey(b => b.Id);

        tagBuilder.Property(b => b.Id)
            .UseHiLo("TagSqc", OrgFAQContext.DEFAULT_SCHEMA);

        tagBuilder.Property(b => b.Name)
            .HasMaxLength(250)
            .IsRequired();
          
        tagBuilder.HasMany(tag => tag.Questions)
            .WithOne(tagQuestion => tagQuestion.Tag)
            .HasForeignKey(tagQuestion => tagQuestion.TagId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
