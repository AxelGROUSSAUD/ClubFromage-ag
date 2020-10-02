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


        public Pays(int unIdPays , string unNomPays)
        {
            _idPays = unIdPays;
            _nom = unNomPays;

        }

        public int getIdPays()
        {
            return _idPays;

        }

        public string getNom()
        {
            return _nom;
        }

        public void setIdPays(int unIdPays)
        {
            _idPays = unIdPays;
        }

        public void setNom(string unNom)
        {
            _nom = unNom;
        }
    }
}
