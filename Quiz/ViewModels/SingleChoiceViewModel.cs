using Quiz.Models;

namespace Quiz.ViewModels
{
    public class SingleChoiceViewModel : BaseChoiceViewModel
    {
        public SingleChoiceViewModel(QuestionAndAnswer questionAndAnswer)
            : base(questionAndAnswer)
        {
        }
    }
}
