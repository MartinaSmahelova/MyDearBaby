using System;
using System.Collections.Generic;
using System.Text;

namespace MyDearBaby
{
    public class Child
    {
        public int Id { get; set; }
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
                    return string.Format($"{Age.Day - 1} {ValidateDateInflection(Age)}");
                }

                return string.Format($"{Age.Month - 1} {ValidateMonthInflection(Age)} {Age.Day - 1} {ValidateDateInflection(Age)}");
            }

            return string.Format($"{Age.Year - 1} {ValidateYearInflection(Age)} {Age.Month - 1} {ValidateMonthInflection(Age)} {Age.Day - 1} {ValidateDateInflection(Age)}");
        }

        public string ValidateDateInflection(DateTime Age)
        {
            if ((Age.Day - 1) == 1)
            {
                return "den";
            }
            else if ((Age.Day - 1) > 1 && (Age.Day - 1) < 4)
            {
                return "dny";
            }

            else if ((Age.Day - 1) > 4)
            {
                return "dní";
            }

            return "";
        }

        public string ValidateMonthInflection(DateTime Age)
        {
            if ((Age.Month - 1) == 1)
            {
                return "měsíc";
            }
            else if ((Age.Month - 1) > 1 && (Age.Month - 1) < 4)
            {
                return "měsíce";
            }

            else if ((Age.Month - 1) > 4)
            {
                return "měsíců";
            }

            return "";
        }

            public string ValidateYearInflection(DateTime Age)
            {
                if ((Age.Year - 1)== 1)
                {
                    return "rok";
                }
                else if ((Age.Year - 1) > 1 && (Age.Year - 1) < 4)
                {
                    return "roky";
                }

                else if ((Age.Year - 1) > 4)
                {
                    return "roků";
                }

                return "";
            }
        
        public void ShowQuoteRelatedToChildhood()
        {

        }
    }
}
