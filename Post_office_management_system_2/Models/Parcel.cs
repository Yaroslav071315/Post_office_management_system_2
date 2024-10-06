using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_office_management_system_2.Models
{
    public class Parcel : ServiceObject
    {
        public int Weight { get; set; }
        public DateTime DateSend { get; set; }
        public DateTime DateCome { get; set; }
        public decimal Price { get; set; }

        // FK для PostOfficeSend
        public int PostOfficeId { get; set; } // Foreign key
        public PostOffice PostOfficeSend { get; set; }

        [NotMapped]
        public PostOffice PostOfficeCome { get; set; }


        public int ClientId { get; set; } // Foreign key for Client
        public Client Client { get; set; }

    }
}
