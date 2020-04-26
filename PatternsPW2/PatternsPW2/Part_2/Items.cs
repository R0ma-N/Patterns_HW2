using PatternsPW2.Part_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsPW2.Part_2
{
    class Clothes : IItem, IColor, ISize
    {
        public void SetSize(Size size) { ;}
    }

    class Book : IItem, IBookDescription
    {

    }

    class Car : IItem, IColor, ISize, ISpecifications
    {
        public void SetSize(Size size) {; }
        public void SetSpecifications(Specifications specifications){ ;}
    }
}
