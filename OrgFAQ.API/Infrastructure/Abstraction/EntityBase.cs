namespace OrgFAQ.API.Infrastructure.Abstraction;

public abstract class EntityBase
{
    private int? _requestedHashCode;
    private int _Id;

    public virtual int Id
    {
        get
        {
            return _Id;
        }
        protected set
        {
            _Id = value;
        }
    }
     
    public bool IsTransient() => Id == default;

    public override int GetHashCode()
    {
        if (!IsTransient())
        {
            if (!_requestedHashCode.HasValue)
            { _requestedHashCode = Id.GetHashCode() ^ 31; }

            return _requestedHashCode.Value;
        }

        return base.GetHashCode();
    }

    #region Operations
    public override bool Equals(object? obj)
    {
        if (obj == null || !(obj is EntityBase))
        { return false; }

        if (Object.ReferenceEquals(this, obj))
        { return true; }

        if (GetType() != obj.GetType())
        { return false; }

        EntityBase item = (EntityBase)obj;

        if (item.IsTransient() || IsTransient())
        { return false; }
        else

        { return item.Id == Id; }
    }

    public static bool operator ==(EntityBase left, EntityBase right)
    {
        if (Equals(left, null))
        {
            return Equals(right, null) ? true : false;
        }

        return left.Equals(right);
    }

    public static bool operator !=(EntityBase left, EntityBase right)
        => !(left == right);
    #endregion
}
