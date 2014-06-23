using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Practices.ServiceLocation;

namespace FlyoutTest.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand OpenFlyoutCommand { get { return new RelayCommand(() => TaskSetupForm.IsOpen = true);} }
        public ICommand BrokenOpenFlyoutCommand { get { return new RelayCommand(() => DummyViewModel.IsOpen = true);} }

        private TaskSetupFormViewModel _taskSetupForm;
        public TaskSetupFormViewModel TaskSetupForm
        {
            get { return _taskSetupForm; }
            set { _taskSetupForm = value; }
        }

        private DummyViewModel _dummyViewModel;
        public DummyViewModel DummyViewModel
        {
            get { return _dummyViewModel ?? (_dummyViewModel = ServiceLocator.Current.GetInstance<DummyViewModel>()); }
        }

        public MainViewModel(TaskSetupFormViewModel taskSetupForm)
        {
            TaskSetupForm = taskSetupForm;
        }
    }
}