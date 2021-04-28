using System;
using System.Collections.Generic;
using System.Text;

namespace MyDearBaby
{
    public enum Gender
    {
        empty,
        girl, 
        boy,
    }
    public class Child
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string ActualAge { get; set; }

        public Child(string name, Gender gender, DateTime dateOfBirth)
        {
            Name = name;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            ActualAge = CalculateActualAge(dateOfBirth);
        }

        public override string ToString()
        {
            return $"{Name}, {ActualAge}";
        }

        public string CalculateActualAge(DateTime dateofbirth)
        {
            DateTime now = DateTime.Now;
            TimeSpan tameSpan = now - dateofbirth;

            if (dateofbirth > now)
            {
                return string.Format($"Miminko se ještě nenarodilo, je teprv na ceste");
            }

            DateTime Age = DateTime.MinValue.AddDays(tameSpan.Days);

            if ((Age.Year - 1) == 0)
            {
                if ((Age.Month - 1) == 0)
                {
                    return string.Format($"{Age.Day - 1} den/dní(i)");
                }

                return string.Format($"{Age.Month - 1} měsic(e/ů) {Age.Day - 1} den/dní(i)");
            }

            return string.Format($"{Age.Year - 1} rok(y/ů) {Age.Month - 1} měsic(e/ů) {Age.Day - 1} den/dní(i)");
        }

        public void ShowQuoteRelatedToChildhood()
        {

        }
    }
}
