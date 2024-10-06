using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_office_management_system_2.Models
{
    public class City : ServiceObject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // One-to-many relationship with PostOffice
        public List<PostOffice> PostOffices { get; set; } = new List<PostOffice>();
    }
}
