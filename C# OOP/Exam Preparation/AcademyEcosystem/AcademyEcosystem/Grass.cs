﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    public class Grass : Plant
    {
        private const int GrassSize = 2;

        public Grass(Point location)
            : base(location, Grass.GrassSize)
        {

        }

        public override void Update(int time)
        {
            if (this.IsAlive)
            {
                for (int i = 0; i < time; i++)
                {
                    this.Size++;
                }
            }
        }
    }
}
