namespace FitUp.ExercisesService.Domain.Models.Exercise
{
    using Shared.Models;

    public class Video : ValueObject
    {
        internal Video(string title, byte[] content)
        {
            this.Title = title;
            this.Content = content;
        }

        public string Title { get; }
        public byte[] Content { get; }
    }
}
