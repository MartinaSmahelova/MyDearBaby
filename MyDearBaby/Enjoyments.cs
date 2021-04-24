using System;
using System.Collections.Generic;
using System.Text;

namespace MyDearBaby
{
    public class Enjoyments
    {
        public List<String> ListOfEnjoymentsCategories { get; set; }
        //public List<String> ListOfEnjoyments { get; set; }
        public List<Child> ListOfChildren { get; set; }
        public string ActualDate { get; set; }

        public Enjoyments()
        {
         
        }

        public string ShowActualDate()
        {
            //toDO: https://docs.microsoft.com/cs-cz/dotnet/api/system.globalization.cultureinfo.invariantculture?view=net-5.0
            //      https://docs.microsoft.com/cs-cz/dotnet/api/system.globalization.cultureinfo.createspecificculture?view=net-5.0
            //lbl_actualDate.Text = DateTime.Parse(input, invC, DateTimeStyles.RoundtripKind);

            return DateTime.Now.ToString("dd/MM/yyyy hh:mm");
        }

        public void AddEnjoyment()
        {

        }

        public void AddEnjoymentCategory()
        {

        }

        public void ShowEnjoymentsRelatedToConcreteChild()
        {

        }

        public void ShowEnjoymentsRelatedToCategory()
        {

        }

        public void ShowEnjoymentsRelatedToKeyWord()
        {

        }

    }
}
