



namespace OrgFAQ.API.Extensions;

public static partial class GuardClauseExtensions
{

    public static T Null<T>(this IGuardClause guardClause, T input, string? parameterName = null, string? message = null)
    {
        if (input is null)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentNullException(parameterName);
            }
            throw new ArgumentNullException(parameterName, message);
        }

        return input;
    }


    public static string NullOrEmpty(this IGuardClause guardClause, string? input, string? parameterName = null, string? message = null)
    {
        Guard.Check.Null(input, parameterName, message);

        if (input == string.Empty)
        {
            throw new ArgumentException(message ?? $"Required input {parameterName} was empty.", parameterName);
        }

        return input ?? string.Empty;
    }


    public static Guid NullOrEmpty(this IGuardClause guardClause, Guid? input, string? parameterName = null, string? message = null)

    {
        Guard.Check.Null(input, parameterName, message);
        if (input == Guid.Empty)
        {
            throw new ArgumentException(message ?? $"Required input {parameterName} was empty.", parameterName);
        }

        return input.Value;
    }

    public static IEnumerable<T> NullOrEmpty<T>(this IGuardClause guardClause, IEnumerable<T>? input, string? parameterName = null, string? message = null)

    {
        Guard.Check.Null(input, parameterName, message);
        if (!input.Any())
        {
            throw new ArgumentException(message ?? $"Required input {parameterName} was empty.", parameterName);
        }

        return input;
    }

    public static string NullOrWhiteSpace(this IGuardClause guardClause, string? input, string? parameterName = null, string? message = null)
    {
        Guard.Check.NullOrEmpty(input, parameterName, message);
        if (String.IsNullOrWhiteSpace(input))
        {
            throw new ArgumentException(message ?? $"Required input {parameterName} was empty.", parameterName);
        }

        return input;
    }

    public static T Default<T>(this IGuardClause guardClause, T input, string? parameterName = null, string? message = null)
    {
        if (EqualityComparer<T>.Default.Equals(input, default(T)!) || input is null)
        {
            throw new ArgumentException(message ?? $"Parameter [{parameterName}] is default value for type {typeof(T).Name}", parameterName);
        }

        return input;
    }
 
}
