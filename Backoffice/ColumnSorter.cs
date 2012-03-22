using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Backoffice
{
    class ColumnSorter : IComparer
    {
        int col;
        SortOrder order;

        public ColumnSorter(int col, SortOrder order)
        {
            this.col = col;
            this.order = order;
        }

        public int Compare(object x, object y)
        {
            ListViewItem item1, item2;

            item1 = (ListViewItem)x;
            item2 = (ListViewItem)y;

            if (this.order == SortOrder.Ascending)
                return item1.SubItems[col].Text.CompareTo(item2.SubItems[col].Text);
            else
                return item2.SubItems[col].Text.CompareTo(item1.SubItems[col].Text);

        }
    }
}
