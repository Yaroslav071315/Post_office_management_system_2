using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_office_management_system_2.Models.Interfeces
{
    public interface IManageParcels
    {
        List<Parcel> GetUserParcels();
    }
}
