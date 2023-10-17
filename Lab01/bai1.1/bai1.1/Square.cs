using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1._1
{
    internal class Square : Rectangle
    {
        public double Side {  get; set; }
        public override double CalculationArea()
        {
            return (Side * Side);
        }
        public override void Nhap()
        {
            Console.Write("Nhap vi tri: ");
            this.Location = double.Parse(Console.ReadLine());
            Console.Write("Nhap canh hinh vuong: ");
            this.Side = double.Parse(Console.ReadLine());
        }

        public override void Draw()
        {
            Console.WriteLine("thong tin ve hinh vuong: ");
            Console.WriteLine($"vi tri: {this.Location}");
            Console.WriteLine($"canh: {this.Side}");
        }
    }
}
