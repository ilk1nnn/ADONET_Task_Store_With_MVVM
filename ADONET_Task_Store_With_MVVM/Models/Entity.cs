using ADONET_Task_Store_With_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ADONET_Task_Store_With_MVVM.Models
{
    
        public class Entity : BaseViewModel
        {
            private int id;

            public int Id
            {
                get { return id; }
                set { id = value; OnPropertyChanged(); }
            }

        }
}
