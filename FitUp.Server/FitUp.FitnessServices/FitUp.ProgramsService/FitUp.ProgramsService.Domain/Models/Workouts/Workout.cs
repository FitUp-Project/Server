namespace FitUp.ProgramsService.Domain.Models.Workouts
{
    using FitUp.Domain.Models;
    using Models.Exercises;

    public class Workout : DeletableEntity<int>, IAggregateRoot
    {
        private readonly HashSet<Exercise> exercises;

        internal Workout(
            WorkoutType workoutType,
            TimeSpan? restBetweenSets = null)
        {
            this.WorkoutType = workoutType;
            this.RestBetweenSets = restBetweenSets;

            this.exercises = new HashSet<Exercise>();
        }

        internal Workout(TimeSpan? restBetweenSets = null)
        {
            this.RestBetweenSets = restBetweenSets;

            this.WorkoutType = default!;
            this.exercises = new HashSet<Exercise>();
        }

        public WorkoutType WorkoutType { get; private set; }
        public IReadOnlyCollection<Exercise> Exercises => this.exercises.ToList().AsReadOnly();
        public TimeSpan? RestBetweenSets { get; private set; }
    }
}
