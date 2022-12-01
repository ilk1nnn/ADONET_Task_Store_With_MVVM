using ADONET_Task_Store_With_MVVM.ViewModels;
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

namespace ADONET_Task_Store_With_MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var app_view_model = new AppViewModel();
            app_view_model.mainwindow = this;
            app_view_model.StartPrice = StartPriceTxtb;
            app_view_model.EndPrice = EndPriceTxtb;
            app_view_model.listview = products_listview;
            this.DataContext = app_view_model;
        }
    }
}
