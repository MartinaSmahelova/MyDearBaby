using System;
using System.Collections.Generic;
using System.Text;

namespace MyDearBaby
{
    public enum Gender
    {
        girl, 
        boy,
    }
    public class Child
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string ActualAge { get; set; }
        //public string ActualAge1 { get; set; }

        public Child(string name, Gender gender, DateTime dateOfBirth)
        {
            Name = name;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            ActualAge = CalculateActualAge(dateOfBirth);
            //ActualAge1 = CalculateYourAge(dateOfBirth);
        }

        public override string ToString()
        {
            return $"{Name}, {ActualAge}";
        }

        public string CalculateActualAge(DateTime dateofbirth)
        {
            DateTime now = DateTime.Now;
            TimeSpan tameSpan = now - dateofbirth;
            DateTime Age = DateTime.MinValue.AddDays(tameSpan.Days);
          
            if (Age.Year == 0)
            {
                return string.Format($"{Age.Month - 1} měsic(e/ů) {Age.Day - 1} den/dní(i)");
            }
            return string.Format($"{Age.Year - 1} rok(y/ů) {Age.Month - 1} měsic(e/ů) {Age.Day - 1} den/dní(i)");
        }

        public void ShowQuoteRelatedToChildhood()
        {

        }

        //static string CalculateYourAge(DateTime Dob)
        //{
        //    DateTime Now = DateTime.Now;
        //    int Years = new DateTime(DateTime.Now.Subtract(Dob).Ticks).Year - 1;
        //    DateTime PastYearDate = Dob.AddYears(Years);
        //    int Months = 0;
        //    for (int i = 1; i <= 12; i++)
        //    {
        //        if (PastYearDate.AddMonths(i) == Now)
        //        {
        //            Months = i;
        //            break;
        //        }
        //        else if (PastYearDate.AddMonths(i) >= Now)
        //        {
        //            Months = i - 1;
        //            break;
        //        }
        //    }
        //    int Days = Now.Subtract(PastYearDate.AddMonths(Months)).Days;
        //    int Hours = Now.Subtract(PastYearDate).Hours;
        //    int Minutes = Now.Subtract(PastYearDate).Minutes;
        //    int Seconds = Now.Subtract(PastYearDate).Seconds;

        //    return String.Format("Age: {0} Year(s) {1} Month(s) {2} Day(s) {3} Hour(s) {4} Second(s)",
        //    Years, Months, Days, Hours, Seconds);
        //}

        
    }
}
