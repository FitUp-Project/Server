namespace FitUp.ExercisesService.Domain.Shared.Models
{
    public abstract class DeletableEntity<TId>
        : BaseEntity<TId>
        where TId : struct
    {
        public DateTime DeletedOn { get; private set; } = default;
        public bool IsDelete { get; private set; } = default;
    }
}
