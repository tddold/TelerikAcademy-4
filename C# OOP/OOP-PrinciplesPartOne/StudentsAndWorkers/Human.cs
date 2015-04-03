﻿
namespace StudentsAndWorkers
{
    using System;
    public abstract class Human
    {
        protected string firstName;
        protected string lastName;

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            protected set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name is too short");
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name is null or empty");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            protected set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name is too short");
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name is null or empty");
                }
                this.lastName = value;
            }
        }
    }
}