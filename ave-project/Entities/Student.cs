using System;

namespace Entities
{
    class Student
    {
        public Student(int nr, string name, School school)
        {
            this.Nr = nr;
            this.Name = name;
            this.School = school;
        }

        public int Nr { get; set; }
        public string Name { get; set; }
        public School School { get; set; }
        public Address Address { get; set; } = new Address("default address");
        public string naturality="portuguese";
        public override string ToString()
        {
            return "Name: " + Name + ", Number: " + Nr + ", School: " + School.ToString() + ", Address: " + Address.ToString() + ", Naturality: " + naturality; 
        }
    }
}
