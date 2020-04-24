﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicatieVanzariMasini_Back.Models
{
    public class PollutionRule
    {
        public int PollutionRuleId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Car> Cars { get; set; }

    }
}
