using System;
using System.Collections.Generic;
using System.Text;

namespace Database1
{
    internal class Expirience
    {
        public int Id { get; set; }
        public int CurrentLevel { get; set; }
        public int NextLevelExpirience { get; set; }
        public Expirience(int id, int currentLevel, int nextLevelExpirience)
        {
            Id = id;
            CurrentLevel = currentLevel;
            NextLevelExpirience = nextLevelExpirience;



              

        }
    }
}
