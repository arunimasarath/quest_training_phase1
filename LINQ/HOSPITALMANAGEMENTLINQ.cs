using System;
using System.Linq;
using System.Collections.Generic;

class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string MedicalCondition { get; set; }
}

class Appointment
{
    public int Id { get; set; }
    public int PatientId { get; set; }
    public string DoctorName { get; set; }
    public DateTime AppointmentDate { get; set; }
    public string AppointmentType { get; set; }
}

class Program
{
    static void Main()
    {
        
        var patients = new List<Patient>
        {
            new Patient { Id = 1, Name = "John", Age = 65, MedicalCondition = "Diabetes" },
            new Patient { Id = 2, Name = "Jane", Age = 45, MedicalCondition = "Hypertension" },
            new Patient { Id = 3, Name = "Mike", Age = 72, MedicalCondition = "Asthma" }
        };

        var appointments = new List<Appointment>
        {
            new Appointment { Id = 1, PatientId = 1, DoctorName = "Dr. Smith", AppointmentDate = DateTime.Now.AddDays(5), AppointmentType = "Consultation" },
            new Appointment { Id = 2, PatientId = 2, DoctorName = "Dr. Lee", AppointmentDate = DateTime.Now.AddDays(6), AppointmentType = "Follow-up" },
            new Appointment { Id = 3, PatientId = 3, DoctorName = "Dr. Brown", AppointmentDate = DateTime.Now.AddDays(-25), AppointmentType = "Surgery" },
            new Appointment { Id = 4, PatientId = 1, DoctorName = "Dr. Smith", AppointmentDate = DateTime.Now.AddDays(-20), AppointmentType = "Follow-up" }
        };

        DateTime now = DateTime.Now;


            // 1. Patients with upcoming appointments within 7 days without using join
            var upcomingAppointments = patients
                .Where(p => appointments
                            .Any(a => a.PatientId == p.Id && a.AppointmentDate > now && a.AppointmentDate <= now.AddDays(7)))
                .Select(p => new { p.Name, p.Age, p.MedicalCondition });

            Console.WriteLine("Upcoming Appointments within 7 Days:");
            foreach (var item in upcomingAppointments)
                Console.WriteLine($"Name: {item.Name}, Age: {item.Age}, Medical Condition: {item.MedicalCondition}");


        // Group patients by MedicalCondition with upcoming appointments 
        var groupedByCondition = patients
            .Where(p => appointments.Any(a => a.PatientId == p.Id && a.AppointmentDate > now && a.AppointmentDate <= now.AddDays(7)))
            .GroupBy(p => p.MedicalCondition)
            .Select(g => new { MedicalCondition = g.Key, Count = g.Count() });

        Console.WriteLine("Patients Grouped by Medical Condition (Upcoming Appointments):");
        foreach (var group in groupedByCondition)
            Console.WriteLine($"{group.MedicalCondition}: {group.Count} patient(s)");


        // 3. Patients with most appointments in last 30 days 
        var mostAppointments = appointments
            .Where(a => a.AppointmentDate >= now.AddDays(-30) && a.AppointmentDate <= now)
            .GroupBy(a => a.PatientId)
            .OrderByDescending(g => g.Count())
            .Take(1) 
            .SelectMany(g => patients
                             .Where(p => p.Id == g.Key)
                             .Select(p => new { p.Name, Appointments = g.Count() }));

        Console.WriteLine("Patients with Most Appointments in Last 30 Days:");
        foreach (var item in mostAppointments)
            Console.WriteLine($"{item.Name}: {item.Appointments} appointments");

        // 4. Patients over 60 with most recent appointment 
        var recentAppointmentsForSeniors = patients
            .Where(p => p.Age > 60)
            .Select(p => new
            {
                p.Name,
                MostRecentAppointment = appointments
                    .Where(a => a.PatientId == p.Id)
                    .OrderByDescending(a => a.AppointmentDate)
                    .FirstOrDefault()
            })
            .Where(result => result.MostRecentAppointment != null);

        Console.WriteLine("Patients Over 60 with Most Recent Appointment:");
        foreach (var item in recentAppointmentsForSeniors)
        {
            var appt = item.MostRecentAppointment;
            Console.WriteLine($"{item.Name}: {appt.DoctorName}, {appt.AppointmentDate}, {appt.AppointmentType}");
        }








    }

    }
