using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace FlyoutTest.ViewModel
{
    public class TaskSetupFormViewModel : ViewModelBase
    {
        public ICommand CancelCommand { get { return new RelayCommand(CancelTaskSetup); } }

        private int _taskId;
        public int TaskId
        {
            get { return _taskId; }
            set { Set(() => TaskId, ref _taskId, value); }
        }

        private bool _isOpen;
        public bool IsOpen
        {
            get { return _isOpen; }
            set { Set(() => IsOpen, ref _isOpen, value); }
        }

        public TaskSetupFormViewModel()
        {
            IsOpen = false;
            TaskId = 123456;
        }

        private void CancelTaskSetup()
        {
            IsOpen = false;
        }
    }
}
