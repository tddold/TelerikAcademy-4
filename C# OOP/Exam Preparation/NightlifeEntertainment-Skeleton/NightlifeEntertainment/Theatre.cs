﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightlifeEntertainment
{
    public class Theatre : Performance
    {
        public Theatre(string name, decimal basePrice, IVenue venue, DateTime startTime)
            : base(name, basePrice, venue, startTime, PerformanceType.Theatre)
        {
        }

        protected override void ValidateVenue()
        {
            if (!this.Venue.AllowedTypes.Contains(PerformanceType.Theatre))
            {
                throw new InvalidOperationException(
                    string.Format("The venue {0} does not support the type of performance {1}", this.Venue.Name, this.Type));
            }
        }
    }
}
