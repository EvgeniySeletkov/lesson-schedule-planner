using LessonSchedulePlanner.Extensions;
using LessonSchedulePlanner.Models.Lesson;
using LessonSchedulePlanner.Services.Lesson;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LessonSchedulePlanner.ViewModels
{
    public class SchedulePageViewModel : BaseViewModel
    {
        private readonly ILessonService _lessonService;

        public SchedulePageViewModel()
        {
            _lessonService = new LessonService();

            var lessons = _lessonService.GetLessonsByDate();

            Lessons = lessons.Select(s => s.ToViewModel()).ToList();
        }

        private List<LessonViewModel> _lessons;
		public List<LessonViewModel> Lessons
		{
			get => _lessons;
			set => SetProperty(ref _lessons, value);
		}

        private ICommand _addLessonTapCommand;
        public ICommand AddLessonTapCommand => _addLessonTapCommand ??= new AsyncDelegateCommand(OnAddLessonTappedCommand);

        private async Task OnAddLessonTappedCommand()
        {
            
        }
    }
}
