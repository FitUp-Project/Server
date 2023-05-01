namespace FitUp.ExercisesService.Domain.Models.Exercises
{
    using Models.Exercise;
    using Models.MuscleGroup;
    using Shared.Models;

    public class Exercise : DeletableEntity<int>
    {
        private readonly HashSet<MuscleGroup> focusingMuscleGroups;

        internal Exercise(
            string name,
            string description,
            string instruction,
            Video video,
            DifficultyLevel difficultyLevel)
        {
            this.Name = name;
            this.Description = description;
            this.Instruction = instruction;
            this.Video = video;
            this.DifficultyLevel = difficultyLevel;

            this.focusingMuscleGroups = new HashSet<MuscleGroup>();
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Instruction { get; private set; }
        public Video Video { get; private set; }
        public DifficultyLevel DifficultyLevel { get; private set; }
        public IReadOnlyCollection<MuscleGroup> MuscleGroups
            => focusingMuscleGroups.ToList().AsReadOnly();
    }
}
