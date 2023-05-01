namespace FitUp.ExercisesService.Domain.Models.MuscleGroup
{
    using FitUp.Domain.Models;

    public class MuscleGroup : BaseEntity<int>
    {
        internal MuscleGroup(string name, string description, List<byte[]> images)
        {
            this.Name = name;
            this.Description = description;
            this.Images = images;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public List<byte[]> Images { get; private set; }
    }
}
