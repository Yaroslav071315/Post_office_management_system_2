using Post_office_management_system_2.Models.Interfeces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_office_management_system_2.Models
{
    public class Client : ServiceObject, IManageParcels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gmail { get; set; }
        public string Phone { get; set; }

        // One-to-many relationship with Parcel
        public List<Parcel> Parcels { get; set; } = new List<Parcel>();

        public List<Parcel> GetUserParcels()
        {
            return Parcels;
        }
    }
}
