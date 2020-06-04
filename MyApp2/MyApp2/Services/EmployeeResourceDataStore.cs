using MyApp2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp2.Services
{
    class EmployeeResourceDataStore
    {
        

        public EmployeeResourceDataStore()
        {

            List<EmployeeResources> employeeResources;
            employeeResources = new List<EmployeeResources>();
            var mockData = new List<EmployeeResources>
            {
                new EmployeeResources { Reminder="Reminder 1"},
                new EmployeeResources{ Reminder="Reminder 1"},
            };

            foreach (var item in mockData)
            {
                employeeResources.Add(item);
            }
        }

    }
}
