﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    public class Wolf : Animal, ICarnivore
    {
        private const int WolfSize = 4;

        public Wolf(string name, Point location)
            : base(name, location, Wolf.WolfSize)
        {

        }
        public int TryEatAnimal(Animal animal)
        {
            int eatenMeat = 0;
            if (animal != null)
            {
                if (animal.Size <= this.Size || animal.State == AnimalState.Sleeping)
                {
                    eatenMeat = animal.GetMeatFromKillQuantity();
                }
            }
            return eatenMeat;
        }
    }
}
