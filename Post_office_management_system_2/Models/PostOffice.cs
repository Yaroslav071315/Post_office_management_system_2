using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_office_management_system_2.Models
{
    public class PostOffice : ServiceObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        // One-to-many relationship with Parcel
        public List<Parcel> Parcels { get; set; } = new List<Parcel>();

        // One-to-one relationship with HeadPostOffice
        public HeadPostOffice HeadPostOffice { get; set; }

        // One-to-many relationship with Employee
        public List<Employee> Employees { get; set; } = new List<Employee>();

        // Foreign key to City
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
