namespace OrgFAQ.API.Infrastructure;

public class Guard : IGuardClause
{
    public static IGuardClause Check { get; } = new Guard();

    private Guard() { }
}
