using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubFromage
{
    class Pays
    {
        private int _idPays;
        private string _nom;


        public Pays()
        {
            _idPays = 0;
            _nom = "";
        }


        public Pays(int unIdPays , string unNomPays)
        {
            _idPays = unIdPays;
            _nom = unNomPays;

        }

        public int IdPays { get => _idPays; set => _idPays = value; }


        public string Nom { get => _nom; set => _nom = value; }


    }
}
