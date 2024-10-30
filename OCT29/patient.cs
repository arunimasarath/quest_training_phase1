using System;
using System.Collections.Generic;
using log4net;
using log4net.Config;

namespace PatientManagementSystem
{
    public class Program
    {
        
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
           
            XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));
            var patientService = new PatientService();

            while (true)
            {
                Console.WriteLine("\nPatient Management System");
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. Search Patient");
                Console.WriteLine("3. Update Patient");
                Console.WriteLine("4. Delete Patient");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    switch (option)
                    {
                        case 1:
                            AddPatient(patientService);
                            break;
                        case 2:
                            SearchPatient(patientService);
                            break;
                        case 3:
                            UpdatePatient(patientService);
                            break;
                        case 4:
                            DeletePatient(patientService);
                            break;
                        case 5:
                            log.Info("Exiting the application.");
                            return;
                        default:
                            Console.WriteLine("Invalid option. Please select a number between 1 and 5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }

        private static void AddPatient(PatientService patientService)
        {
            Console.Write("Enter Patient ID: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Console.Write("Enter Patient Name: ");
                string name = Console.ReadLine();
                patientService.AddPatient(new Patient { Id = id, Name = name });
            }
            else
            {
                Console.WriteLine("Invalid Patient ID. Please enter a valid numeric ID.");
            }
        }

        private static void SearchPatient(PatientService patientService)
        {
            Console.Write("Enter Patient ID to search: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Patient patient = patientService.SearchPatient(id);
                if (patient != null)
                {
                    Console.WriteLine($"Patient found: ID={patient.Id}, Name={patient.Name}");
                }
                else
                {
                    Console.WriteLine("Patient not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Patient ID. Please enter a valid numeric ID.");
            }
        }

        private static void UpdatePatient(PatientService patientService)
        {
            Console.Write("Enter Patient ID to update: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Console.Write("Enter New Name: ");
                string newName = Console.ReadLine();
                if (patientService.UpdatePatient(id, newName))
                {
                    Console.WriteLine("Patient updated successfully.");
                }
                else
                {
                    Console.WriteLine("Patient not found for update.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Patient ID. Please enter a valid numeric ID.");
            }
        }

        private static void DeletePatient(PatientService patientService)
        {
            Console.Write("Enter Patient ID to delete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                if (patientService.DeletePatient(id))
                {
                    Console.WriteLine("Patient deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Patient not found for deletion.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Patient ID. Please enter a valid numeric ID.");
            }
        }
    }

    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class PatientService
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(PatientService));
        private readonly List<Patient> patients = new List<Patient>();

        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
            Console.WriteLine($"Patient added: {patient.Name} (ID: {patient.Id})");
            log.Info($"Patient added: {patient.Name} (ID: {patient.Id})");
        }

        public Patient SearchPatient(int id)
        {
            return patients.Find(p => p.Id == id);
        }

        public bool UpdatePatient(int id, string newName)
        {
            var patient = SearchPatient(id);
            if (patient != null)
            {
                patient.Name = newName;
                log.Info($"Patient updated: {patient.Name} (ID: {patient.Id})");
                return true;
            }
            return false;
        }

        public bool DeletePatient(int id)
        {
            var patient = SearchPatient(id);
            if (patient != null)
            {
                patients.Remove(patient);
                log.Info($"Patient deleted: {patient.Name} (ID: {patient.Id})");
                return true;
            }
            return false;
        }
    }
}

