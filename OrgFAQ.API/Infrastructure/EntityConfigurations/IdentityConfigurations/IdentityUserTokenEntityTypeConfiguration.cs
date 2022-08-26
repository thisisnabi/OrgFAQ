namespace OrgFAQ.API.Infrastructure.EntityConfigurations.IdentityConfigurations;

class IdentityUserTokenEntityTypeConfiguration : IEntityTypeConfiguration<IdentityUserToken<int>>
{
    public void Configure(EntityTypeBuilder<IdentityUserToken<int>> userTokenBuilder) 
        =>  userTokenBuilder.ToTable("UserToken", OrgFAQContext.DEFAULT_SCHEMA);
}
