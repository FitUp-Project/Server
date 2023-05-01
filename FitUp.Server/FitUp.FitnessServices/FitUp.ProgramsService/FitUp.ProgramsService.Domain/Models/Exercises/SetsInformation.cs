namespace FitUp.ProgramsService.Domain.Models.Exercises
{
    using FitUp.Domain.Models;
    
    public class SetsInformation : ValueObject
    {
        internal SetsInformation(
            int setsNumber,
            int minimumReps,
            int maximumReps,
            TimeSpan? setDuration = null)
        {
            this.SetsNumber = setsNumber;
            this.MinimumReps = minimumReps;
            this.MaximumReps = maximumReps;
            this.SetDuration = setDuration;
        }

        public int SetsNumber { get; }
        public int MinimumReps { get; }
        public int MaximumReps { get; }
        public TimeSpan? SetDuration { get; }
    }
}
