using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MyDearBaby
{
    public static class FormToolsExtensions
    {
        public static void ShowListInCheckedListBox<T>(List<T> list, CheckedListBox checkedListBox)
        {
            if (list != null)
            {
                foreach (var item in list)
                {
                    checkedListBox.Items.Add(item);
                }
            }
        }
    }
}
