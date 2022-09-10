using Prism.Mvvm;
using Quiz.Helpers;
using Quiz.Models;
using Quiz.Views;
using System.Windows;
using System.Windows.Input;

namespace Quiz.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {

        private string m_name;
        public string Name
        {
            get => m_name;
            set => SetProperty(ref m_name, value);
        }

        public ICommand ButtonEasy { get; set; }

        public MainWindowViewModel()
        {
            this.ButtonEasy = new RelayCommand(ExecuteEasyCommand, CanExecuteEasyCommand);
        }

        public bool CanExecuteEasyCommand(object parameter)
        {
            return true;
        }

        public void ExecuteEasyCommand(object parameter)
        {
            DataModelHelper.InitData(QuestionType.EasyQuestion);
            SetDataContext();
        }

        private void SetDataContext()
        {
            var question = DataModelHelper.GetNextQuestion();
            if (DataModelHelper.HasMultipleChoices)
            {
                //this.DataContext = new MultipleChoicesViewModel(question);
            }
            else
            {
                //DataContext = new SingleChoiceViewModel(question);
            }
        }
    }
}
