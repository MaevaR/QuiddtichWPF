using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Coupe : EntityObject
    {
        private int _year;
        public String Libelle
        {
            get;
            set;
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public Coupe(int id) : base(id)
        {
        }

        public Coupe(int id, int year, String cup) : base(id)
        {
            _year = year;
            Libelle = cup;
        }

        public override String ToString()
        {
            return Year + " " + Libelle;
        }
    }

   
}
