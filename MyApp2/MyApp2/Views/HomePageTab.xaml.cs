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

        public IList<EmployeeResources> empResourceReminders { get; private set; }
        public IList<EmployeeResources> empResourceLinks { get; private set; }
        public HomePageTab()
        {

            InitializeComponent();

            // ObservableCollection allows items to be added after ItemsSource
            // is set and the UI will react to changes

            empResourceReminders = new List<EmployeeResources>();
            empResourceLinks = new List<EmployeeResources>();

            empResourceReminders.Add(new EmployeeResources { Reminder = "You may have received a letter from BAS about Medicare part D coverage – this is a required notice and applies only to employees who are Medicare eligible or have a dependent who is Medicare eligible. If neither situation applies to you, please ignore the letter. If either yourself or your dependent are eligible for Medicare, please contact HR for further information." });

            empResourceReminders.Add(new EmployeeResources { Reminder = "For business travelers, beginning October 1, 2020, every traveler must present a REAL ID-compliant driver’s license, or another acceptable form of identification, to fly within the United States. Please check https://www.dhs.gov/real-id for more information." });

            empResourceLinks.Add(new EmployeeResources { Reminder = "4/16/2020 - NDTI COVID-19 Policy", Link= "https://esp21.ndti.net/files/NDTICoronavirusPolicy.pdf" });
            empResourceLinks.Add(new EmployeeResources{ Reminder = "4/15/2020 Covid-19 Update - Message from the NDTI CEO",Link= "https://esp21.ndti.net/files/covid19NDTICEOUpdate.pdf" });

            EmployeeRemindersView.ItemsSource = empResourceReminders;
            EmployeeLinksView.ItemsSource = empResourceLinks;

        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
              EmployeeResources tappedItem = e.Item as EmployeeResources;
            
                Device.OpenUri(new Uri(tappedItem.Link));
            
        }
    }

    
}