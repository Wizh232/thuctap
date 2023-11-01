using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlykho.Model
{
    internal class ctphieunhap
    {
        public string machitietphieunhap;
        public string maphieu;
        public string mahang;
        public string tenhang;
        public string donvitinh;
        public int soluong;
        public float dongia;
        public ctphieunhap() { }
        public ctphieunhap(string machitietphieunhap, string maphieu, string mahang, string tenhang, string donvitinh, int soluong, float dongia)
        {
            this.machitietphieunhap = machitietphieunhap;
            this.maphieu = maphieu;
            this.mahang = mahang;
            this.tenhang = tenhang;
            this.donvitinh = donvitinh;
            this.soluong = soluong;
            this.dongia = dongia;
        }
    }
}
