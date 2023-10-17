using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1._1
{
    internal class Circle : Shape
    {
        public double radius {  get; set; }
        public override double CalculationArea()
        {
            return radius*radius*3.14;
        }

        public override void Nhap()
        {
            Console.Write("nhap vi tri: ");
            this.Location = double.Parse(Console.ReadLine());
            Console.Write("Nhap ban kinh: ");
            this.radius = double.Parse(Console.ReadLine());
        }

        public override void Draw()
        {
            Console.WriteLine("thong tin ve hinh tron: ");
            Console.WriteLine($"vi tri: {this.Location}");
            Console.WriteLine($"ban kinh: {this.radius}");
        }
    }
}
