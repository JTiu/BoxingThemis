using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoxingThemis.Models
{
    public class BoxingMatch
    {
        [Key]
        public int Id { get; set; }
        public string FighterName1 { get; set; }
        public string FighterName2 { get; set; }
        //List<Round> Rounds { get; set; } revisit after more thought
        public bool Fighter1Won { get; set; }
        public int Fighter1TotalScore { get; set; }
        public int Fighter2TotalScore { get; set; }
        public string YouTubeLink { get; set; }
    }
}
