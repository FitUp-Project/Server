namespace FitUp.ProgramsService.Domain.Models.Programs
{
    using FitUp.Domain.Models;
    using Models.Common;
    using Models.Workouts;

    public class Program : DeletableEntity<int>, IAggregateRoot
    {
        private readonly HashSet<Workout> workouts;

        internal Program(
            string name,
            string description,
            string instructions,
            byte[] introductionVideo,
            DifficultyLevel difficultyLevel,
            TimeSpan approximatelyDuration)
        {
            this.Name = name;
            this.Description = description;
            this.Instructions = instructions;
            this.IntroductionVideo = introductionVideo;
            this.DifficultyLevel = difficultyLevel;
            this.ApproximatelyDuration = approximatelyDuration;

            this.workouts = new HashSet<Workout>();
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Instructions { get; private set; }
        public byte[] IntroductionVideo { get; private set; }
        public IReadOnlyCollection<Workout> Workouts => this.workouts.ToList().AsReadOnly();
        public DifficultyLevel DifficultyLevel { get; private set; }
        public TimeSpan ApproximatelyDuration { get; private set; }
    }
}
