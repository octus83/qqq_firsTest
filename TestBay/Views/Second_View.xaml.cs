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
    /// Interaktionslogik für Second_View.xaml
    /// </summary>
    public partial class Second_View : ViewBase
    {
        #region Properties


        #endregion

        #region Constructor

        public Second_View()
        {
            InitializeComponent();
        }

        #endregion

        public static new string GetViewName()
        {
            return "SecondView2";
        }
    }
}
