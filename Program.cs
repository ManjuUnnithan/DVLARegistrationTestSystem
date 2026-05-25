using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DVLARegistrationTestSystem.Models;
using DVLARegistrationTestSystem.Services;



DVLARegistrationService service = new DVLARegistrationService();

Console.WriteLine("Feature 1");
Console.WriteLine($"Total Registrations: {service.GetTotalRegistrationCount()}");

Console.WriteLine();

Console.WriteLine("Feature 2");

string registrationNumber = "AB01 CDE";
int? vehicleId = service.GetVehicleId(registrationNumber);

Console.WriteLine(vehicleId.HasValue
    ? $"Vehicle ID for {registrationNumber}: {vehicleId}"
    : "No vehicle found.");
    



 