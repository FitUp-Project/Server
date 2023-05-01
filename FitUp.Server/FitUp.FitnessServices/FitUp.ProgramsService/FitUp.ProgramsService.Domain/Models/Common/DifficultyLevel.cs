namespace FitUp.ProgramsService.Domain.Models.Common
{
    using FitUp.Domain.Models;

    public class DifficultyLevel : Enumeration
    {
        public static readonly DifficultyLevel Beginner = new DifficultyLevel(1, nameof(Beginner));
        public static readonly DifficultyLevel Intermidate = new DifficultyLevel(1, nameof(Intermidate));
        public static readonly DifficultyLevel Advanced = new DifficultyLevel(1, nameof(Advanced));

        private DifficultyLevel(int value)
            : this(value, FromValue<DifficultyLevel>(value).Name)
        {
        }

        private DifficultyLevel(int value, string name)
            : base(value, name)
        {
        }
    }
}
