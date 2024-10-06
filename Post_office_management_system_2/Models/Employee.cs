using System;
using Post_office_management_system_2.Models.Interfeces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_office_management_system_2.Models
{
    public class Employee : Client, IManageParcels, IManagePerson
    {
        // Employee can manage clients and parcels
        public List<Client> Clients { get; set; } = new List<Client>();
        // Foreign key to City
        public int PostOfficeId { get; set; }
        public PostOffice PostOffice { get; set; }
        public List<Parcel> GetAllParcels(List<Parcel> allParcels)
        {
            return allParcels;
        }

        public List<Client> GetClients()
        {
            return Clients;
        }
    }
}
