using System;
using System.Collections.Generic;
using System.Text;

namespace MyDearBaby
{
    public class Enjoyment
    {
        public List<String> ListOfEnjoymentsCategories { get; set; }
        public List<Child> ListOfChildren { get; set; }
        public string ActualDate { get; set; }
        public string EnjoymentText { get; set; }

        public Enjoyment(List<Child> listOfChildren, List<string> listOfenjoymentsCategories, string enjoyment)
        {
            ActualDate = ShowActualDate();
            ListOfChildren = listOfChildren;
            ListOfEnjoymentsCategories = listOfenjoymentsCategories;
            EnjoymentText = enjoyment;
        }

        public string ShowActualDate()
        {
            //toDO: https://docs.microsoft.com/cs-cz/dotnet/api/system.globalization.cultureinfo.invariantculture?view=net-5.0
            //      https://docs.microsoft.com/cs-cz/dotnet/api/system.globalization.cultureinfo.createspecificculture?view=net-5.0
            //lbl_actualDate.Text = DateTime.Parse(input, invC, DateTimeStyles.RoundtripKind);

            return DateTime.Now.ToString("dd/MM/yyyy hh:mm");
        }

        public override string ToString()
        {
            return $"--------------------------------------------------------------------- \n" +
                   $"{ActualDate} \n" +
                   $"{String.Join("\n", ListOfChildren)} \n" +
                   $"{String.Join("\n", ListOfEnjoymentsCategories)} \n" +
                   $"{EnjoymentText}";
        }

    }
}
