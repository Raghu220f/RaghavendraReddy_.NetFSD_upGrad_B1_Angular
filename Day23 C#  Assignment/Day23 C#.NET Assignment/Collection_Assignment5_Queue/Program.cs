namespace Collection_Assignment5_Queue
{
    internal class Program
    {
        static void Main()
        {
            // Create Queue
            Queue<Patient> patientQueue = new Queue<Patient>();

            // Add 5 Patients
            patientQueue.Enqueue(new Patient(1, "Amit", "Fever"));
            patientQueue.Enqueue(new Patient(2, "Neha", "Cold"));
            patientQueue.Enqueue(new Patient(3, "Rahul", "Headache"));
            patientQueue.Enqueue(new Patient(4, "Sneha", "Flu"));
            patientQueue.Enqueue(new Patient(5, "Karan", "Injury"));

            // Display all patients
            Console.WriteLine("All Patients in Queue:");
            DisplayPatients(patientQueue);

            // Serve (Dequeue) 2 Patients
            Console.WriteLine("\nServing 2 Patients...");
            for (int i = 0; i < 2; i++)
            {
                if (patientQueue.Count > 0)
                {
                    var served = patientQueue.Dequeue();
                    Console.WriteLine($"Served: {served.Name}");
                }
            }

            // Display next patient
            Console.WriteLine("\nNext Patient:");
            if (patientQueue.Count > 0)
            {
                var next = patientQueue.Peek();
                Console.WriteLine($"{next.Name} - {next.Disease}");
            }

            // Show remaining patients
            Console.WriteLine("\nRemaining Patients:");
            DisplayPatients(patientQueue);
        }

        static void DisplayPatients(Queue<Patient> queue)
        {
            foreach (var p in queue)
            {
                Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Disease: {p.Disease}");
            }
        }
    }
}
