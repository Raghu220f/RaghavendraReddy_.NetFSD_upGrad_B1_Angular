namespace Collection_Assignment2_Dictionary
{
    internal class Program
    {
        static void Main()
        {
            // Create Dictionary
            Dictionary<int, Student> students = new Dictionary<int, Student>();

            // Add 5 Students
            students.Add(1, new Student(1, "Amit", 85));
            students.Add(2, new Student(2, "Neha", 72));
            students.Add(3, new Student(3, "Rahul", 90));
            students.Add(4, new Student(4, "Sneha", 65));
            students.Add(5, new Student(5, "Karan", 78));

            // Display All Students
            Console.WriteLine("All Students:");
            DisplayStudents(students);

            // Retrieve student by Id
            Console.WriteLine("\nRetrieve Student with Id = 3:");
            if (students.ContainsKey(3))
            {
                var s = students[3];
                Console.WriteLine($"Id: {s.Id}, Name: {s.Name}, Marks: {s.Marks}");
            }

            // Check if student exists
            Console.WriteLine("\nChecking if Student with Id = 2 exists:");
            Console.WriteLine(students.ContainsKey(2) ? "Exists" : "Not Found");

            // Update marks
            Console.WriteLine("\nUpdating Marks of Student Id = 2...");
            if (students.ContainsKey(2))
            {
                students[2].Marks = 88;
            }

            // Remove a student
            Console.WriteLine("\nRemoving Student with Id = 4...");
            students.Remove(4);

            // Display after update & delete
            Console.WriteLine("\nAfter Update & Removal:");
            DisplayStudents(students);

            // BONUS: Students with marks > 75
            Console.WriteLine("\nStudents with Marks > 75:");
            var toppers = students.Values.Where(s => s.Marks > 75);
            foreach (var s in toppers)
            {
                Console.WriteLine($"Id: {s.Id}, Name: {s.Name}, Marks: {s.Marks}");
            }
        }

        // Method to Display Students
        static void DisplayStudents(Dictionary<int, Student> students)
        {
            foreach (var s in students.Values)
            {
                Console.WriteLine($"Id: {s.Id}, Name: {s.Name}, Marks: {s.Marks}");
            }
        }
    }
}
