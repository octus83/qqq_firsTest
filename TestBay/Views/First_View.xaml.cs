using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestBay.Views
{
    /// <summary>
    /// Interaktionslogik für First_View.xaml
    /// </summary>
    public partial class First_View : ViewBase
    {
        #region Constructor

        public First_View()
        {
            InitializeComponent();
        }

        #endregion

        public static new string GetViewName()
        {
            return "FirstView";
        }
    }
}
