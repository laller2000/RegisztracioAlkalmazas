using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    class Hobbi
    {
        string nev;
        DateTime szuletes;
        string nem;
        string ujhobbi;

        public Hobbi(string nev, DateTime szuletes, string nem, string ujhobbi)
        {
            this.Nev = nev;
            this.Szuletes = szuletes;
            this.Nem = nem;
            this.Ujhobbi = ujhobbi;
        }
        public Hobbi(string sor)
        {
            string[] s = sor.Split(' ');
            ujhobbi = s[0];
        }
        public string Nev { get => nev; set => nev = value; }
        public DateTime Szuletes { get =>szuletes; set => szuletes = value; }
        public string Nem { get => nem; set => nem = value; }
        public string Ujhobbi { get => ujhobbi; set => ujhobbi = value; }

        public override string ToString()
        {
            return ujhobbi;
        }
        public string Egysorba()
        {
            return string.Format($"{ujhobbi}");
        }
    }
}
