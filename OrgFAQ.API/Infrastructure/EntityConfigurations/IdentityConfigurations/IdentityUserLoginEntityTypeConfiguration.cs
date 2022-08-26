namespace OrgFAQ.API.Infrastructure.EntityConfigurations.IdentityConfigurations;

class IdentityUserLoginEntityTypeConfiguration : IEntityTypeConfiguration<IdentityUserLogin<int>>
{
    public void Configure(EntityTypeBuilder<IdentityUserLogin<int>> userLoginBuilder)
        =>  userLoginBuilder.ToTable("UserLogin", OrgFAQContext.DEFAULT_SCHEMA);
}
