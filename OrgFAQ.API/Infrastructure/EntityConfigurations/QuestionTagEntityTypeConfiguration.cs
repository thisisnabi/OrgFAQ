namespace OrgFAQ.API.Infrastructure.EntityConfigurations;

class QuestionTagEntityTypeConfiguration : IEntityTypeConfiguration<QuestionTag>
{
    public void Configure(EntityTypeBuilder<QuestionTag> tagQuestionBuilder)
    {
        tagQuestionBuilder.ToTable("Tag", OrgFAQContext.DEFAULT_SCHEMA);

        tagQuestionBuilder.HasKey(b => b.Id);
 
        tagQuestionBuilder.Property(b => b.TagId)
            .IsRequired();

        tagQuestionBuilder.Property(b => b.QuestionId)
            .IsRequired();
    }
}
