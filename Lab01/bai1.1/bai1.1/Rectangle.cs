using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1._1
{
    internal class Rectangle : Shape
    {
        public double Width {  get; set; }
        public double Height {  get; set; }
        
        public override double CalculationArea()
        {
            return (Width * Height);
        }

        public override void Nhap()
        {
            Console.Write("nhap vi tri: ");
            this.Location = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu dai: ");
            this.Width = double.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong: ");
            this.Height = double.Parse(Console.ReadLine());
        }

        public override void Draw()
        {
            Console.WriteLine("thong tin ve hinh chu nhat: ");
            Console.WriteLine($"vi tri: {this.Location}");
            Console.WriteLine($"chieu dai: {this.Width}");
            Console.WriteLine($"chieu rong: {this.Height}");
        }
    }
}
