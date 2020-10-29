using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet_3
{
    class Magazine : Publication
    {
        public int CurrIssue { get; set; }
        public int OrderQty { get; set; }

        public void AdjustQty(int amount)
        {
            OrderQty = amount;
        }

        public void RecNewIssue()
        {
            CurrIssue++;
        }
    }
}
