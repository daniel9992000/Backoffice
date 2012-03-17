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
        int columnToSort;
        SortOrder orderOfSort;
        CaseInsensitiveComparer objectCompare;

        public int SortColum
        {
            get
            {
                return columnToSort;
            }
            set
            {
                columnToSort = value;
            }
        }

        public SortOrder Order
        {
            get
            {
                return orderOfSort;
            }
            set
            {
                orderOfSort = value;
            }
        }

        public ColumnSorter()
        {
            this.columnToSort = 0;
            this.orderOfSort = SortOrder.None;
            this.objectCompare = new CaseInsensitiveComparer();
        }

        public int Compare(object x, object y)
        {
            int result;
            ListViewItem lvx, lvy;

            lvx = (ListViewItem)x;
            lvy = (ListViewItem)y;

            result = objectCompare.Compare(lvx.SubItems[columnToSort].Text, lvy.SubItems[columnToSort].Text);

            if (orderOfSort == SortOrder.Ascending)
            {
                return result;
            }
            else if (orderOfSort == SortOrder.Descending)
            {
                return (-result);
            }
            else
            {
                return 0;
            }

        }
    }
}
