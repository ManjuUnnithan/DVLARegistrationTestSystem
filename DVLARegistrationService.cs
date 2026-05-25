using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLARegistrationTestSystem.Models;

namespace DVLARegistrationTestSystem.Services
{
    public class DVLARegistrationService
    {
        private readonly Dictionary<string, DVLARegistrationModel> registrations;
        public DVLARegistrationService()
        {
            registrations = new Dictionary<string, DVLARegistrationModel>
            {
                { "AB01 CDE", new DVLARegistrationModel("AB01 CDE", 2001, 12345) },
                { "FG02 HJK", new DVLARegistrationModel("FG02 HJK", 2002, 67890) },
                { "L33T H4X0R", new DVLARegistrationModel("L33T H4X0R", 2022) }
            };
        }

        public void AddRegistration(DVLARegistrationModel duplicateRegistration)
        {
            throw new NotImplementedException();
        }

        // Feature 1
        public int GetTotalRegistrationCount()
        {
            return registrations.Count;
        }
        // Feature 2

        public int? GetVehicleId(string registrationNumber)
        {   
            if(string.IsNullOrWhiteSpace(registrationNumber))
            {
                throw new ArgumentException("Registration number cannot be null or empty.", nameof(registrationNumber));
            }
            else if (registrations.TryGetValue(registrationNumber, out DVLARegistrationModel registration))
            {
                return registration.VehicleId;
            }
            return null;
            
                
        }
       
    }
}

