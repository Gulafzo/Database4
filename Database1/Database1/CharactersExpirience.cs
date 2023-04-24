using System;
using System.Collections.Generic;
using System.Text;

namespace Database1
{
    public class CharactersExpirience
    {
        public int Id { get; set; }
        public int CharactersId { get; set; }
        public int Expirirence { get; set; }
        public int NextLevelExpririence { get; set; }
        public CharactersExpirience(int id, int charactersId, int expirience, int nextLevelExpiririence)
        {
            Id = id;
            CharactersId = charactersId;
            Expirirence = expirience;
            NextLevelExpririence = nextLevelExpiririence;
                
        }
    }
}
