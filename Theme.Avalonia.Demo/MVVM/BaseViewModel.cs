using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Theme.Avalonia.Demo.MVVM
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void RaisePropertyChanged<T>(ref T property, T newValue, [CallerMemberName] string propertyName = "")
        {
            property = newValue;
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void RaisePropertyChanged<T>(ref T property, T newValue, Action callbackMethod, bool callbackAfterPropChanged = true, [CallerMemberName] string propertyName = "")
        {
            if (!callbackAfterPropChanged)
            {
                callbackMethod?.Invoke();
            }

            this.RaisePropertyChanged(ref property, newValue, propertyName);
            if (callbackAfterPropChanged)
            {
                callbackMethod?.Invoke();
            }
        }

        protected void RaisePropertyChanged<T>(ref T property, T newValue, Action<T> callbackMethod, bool callbackAfterPropChanged = true, [CallerMemberName] string propertyName = "")
        {
            if (!callbackAfterPropChanged)
            {
                callbackMethod?.Invoke(newValue);
            }

            this.RaisePropertyChanged(ref property, newValue, propertyName);
            if (callbackAfterPropChanged)
            {
                callbackMethod?.Invoke(newValue);
            }
        }
    }
}
