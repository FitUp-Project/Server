namespace FitUp.Domain.Models
{
    public abstract class BaseEntity<TId>
        where TId : struct
    {
        public TId Id { get; private set; } = default;

        public override bool Equals(object? obj)
        {
            if (!(obj is BaseEntity<TId> other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (this.GetType() != other.GetType())
            {
                return false;
            }

            if (this.Id.Equals(default) || other.Id.Equals(default))
            {
                return false;
            }

            return this.Id.Equals(other.Id);
        }

        public static bool operator ==(BaseEntity<TId>? first, BaseEntity<TId>? second)
        {
            if (first is null && second is null)
            {
                return true;
            }

            if (first is null || second is null)
            {
                return false;
            }

            return first.Equals(second);
        }

        public static bool operator !=(BaseEntity<TId>? first, BaseEntity<TId>? second)
        {
            return !(first == second);
        }

        public override int GetHashCode()
        {
            return (this.GetType().ToString() + this.Id).GetHashCode();
        }
    }
}
