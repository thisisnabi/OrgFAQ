namespace OrgFAQ.API.Infrastructure.EntityConfigurations;

class QuestionEntityTypeConfiguration : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> questionBuilder)
    {
        questionBuilder.ToTable("Question", OrgFAQContext.DEFAULT_SCHEMA);

        questionBuilder.HasKey(b => b.Id);

        questionBuilder.Property(b => b.Id)
            .UseHiLo("QuestionSqc", OrgFAQContext.DEFAULT_SCHEMA);

        questionBuilder.Property(b => b.Title)
            .HasMaxLength(400)
            .IsRequired();

        questionBuilder.Property(b => b.Context)
            .IsRequired();

        questionBuilder.Property(b => b.CreateOn)
            .IsRequired()
            .HasDefaultValueSql("GETDATE()");

        questionBuilder.Property(b => b.UserId)
            .IsRequired();
        
        //postConfiguration.HasMany(b => b.PaymentMethods)
        //    .WithOne()
        //    .HasForeignKey("BuyerId")
        //    .OnDelete(DeleteBehavior.Cascade);

        //var navigation = buyerConfiguration.Metadata.FindNavigation(nameof(Buyer.PaymentMethods));

        //navigation.SetPropertyAccessMode(PropertyAccessMode.Field);
    }
}
