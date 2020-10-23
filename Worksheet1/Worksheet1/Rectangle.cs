﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet1
{
    class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double RectArea()
        {
            return Length * Width;
        }

        public double RectPerimeter()
        {
            return (2 * Length) + (2 * Width);
        }
    }
}
