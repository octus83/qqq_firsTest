using System;
using System.Windows.Input;
using TestBay.MVVM;
using TestBay.Views;

namespace TestBay.ViewModels
{
    public class ViewModelBase : ExtendedINotifyPropertyChanged
    {
        #region Fields

        private ViewBase _ViewToShow;

        #endregion

        #region Properties

        /// <summary>
        /// The View to Show. Bind this to a Content-Control to show the Content.
        /// <see cref="ViewBase.cs"/>
        /// </summary>
        public ViewBase ViewToShow
        {
            get
            {
                return _ViewToShow;
            }
            set
            {
                _ViewToShow = value;
                RaisePropertyChanged("ViewToShow");
            }
        }

        #endregion

        #region Commands

        #region SwitchView

        private void SwitchViewExecute(String viewName)
        {
            if(viewName.Equals(First_View.GetViewName()))
            {
                ViewToShow = new First_View();
            }
            else if (viewName.Equals(Second_View.GetViewName()))
            {
                ViewToShow = new Second_View();
            }
        }

        private bool CanSwitchViewExecute(String viewName)
        {
            if (String.IsNullOrWhiteSpace(viewName))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// To Switch the View. Accepts the Name of the View as String.
        /// </summary>
        public ICommand SwitchView
        {
            get
            {
                return new RelayCommand<String>(SwitchViewExecute, CanSwitchViewExecute);
            }
        }

        #endregion

        #endregion     
    }
}
