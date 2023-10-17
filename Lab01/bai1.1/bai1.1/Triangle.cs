using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1._1
{
    internal class Triangle : Shape
    {
        public double Height {  get; set; }
        public double Base {  get; set; }
        public override double CalculationArea()
        {
            return 1 / 2 * Height * Base;
        }

        public override void Nhap()
        {
            Console.Write("nhap vi tri: ");
            this.Location = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu cao: ");
            this.Height = double.Parse(Console.ReadLine());
            Console.Write("Nhap do dai canh day: ");
            this.Base = double.Parse(Console.ReadLine());
        }

        public override void Draw()
        {
            Console.WriteLine("thong tin ve hinh tam giac: ");
            Console.WriteLine($"vi tri: {this.Location}");
            Console.WriteLine($"chieu cao: {this.Height}");
            Console.WriteLine($"canh day: {this.Base}");
        }
    }
}
