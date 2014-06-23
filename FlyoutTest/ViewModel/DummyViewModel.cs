using GalaSoft.MvvmLight;

namespace FlyoutTest.ViewModel
{
    public class DummyViewModel : ViewModelBase
    {
        private bool _isOpen;
        public bool IsOpen
        {
            get { return _isOpen; }
            set { _isOpen = value; }
        }
    }
}
