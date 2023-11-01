using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlykho.Model
{
    internal class phieunhapkho
    {
        public string maphieunhapkho;
        public string ngaynhapkho;
        public string nguoigiaohang;
        public string sohoadon;
        public string ngayhoadon;
        public string donviphathanh;
        public string makho;
        public phieunhapkho()
        {

        }
        public phieunhapkho(string maphieunhapkho, string ngaynhapkho, string nguoigiaohang, string sohoadon, string ngayhoadon, string donviphathanh, string makho)
        {
            this.maphieunhapkho = maphieunhapkho;
            this.ngaynhapkho = ngaynhapkho;
            this.nguoigiaohang = nguoigiaohang;
            this.sohoadon = sohoadon;
            this.ngayhoadon = ngayhoadon;
            this.donviphathanh = donviphathanh;
            this.makho = makho;
        }
    }
}
