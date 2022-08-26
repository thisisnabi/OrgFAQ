namespace OrgFAQ.API.Infrastructure.EntityConfigurations.IdentityConfigurations;

class ApplicationRoleEntityTypeConfiguration : IEntityTypeConfiguration<ApplicationRole>
{
    public void Configure(EntityTypeBuilder<ApplicationRole> roleBuilder) 
        =>  roleBuilder.ToTable("Role", OrgFAQContext.DEFAULT_SCHEMA);
}
