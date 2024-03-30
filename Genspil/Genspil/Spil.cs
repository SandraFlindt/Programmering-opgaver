using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genspil
{
    internal class Spil
    {
        string _name;
        string _condition;
        string _genre;
        int _price;

        public Spil(string name, string condition, string genre, int price) 
        {
            _name = name;
            _condition = condition;
            _genre = genre;
            _price = price;
        }

        public string Getname() { return _name; }
        public string Getcondition() { return _condition;}
        public string Getgenre() { return _genre;}
        public int Getprice() { return _price;}
    }

}
