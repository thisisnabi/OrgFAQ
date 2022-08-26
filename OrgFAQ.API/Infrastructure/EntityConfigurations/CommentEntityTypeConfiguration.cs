namespace OrgFAQ.API.Infrastructure.EntityConfigurations;

class CommentEntityTypeConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> commentBuilder)
    {
        commentBuilder.ToTable("Comment", OrgFAQContext.DEFAULT_SCHEMA);

        commentBuilder.HasKey(b => b.Id);

        commentBuilder.Property(b => b.UserId)
            .IsRequired();

        commentBuilder.Property(b => b.QuestionId)
            .IsRequired();

        commentBuilder.Property(b => b.Context)
            .HasMaxLength(400)
            .IsRequired();

        commentBuilder.Property(b => b.CreateOn)
            .IsRequired()
            .HasDefaultValueSql("GETDATE()");

        commentBuilder.HasMany(comment => comment.ChildrenCommnet)
            .WithOne(childComment => childComment.ParentComment)
            .HasForeignKey(childComment => childComment.ParentCommentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
