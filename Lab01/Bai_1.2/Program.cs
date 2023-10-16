using System;


public class PhanSo : IComparable<PhanSo>
{
    private int tuSo;
    private int mauSo;

    public PhanSo(int tuSo, int mauSo)
    {
        if (mauSo == 0)
            throw new ArgumentException("Mau so khong the bang 0.");

        this.tuSo = tuSo;
        this.mauSo = mauSo;
    }

    public int CompareTo(PhanSo ps)
    {
        double giaTriPhanSo1 = (double)tuSo / mauSo;
        double giaTriPhanSo2 = (double)ps.tuSo / ps.mauSo;

        if (giaTriPhanSo1 < giaTriPhanSo2)
            return -1;
        else if (giaTriPhanSo1 > giaTriPhanSo2)
            return 1;
        else
            return 0;
    }

    public static PhanSo operator +(PhanSo ps1, PhanSo ps2)
    {
        int tuSoMoi = ps1.tuSo * ps2.mauSo + ps2.tuSo * ps1.mauSo;
        int mauSoMoi = ps1.mauSo * ps2.mauSo;
        return new PhanSo(tuSoMoi, mauSoMoi);
    }

    public static PhanSo operator -(PhanSo ps1, PhanSo ps2)
    {
        int tuSoMoi = ps1.tuSo * ps2.mauSo - ps2.tuSo * ps1.mauSo;
        int mauSoMoi = ps1.mauSo * ps2.mauSo;
        return new PhanSo(tuSoMoi, mauSoMoi);
    }

    public static PhanSo operator *(PhanSo ps1, PhanSo ps2)
    {
        int tuSoMoi = ps1.tuSo * ps2.tuSo;
        int mauSoMoi = ps1.mauSo * ps2.mauSo;
        return new PhanSo(tuSoMoi, mauSoMoi);
    }

    public static PhanSo operator /(PhanSo ps1, PhanSo ps2)
    {
        int tuSoMoi = ps1.tuSo * ps2.mauSo;
        int mauSoMoi = ps1.mauSo * ps2.tuSo;
        return new PhanSo(tuSoMoi, mauSoMoi);
    }

    public static bool operator ==(PhanSo ps1, PhanSo ps2)
    {
        double giaTriPhanSo1 = (double)ps1.tuSo / ps1.mauSo;
        double giaTriPhanSo2 = (double)ps2.tuSo / ps2.mauSo;

        return giaTriPhanSo1 == giaTriPhanSo2;
    }

    public static bool operator !=(PhanSo ps1, PhanSo ps2)
    {
        double giaTriPhanSo1 = (double)ps1.tuSo / ps1.mauSo;
        double giaTriPhanSo2 = (double)ps2.tuSo / ps2.mauSo;

        return giaTriPhanSo1 != giaTriPhanSo2;
    }

    public static bool operator <(PhanSo ps1, PhanSo ps2)
    {
        double giaTriPhanSo1 = (double)ps1.tuSo / ps1.mauSo;
        double giaTriPhanSo2 = (double)ps2.tuSo / ps2.mauSo;

        return giaTriPhanSo1 < giaTriPhanSo2;
    }

    public static bool operator >(PhanSo ps1, PhanSo ps2)
    {
        double giaTriPhanSo1 = (double)ps1.tuSo / ps1.mauSo;
        double giaTriPhanSo2 = (double)ps2.tuSo / ps2.mauSo;

        return giaTriPhanSo1 > giaTriPhanSo2;
    }

    public override string ToString()
    {
        if (mauSo == 1)
            return tuSo.ToString();

        return $"{tuSo}/{mauSo}";
    }



    public static implicit operator PhanSo(int soNguyen)
    {
        return new PhanSo(soNguyen, 1);
    }

    public static explicit operator double(PhanSo ps)
    {
        return (double)ps.tuSo / ps.mauSo;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        PhanSo ps1 = new PhanSo(1, 2);
        PhanSo ps2 = new PhanSo(3, 4);

        PhanSo cong = ps1 + ps2;
        PhanSo tru = ps1 - ps2;
        PhanSo nhan = ps1 * ps2;
        PhanSo chia = ps1 / ps2;

        Console.WriteLine($"Tong: {cong}");
        Console.WriteLine($"Hieu: {tru}");
        Console.WriteLine($"Tich: {nhan}");
        Console.WriteLine($"Thuong: {chia}");

        Console.WriteLine($"Phan so 1 == Phan so 2: {ps1 == ps2}");
        Console.WriteLine($"Phan so 1 != Phan so 2: {ps1 != ps2}");

        Console.WriteLine($"Phan so 1 < Phan so 2: {ps1 < ps2}");
        Console.WriteLine($"Phan so 1 > Phan so 2: {ps1 > ps2}");

        int intValue = 5;
        PhanSo psInt = intValue;
        Console.WriteLine($"Phan so tu so nguyen: {psInt}");

        PhanSo ps3 = new PhanSo(5, 2);
        double doubleValue = (double)ps3;
        Console.WriteLine($"So thuc tu phan so: {doubleValue}");

        PhanSo[] ArrPS = { new PhanSo(3, 4), new PhanSo(1, 2), new PhanSo(5, 8) };
        Array.Sort(ArrPS);
        Console.WriteLine("Phan so sau khi sap xep:");
        foreach (PhanSo phanso in ArrPS)
        {
            Console.WriteLine(phanso);
        }
    }

}



