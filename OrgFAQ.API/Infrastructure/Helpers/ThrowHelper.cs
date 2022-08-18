namespace OrgFAQ.API.Infrastructure.Helpers;

public static class ThrowHelper
{
    public static void ThrowArgumentNullException(string paramName)
    {
        throw new ArgumentNullException(paramName);
    }

    public static void ThrowArgumentNullOrEmptyException(string paramName)
    {
        throw new ArgumentException("Argument cannot be null or empty.", paramName);
    }

    public static void ThrowInvalidOperationException(string message)
    {
        throw new InvalidOperationException(message);
    }

    public static void ThrowInvalidPropertyException(string paramName)
    {
        throw new ArgumentException("Invalid selected property for order list.", paramName);
    }

    public static void ThrowRollbackTransactionException(Guid? transactionId)
    {
        throw new ArgumentException($"Transaction [Id:{transactionId.ToString() ?? "InvalidId"}] was marked for rollback.");
    }

}


