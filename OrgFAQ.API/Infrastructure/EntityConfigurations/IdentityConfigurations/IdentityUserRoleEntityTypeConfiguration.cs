namespace OrgFAQ.API.Infrastructure.EntityConfigurations.IdentityConfigurations;

class IdentityUserRoleEntityTypeConfiguration : IEntityTypeConfiguration<IdentityUserRole<int>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<int>> userRoleBuilder) 
        =>  userRoleBuilder.ToTable("UserRole", OrgFAQContext.DEFAULT_SCHEMA);
}
