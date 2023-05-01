namespace FitUp.ProgramsService.Domain.Models.Workouts
{
    using FitUp.Domain.Models;
    
    public class WorkoutType : ValueObject
    {
        internal WorkoutType(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public string Name { get; }
        public string Description { get; }
    }
}
