using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Assignment5_Queue
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Disease { get; set; }

        public Patient(int id, string name, string disease)
        {
            Id = id;
            Name = name;
            Disease = disease;
        }
    }
}
