using System;
using System.Collections.Generic;
using System.Text;

namespace assingment4
{
    internal class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
