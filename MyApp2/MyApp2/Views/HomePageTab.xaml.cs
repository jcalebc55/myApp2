using MyApp2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp2.Views
{
       
    


    public partial class HomePageTab : TabbedPage
    {
        ObservableCollection<EmployeeResources> ers = new ObservableCollection<EmployeeResources>();
        public ObservableCollection<EmployeeResources> EmpResource { get { return ers; } }


        public HomePageTab ()
        {

            InitializeComponent();

            // ObservableCollection allows items to be added after ItemsSource
            // is set and the UI will react to changes
            ers.Add(new EmployeeResources { Reminder = "Rob Finnerty" });
            ers.Add(new EmployeeResources { Reminder = "Bill Wrestler" });
            ers.Add(new EmployeeResources { Reminder = "Dr. Geri-Beth Hooper" });
            ers.Add(new EmployeeResources { Reminder = "Dr. Keith Joyce-Purdy" });
            ers.Add(new EmployeeResources { Reminder = "Sheri Spruce" });
            ers.Add(new EmployeeResources { Reminder = "Burt Indybrick" });

            EmployeeResourceView.ItemsSource = ers;


        }
    }
}