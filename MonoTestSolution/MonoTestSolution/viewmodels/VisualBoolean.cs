namespace MonoTestSolution.viewmodels
{
    public class VisualBoolean: BaseViewModel
    {

        public VisualBoolean()
        {

        }
        public bool _isLoading;
        public bool IsLoading
        {
            get { return _isLoading; }
            set
            {
                SetValue(ref _isLoading, value);
                OnPropertyChanged(nameof(IsLoading));
            }
        }
    }
    
}
