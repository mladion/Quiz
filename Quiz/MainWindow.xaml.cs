using Quiz.Helpers;
using Quiz.Models;
using Quiz.ViewModels;
using Quiz.Views;
using System.Windows;

namespace Quiz
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //btnNext.Visibility = Visibility.Collapsed;
        }
        private void EasyView_Clicked(object sender, RoutedEventArgs e)
        {
            //btnEasy.IsEnabled = false;
            //btnMedium.IsEnabled = false;
            //btnHard.IsEnabled = false;
            DataModelHelper.InitData(QuestionType.EasyQuestion);
            SetDataContext();
            //btnNext.Visibility = Visibility.Visible;
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            SetDataContext();
        }

        private void SetDataContext()
        {
            var question = DataModelHelper.GetNextQuestion();
            if (DataModelHelper.HasMultipleChoices)
            {
                DataContext = new MultipleChoicesViewModel(question);
            }
            else
            {
                DataContext = new SingleChoiceViewModel(question);
            }
        }
    }
}