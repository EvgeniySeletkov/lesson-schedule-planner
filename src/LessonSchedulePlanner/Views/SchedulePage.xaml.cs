using System.Collections.Generic;

namespace LessonSchedulePlanner.Views
{
    public partial class SchedulePage : BaseContentPage
    {
        public SchedulePage()
        {
            InitializeComponent();

            list.ItemsSource = new List<string>
            {
                "string",
                "string",
                "string",
                "string",
                "string",
                "string",
                "string",
                "string",
            };
        }
    }
}