using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_07_J_doga
{
    internal class Verseny
    {
        public string Name { get; set; }
        public int szuletesiev { get; set; }
        public int rajtszam { get; set; }
        public string nem { get; set; }
        public string evkategoria { get; set; }
        public TimeSpan UszasIdeje { get; set; }
        public TimeSpan elsodepobantoltottido { get; set; }
        public TimeSpan kerekparozasideje { get; set; }
        public TimeSpan masodikdepobantoltottido { get; set; }
        public TimeSpan futasideje { get; set; }
       
    }
}
