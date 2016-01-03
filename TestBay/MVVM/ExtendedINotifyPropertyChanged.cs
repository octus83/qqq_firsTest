using System;
using System.ComponentModel;
using System.Diagnostics;

namespace TestBay.MVVM
{
    /// <summary>
    /// Extends the INotifyPropertyChanged Interface
    /// It checks if the given Property is real and public
    /// </summary>
    public abstract class ExtendedINotifyPropertyChanged : INotifyPropertyChanged
    {
        #region Fields

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Methods

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            var handler = this.PropertyChanged;

            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected void RaisePropertyChanged(String propertyName)
        {
            VerifyPropertyName(propertyName);
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        [Conditional("DEBUG")]
        [DebuggerStepThrough]
        public void VerifyPropertyName(String propertyName)
        {
            // verify that the property name matches a real,  
            // public, instance property on this Object.
            if (TypeDescriptor.GetProperties(this)[propertyName] == null)
            {
                Debug.Fail("Invalid property name: " + propertyName);
            }
        }

        #endregion
    }
}
