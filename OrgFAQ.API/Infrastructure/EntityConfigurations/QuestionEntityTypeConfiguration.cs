namespace OrgFAQ.API.Infrastructure.EntityConfigurations;

class QuestionEntityTypeConfiguration : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> questionBuilder)
    {
        questionBuilder.ToTable("Question", OrgFAQContext.DEFAULT_SCHEMA);

        questionBuilder.HasKey(b => b.Id);

        questionBuilder.Property(b => b.Id)
            .UseHiLo("QuestionSqc", OrgFAQContext.DEFAULT_SCHEMA);
        
        questionBuilder.Property(b => b.UserId)
            .IsRequired();

        questionBuilder.Property(b => b.Title)
            .HasMaxLength(400)
            .IsRequired();

        questionBuilder.Property(b => b.Context)
            .IsRequired();

        questionBuilder.Property(b => b.CreateOn)
            .IsRequired()
            .HasDefaultValueSql("GETDATE()");

        questionBuilder.HasMany(question => question.Comments)
            .WithOne(comment => comment.Question)
            .HasForeignKey(comment => comment.QuestionId)
            .OnDelete(DeleteBehavior.Cascade);

        questionBuilder.HasMany(b => b.Tags)
            .WithOne(tagQuestion => tagQuestion.Question)
            .HasForeignKey(tagQuestion => tagQuestion.QuestionId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
