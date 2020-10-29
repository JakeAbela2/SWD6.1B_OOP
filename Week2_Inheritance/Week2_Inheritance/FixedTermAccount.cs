﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance
{
    class FixedTermAccount : BankAccount
    {
        public double Days { get; set; }
        public void SetClosingDate()
        {
            ClosingDate = OpeningDate.AddDays(Days);
        }
    }
}
