using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so hinh muon tao: ");
            int NumberShape = int.Parse(Console.ReadLine());

            Shape[] shapes = new Shape[NumberShape];

            for(int i =0;i< NumberShape;i++)
            {
                Random random = new Random();
                int RandomNumber = random.Next(1, 5);

                switch(RandomNumber)
                {
                    case 1:
                        shapes[i] = new Circle();
                        shapes[i].Name = "hinh tron";
                        Console.WriteLine(shapes[i].Name);
                        shapes[i].Nhap();
                        Console.WriteLine($"dien tich cua hinh tron la: {shapes[i].CalculationArea()}");
                        shapes[i].Draw();
                        break;

                    case 2:
                        shapes[i] = new Rectangle();
                        shapes[i].Name = "hinh chu nhat";
                        Console.WriteLine(shapes[i].Name);
                        shapes[i].Nhap();
                        Console.WriteLine($"dien tich cua hinh chu nhat la: {shapes[i].CalculationArea()}");
                        shapes[i].Draw();
                        break;
                        
                    case 3:
                        shapes[i] = new Square();
                        shapes[i].Name = "hinh vuong";
                        Console.WriteLine(shapes[i].Name);
                        shapes[i].Nhap();
                        Console.WriteLine($"dien tich cua hinh vuong la: {shapes[i].CalculationArea()}");
                        shapes[i].Draw();
                        break;

                    case 4:
                        shapes[i] = new Triangle();
                        shapes[i].Name = "hinh tam giac";
                        Console.WriteLine(shapes[i].Name);
                        shapes[i].Nhap();
                        Console.WriteLine($"dien tich cua hinh tam giac la: {shapes[i].CalculationArea()}");
                        shapes[i].Draw();
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
