using LessonSchedulePlanner.Models.Lesson;
using System.Collections.Generic;

namespace LessonSchedulePlanner.Services.Lesson
{
    public class LessonService : ILessonService
    {
        public IList<LessonModel> GetLessonsByDate()
        {
            return new List<LessonModel>
            {
                new LessonModel(),
                new LessonModel(),
                new LessonModel(),
                new LessonModel(),
                new LessonModel(),
                new LessonModel(),
                new LessonModel(),
                new LessonModel(),
                new LessonModel(),
                new LessonModel(),
                new LessonModel(),
                new LessonModel(),
                new LessonModel(),
                new LessonModel(),
            };
        }
    }

    public interface ILessonService
    {
        IList<LessonModel> GetLessonsByDate();
    }
}
