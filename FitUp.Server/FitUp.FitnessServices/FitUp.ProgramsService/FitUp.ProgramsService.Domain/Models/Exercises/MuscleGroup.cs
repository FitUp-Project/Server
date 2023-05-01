namespace FitUp.ProgramsService.Domain.Models.Exercises
{
    using FitUp.Domain.Models;

    public class MuscleGroup : BaseEntity<int>
    {
        internal MuscleGroup(string name, string description, List<byte[]> images)
        {
            Name = name;
            Description = description;
            Images = images;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public List<byte[]> Images { get; private set; }
    }
}
