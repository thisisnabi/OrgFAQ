namespace OrgFAQ.API.Infrastructure.Exceptions;

public class OrgFAQDomainException  : Exception
{
    public OrgFAQDomainException()
    { }

    public OrgFAQDomainException(string message)
        : base(message)
    { }

    public OrgFAQDomainException(string message, Exception innerException)
        : base(message, innerException)
    { }
}
