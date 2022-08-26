namespace OrgFAQ.API.Infrastructure.EntityConfigurations.IdentityConfigurations;

class IdentityUserClaimEntityTypeConfiguration : IEntityTypeConfiguration<IdentityUserClaim<int>>
{
    public void Configure(EntityTypeBuilder<IdentityUserClaim<int>> userClaimBuilder) 
        =>  userClaimBuilder.ToTable("UserClaim", OrgFAQContext.DEFAULT_SCHEMA);
}
