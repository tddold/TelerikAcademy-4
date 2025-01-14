﻿
namespace FurnitureManufacturer.Models
{
    using System;
    using FurnitureManufacturer.Interfaces;
    public class Chair : Furniture, IChair
    {
        private int numberOfLegs;
        public Chair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }
        public int NumberOfLegs
        {
            get 
            {
                return this.numberOfLegs;
            }
            private set
            {
                this.numberOfLegs = value;
            }
        }

        public override string ToString()
        {
            string chairToString = string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}", 
                this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.NumberOfLegs);
            return chairToString;
        }
    }
}
