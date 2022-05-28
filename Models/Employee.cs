using System;
using System.Collections.Generic;

#nullable disable

namespace APIAPI
{
    public partial class Employee
    {
        public Employee()
        {
            Schedules = new HashSet<Schedule>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
