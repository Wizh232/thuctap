using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlykho.Model
{
    internal class Kho
    {
        public string makho;
        public string tenkho;
        public string diachi;

        public Kho() { }
        public Kho(String makho,String tenkho,String diachi) 
        {
            this.makho = makho;
            this.tenkho = tenkho;
            this.diachi = diachi;
        }
        public string getMakho() { return makho; }
        public string getTenkho() {  return tenkho; }   
        public string getDiachi() {  return diachi; }
        public void setMakho(string makho) { this.makho = makho; }
        public void setTenkho(string tenkho) { this.tenkho = tenkho; }
        public void setDiachi(string diachi) {  this.diachi = diachi;}
       
    }
}
