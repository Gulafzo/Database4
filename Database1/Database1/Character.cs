using System;
using System.Collections.Generic;
using System.Text;

namespace Database1
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClassId { get; set; }
        public Character(int id, string name, int classid)
        {
            Id = id;
            Name = name;
            ClassId = classid;
        }
    }
}
