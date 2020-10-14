using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubFromage
{
    class Fromage
    {
        private int _identifiant;
        private int _idPays;
        private string _nom;
        private DateTime _DureeAffinage;
        private DateTime _DateCreation;
        private string _image;
        private string _recette;
        private string _histoire;

        public Fromage(int unIdentifiant,int unIdPays, string unNom, DateTime uneDureeAffinage, DateTime uneDateCreation,string uneImage ,string uneRecette , string uneHistoire  )
        {
            _identifiant = unIdentifiant;
            _idPays = unIdPays;
            _nom = unNom;
            _DureeAffinage = uneDureeAffinage;
            _DateCreation = uneDateCreation;
            _image = uneImage;
            _recette = uneRecette;
            _histoire = uneHistoire;

        }

        public Fromage()
        {
            _identifiant = 0;
            _idPays = 0;
            _nom = "";
            _DureeAffinage = new DateTime();
            _DateCreation = new DateTime();
            _image = "";
            _recette = "";
            _histoire = "";
        }


        public int Identifiant { get => _identifiant; set => _identifiant = value; }

        public int IdPays { get => _idPays; set => _idPays = value; }

        public string Nom { get => _nom; set => _nom = value; }

        public DateTime DureeAffinage { get => _DureeAffinage; set => _DureeAffinage = value; }

        public DateTime DateCreation { get => _DateCreation; set => _DateCreation = value; }

        public string Image { get => _image; set => _image = value; }

        public string Recette { get => _recette; set => _recette = value; }

        public string Histoire { get => _histoire; set => _histoire = value; }
    }
}
