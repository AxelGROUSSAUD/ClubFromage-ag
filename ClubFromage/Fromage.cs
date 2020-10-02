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
        private string _DureeAffinage;
        private string _DateCreation;
        private string _image;
        private string _recette;
        private string _histoire;

        public Fromage(int unIdentifiant,int unIdPays, string unNom, string uneDureeAffinage, string uneDateCreation,string uneRecette , string uneHistoire  )
        {
            _identifiant = unIdentifiant;
            _idPays = unIdPays;
            _nom = unNom;
            _DureeAffinage = uneDureeAffinage;
            _DateCreation = uneDateCreation;
            _image = "";
            _recette = uneRecette;
            _histoire = uneHistoire;

        }

        public int getIdentifiant()
        {
            return _identifiant;
        }

        public int getIdPays()
        {
            return _idPays;
        }

        public string getNom()
        {
            return _nom;
        }

        public string getDureeAffinage()
        {
            return _DureeAffinage;
        }

        public string getDateCreation()
        {
            return _DateCreation;
        }


        public string getImage()
        {
            return _image;
        }

        public string getRecette()
        {
            return _recette;
        }

        public string getHistoire()
        {
            return _histoire;
        }


        public void setIdentifiant(int unIdentifiant)
        {
            _identifiant = unIdentifiant;
        }

        public void setIdPays(int unIdPays)
        {
            _idPays = unIdPays;
        }

        public void setNom(string unNom)
        {
            _nom = unNom;
        }

        public void setDureeAffinage(string uneDureeAffinage)
        {
            _DureeAffinage = uneDureeAffinage;
        }

        public void setDateCreation(string uneDateCreation)
        {
            _DateCreation = uneDateCreation;
        }

        public void setImage(string uneImage)
        {
            _image = uneImage;
        }

        public void setRecette(string uneRecette)
        {
            _recette = uneRecette;
        }

        public void setHistoire(string uneHistoire)
        {
            _histoire = uneHistoire;
        }
    }
}
