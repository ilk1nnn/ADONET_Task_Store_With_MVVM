using ADONET_Task_Store_With_MVVM.Commands;
using ADONET_Task_Store_With_MVVM.Models;
using ADONET_Task_Store_With_MVVM.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ADONET_Task_Store_With_MVVM.ViewModels
{
    public class AppViewModel : BaseViewModel
    {
        private List<Product> products;

        public List<Product> Products
        {
            get { return products; }
            set { products = value; OnPropertyChanged(); }
        }

        public RelayCommand CloseCommand { get; set; }
        public MainWindow mainwindow { get; set; }
        public TextBox StartPrice { get; set; }
        public TextBox EndPrice { get; set; }
        public ListView listview { get; set; }
        public RelayCommand AscendingCommand { get; set; }
        public RelayCommand DescendingCommand { get; set; }
        public RelayCommand DefaultViewCommand { get; set; }
        public RelayCommand SearchCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }



        public AppViewModel()
        {
            CloseCommand = new RelayCommand(c =>
            {
                mainwindow.Close();
            });

            AscendingCommand = new RelayCommand(a =>
            {
                Products = Products.OrderBy(e => e.Price).ToList();
            });

            DescendingCommand = new RelayCommand(d =>
            {
                Products = Products.OrderByDescending(e => e.Price).ToList();
            });

            DefaultViewCommand = new RelayCommand(dv =>
            {
                Products = ProductRepository.RepoProducts;
            });

            SearchCommand = new RelayCommand(s =>
            {
                decimal start_price = decimal.Parse(StartPrice.Text);
                decimal end_price = decimal.Parse(EndPrice.Text);
                Products = Products.Where(p => p.Price > start_price && p.Price < end_price).ToList();
            });

            DeleteCommand = new RelayCommand(deletion =>
            {
                var product = listview.SelectedItem as Product;
                ProductRepository.DeleteProductByID(product.Id);
                ProductRepository.GetAllProducts();
                Products = ProductRepository.RepoProducts;

            });






            ProductRepository.GetAllProducts();
            Products = ProductRepository.RepoProducts;
        }


    }
}
