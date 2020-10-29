using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet_3
{
    class Publication
    {
        public string Title { get; set; }
        public int Copies { get; set; }
        public double Price { get; set; }

        public int sellCopy(int amount)
        {
            Copies -= amount;
            return Copies;
        }

    }
}
