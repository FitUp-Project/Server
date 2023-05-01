namespace FitUp.ProgramsService.Domain.Models.Exercises
{
    using FitUp.Domain.Models;
    using Models.Common;

    public class Exercise : DeletableEntity<int>, IAggregateRoot
    {
        private readonly HashSet<MuscleGroup> targetMuscleGroups;

        internal Exercise(
            string name,
            string description,
            string instructions,
            Video video,
            SetsInformation setsInformation,
            DifficultyLevel difficultyLevel)
        {
            this.Name = name;
            this.Description = description;
            this.Instructions = instructions;
            this.Video = video;
            this.SetsInformation = setsInformation;
            this.DifficultyLevel = difficultyLevel;

            this.targetMuscleGroups = new HashSet<MuscleGroup>();
        }

        internal Exercise(
            string name,
            string description,
            string instructions,
            Video video,
            DifficultyLevel difficultyLevel)
        {
            this.Name = name;
            this.Description = description;
            this.Instructions = instructions;
            this.Video = video;
            this.DifficultyLevel = difficultyLevel;

            this.SetsInformation = default!;
            this.targetMuscleGroups = new HashSet<MuscleGroup>();
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Instructions { get; private set; }
        public Video Video { get; private set; }
        public IReadOnlyCollection<MuscleGroup> TargetMuscleGroups => this.targetMuscleGroups.ToList().AsReadOnly();
        public SetsInformation SetsInformation { get; private set; }
        public DifficultyLevel DifficultyLevel { get; private set; }
    }
}
