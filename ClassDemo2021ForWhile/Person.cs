using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo2021ForWhile
{
    public class Person
    {
        private int _nummer;
        private String _navn;
        private String _tlf;

        public Person(int nummer, string navn, string tlf)
        {
            _nummer = nummer;
            _navn = navn;
            _tlf = tlf;
        }

        public Person()
        {
        }

        public int Nummer
        {
            get => _nummer;
            set => _nummer = value;
        }

        public string Navn
        {
            get => _navn;
            set => _navn = value;
        }

        public string Tlf
        {
            get => _tlf;
            set => _tlf = value;
        }

        public override string ToString()
        {
            return $"{nameof(Nummer)}: {Nummer}, {nameof(Navn)}: {Navn}, {nameof(Tlf)}: {Tlf}";
        }
    }
}
