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

        public IList<EmployeeResources> empResource { get; private set; }
        public HomePageTab ()
        {

            InitializeComponent();

            // ObservableCollection allows items to be added after ItemsSource
            // is set and the UI will react to changes
            
        empResource = new List<EmployeeResources>();
        
        empResource.Add(new EmployeeResources { Reminder = "You may have received a letter from BAS about Medicare part D coverage – this is a required notice and applies only to employees who are Medicare eligible or have a dependent who is Medicare eligible. If neither situation applies to you, please ignore the letter. If either yourself or your dependent are eligible for Medicare, please contact HR for further information." });

            empResource.Add(new EmployeeResources { Reminder = "For business travelers, beginning October 1, 2020, every traveler must present a REAL ID-compliant driver’s license, or another acceptable form of identification, to fly within the United States. Please check https://www.dhs.gov/real-id for more information." });
            
            EmployeeLinksView.ItemsSource = empResource; 

        }

        
    }

    
}