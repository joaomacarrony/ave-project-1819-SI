using ConsoleApp1;
using Entities;
using Fixtr;
using System;
using System.Collections.Generic;
using System.Text;

namespace ave_project
{
    class App
    {
        public static void Main(string[] args)
        {
            IFixture fix = new FixtureReflect(typeof(Student));
            Student s1 = (Student)fix.New();
            Student s2 = (Student)fix.New();
        }
    }
}
