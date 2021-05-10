using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace MyDearBaby
{
    public static class FormToolsHelpers
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

        public static void ShowListInListView<T>(List<T> list, ListView listView)
        {
            if (list != null)
            {
                foreach (var item in list)
                {
                    listView.Items.Add(item.ToString());
                }
            }
        }

        public static void ShowListInRichTextBox<T>(List<T> list, RichTextBox richTextBox)
        {
            if (list != null)
            {
                foreach (var item in list)
                {
                    richTextBox.Text += item.ToString() + " \n";
                }
            }
        }

        public static void RemoveCheckedListBoxCheckedItemsFromList<T>(List<T> list, CheckedListBox checkedListBox)
        {
            list.Clear();

            IEnumerable<object> notChecked = (from object item in checkedListBox.Items
                                              where !checkedListBox.CheckedItems.Contains(item)
                                              select item);

            foreach (object item in notChecked)
            {
                list.Add((T)item);
            }
        }
    }
}
