using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp2.Models
{
    public enum MenuItemType
    {
        Browse,
        TimeCard,
        About,
        Leave,
        Profile
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
