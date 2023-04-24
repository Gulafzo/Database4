using System;
using System.Collections.Generic;
using System.Text;

namespace Database1
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Class(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
