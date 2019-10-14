using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIPlaceholder;

namespace UIPlaceholderSample.ViewModel
{
    public class MainPageViewModel : GalaSoft.MvvmLight.ViewModelBase
    {
        private PlaceholderState _currentState = PlaceholderState.NoState;
        public PlaceholderState CurrentState
        {
            get
            {
                return _currentState;
            }
            set
            {
                Set(ref _currentState, value);
            }
        }


        public async void LoadDifferentStates()
        {
            CurrentState = PlaceholderState.Loading;

            await Task.Delay(TimeSpan.FromSeconds(5));

            CurrentState = PlaceholderState.NoState;
        }
    }
}
