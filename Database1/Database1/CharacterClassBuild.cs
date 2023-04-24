using System;
using System.Collections.Generic;
using System.Text;

namespace Database1
{
    internal class CharacterClassBuild
    {
        public int Id { get; set; }
        public int CharactersClassId { get; set; }
        public int SpellId { get; set; }
        public CharacterClassBuild(int id, int caracterClassId, int spellId)
        {
            Id = id;
            CharactersClassId = caracterClassId;
            SpellId = spellId;
        }
    }
}
