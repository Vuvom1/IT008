using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1._1
{
    internal abstract class Shape
    {
        public string Name {  get; set; }
        public double Location {  get; set; }
        public abstract double CalculationArea();
        public abstract void Nhap();
        public abstract void Draw();
    }
}
