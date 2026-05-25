using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLARegistrationTestSystem.Models
{
    public class DVLARegistrationModel
    {
        public string RegistrationNo { get; }
        public int Year { get; }
        public int? VehicleId { get; }

        public DVLARegistrationModel(string registrationNo, int year, int? vehicleId = null)
        {
            RegistrationNo = registrationNo;
            Year = year;
            VehicleId = vehicleId;
        }
    }
}
