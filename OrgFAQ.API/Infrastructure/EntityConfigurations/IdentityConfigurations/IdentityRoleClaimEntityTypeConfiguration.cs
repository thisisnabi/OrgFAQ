namespace OrgFAQ.API.Infrastructure.EntityConfigurations.IdentityConfigurations;

class IdentityRoleClaimEntityTypeConfiguration : IEntityTypeConfiguration<IdentityRoleClaim<int>>
{
    public void Configure(EntityTypeBuilder<IdentityRoleClaim<int>> roleClaimBuilder) 
        =>  roleClaimBuilder.ToTable("RoleClaim", OrgFAQContext.DEFAULT_SCHEMA);
}
