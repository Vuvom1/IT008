using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2._6
{
    internal class SinhvienBLL
    {
        LoadSinhvien svl;
        public SinhvienBLL()
        {
            svl = new LoadSinhvien();
        }

        public DataTable getlistSinhvien()
        {
            return svl.getlistSinhvien();
        }

        public bool InserSinhvien(Sinhvien sv)
        {
            return svl.InserSinhvien(sv);
        }
        public bool UpdateSinhvien(Sinhvien sv)
        {
            return svl.UpdateSinhvien(sv);
        }
        public bool DeleteSinhvien(Sinhvien sv)
        {
            return svl.DeleteSinhvien(sv);
        }
    }
}
