using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class Kangelane
    {
        private string _Nimi;
        private string _SuperNimi;
        private string _V6ime;
        private string _Asukoht;


        public Kangelane(string Nimi, string Asukoht, string SuperNimi, string V6ime)
        {
            _Nimi = Nimi;
            _Asukoht = Asukoht;
            _SuperNimi = SuperNimi;
            _V6ime = V6ime;
            
        }

        public string Nimi { get => _Nimi; set => _Nimi = value; }
        public string Asukoht { get => _Asukoht; set => _Asukoht = value; }
        public string SuperNimi { get => _SuperNimi; set => _SuperNimi = value; }
        public string V6ime { get => _V6ime; set => _V6ime = value; }
        
        public virtual int Päästa(int Ohustatuid)
        {
            return (int)Math.Round(Ohustatuid * .95);
        }
        public override string ToString()
        {
            return Nimi + " hoiab " + Asukoht + " turvalisena. " + "Ta võime on" + V6ime ;
        }
    }
}
