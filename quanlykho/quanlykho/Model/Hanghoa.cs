using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlykho.Model
{
    internal class Hanghoa
    {
        public string mahang;
        public string tenhang;
        public string loaihang;

        public Hanghoa()
        {

        }
        public Hanghoa(string mahang, string tenhang, string loaihang)
        {
            this.mahang = mahang;
            this.tenhang = tenhang;
            this.loaihang = loaihang;
        }
        public string getMahang() { return  mahang; }
        public string getTenhang() {  return tenhang; }
        public string getLoaihang() {  return loaihang; }
        public void setMahang(string mahang) {  this.mahang = mahang; }
        public void setTenhang(string tenhang) {  this.tenhang = tenhang; }
        public void setLoaihang(string loaihang) {  this.loaihang = loaihang;}
    }
}
