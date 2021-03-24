using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoxingThemis.Models
{
    public class Round

    {
        [Key]
        public int Id { get; set; }
        public int Fighter1Score { get; set; }
        public int Fighter2Score { get; set; }
        public bool EffectiveAggression { get; set; }
        public bool RingGeneralship { get; set; }
        public bool Defense { get; set; }
        public bool HardandCleanPunches { get; set; }
        public int PointDeductionFighter1 { get; set; }
        public int PointDeductionFighter2 { get; set; }


    }
}
