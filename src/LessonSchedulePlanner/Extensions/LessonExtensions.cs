using LessonSchedulePlanner.Models.Lesson;

namespace LessonSchedulePlanner.Extensions
{
    public static class LessonExtensions
    {
        public static LessonViewModel ToViewModel(this LessonModel model)
        {
            return new LessonViewModel();
        }
    }
}
