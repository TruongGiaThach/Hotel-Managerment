using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.dataComu
{
    class DSKhachHang
    {
        private static DSKhachHang instance;

        public static DSKhachHang Instance
        {
            get { if (instance == null) instance = new DSKhachHang(); return DSKhachHang.instance; }
            private set => instance = value;
        }
        private DSKhachHang() { }
    }
}
