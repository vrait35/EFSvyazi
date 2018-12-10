using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFRelationshipLesson
{
    public class Player
    {
        public int Id { get; set; }
        public string FullNamw { get; set; }
        public int Number { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
