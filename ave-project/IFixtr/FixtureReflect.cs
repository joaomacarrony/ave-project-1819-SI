using Fixtr;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ConsoleApp1
{

    class FixtureReflect : IFixture    
    {
        public Type TargetType { get; set; }

        private PropertyInfo[] properties;


        public FixtureReflect(Type t)
        {
            TargetType = t;
            properties = t.GetProperties();

        }

        public object[] Fill(int size)
        {
            throw new NotImplementedException();
        }

        public object New()
        {
            throw new NotImplementedException();
        }
    }
}
