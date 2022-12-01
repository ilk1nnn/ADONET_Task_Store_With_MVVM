using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET_Task_Store_With_MVVM.Models
{
    public class Product : Entity
    {
		private string productName;

		public string ProductName
		{
			get { return productName; }
			set { productName = value; OnPropertyChanged(); }
		}

		private decimal price;

		public decimal Price
		{
			get { return price; }
			set { price = value; OnPropertyChanged(); }
		}


	}
}
