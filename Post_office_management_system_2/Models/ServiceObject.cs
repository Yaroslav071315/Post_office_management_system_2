using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_office_management_system_2.Models
{
    public abstract class ServiceObject
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public ServiceObject()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
