namespace Collection_Assignment3_HashSet
{
    internal class Program
    {
        static void Main()
        {
            // Create HashSet for storing emails
            HashSet<string> emails = new HashSet<string>();

            // Add 10 emails (with duplicates)
            emails.Add("amit@gmail.com");
            emails.Add("neha@gmail.com");
            emails.Add("rahul@gmail.com");
            emails.Add("sneha@gmail.com");
            emails.Add("karan@gmail.com");
            emails.Add("amit@gmail.com");   // duplicate
            emails.Add("neha@gmail.com");   // duplicate
            emails.Add("pooja@gmail.com");
            emails.Add("rohit@gmail.com");
            emails.Add("anita@gmail.com");

            // Display unique emails
            Console.WriteLine("Unique Registered Emails:");
            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }

            // Check if a specific email is registered
            Console.WriteLine("\nCheck if 'rahul@gmail.com' is registered:");
            if (emails.Contains("rahul@gmail.com"))
            {
                Console.WriteLine("Email is registered.");
            }
            else
            {
                Console.WriteLine("Email not found.");
            }

            // Remove an email
            Console.WriteLine("\nRemoving 'karan@gmail.com'...");
            emails.Remove("karan@gmail.com");

            Console.WriteLine("\nAfter Removal:");
            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }

            // BONUS: Compare two event lists
            HashSet<string> event1 = new HashSet<string>()
        {
            "amit@gmail.com", "neha@gmail.com", "rahul@gmail.com"
        };

            HashSet<string> event2 = new HashSet<string>()
        {
            "rahul@gmail.com", "sneha@gmail.com", "neha@gmail.com"
        };

            // Find common participants
            event1.IntersectWith(event2);

            Console.WriteLine("\nCommon Participants in Both Events:");
            foreach (var email in event1)
            {
                Console.WriteLine(email);
            }
        }
    }
}
