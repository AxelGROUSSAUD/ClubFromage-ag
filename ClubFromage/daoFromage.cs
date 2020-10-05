using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubFromage
{
    class daoFromage
    {
        private DBAL _DBAL;

        public daoFromage(DBAL unDBAL)
        {
            _DBAL = unDBAL;
        }
        public void Insert(Fromage unFromage)
        {
            string query = "Fromage VALUES " + "(" + unFromage.getIdentifiant() + "," + unFromage.getIdPays() + ",'"+unFromage.getNom()+"','"+unFromage.getDureeAffinage()+"','"+unFromage.getDateCreation()+"','"+unFromage.getImage()+"','"+unFromage.getRecette()+"','"+unFromage.getHistoire()+"');";
            this._DBAL.Insert(query);
        }

        public void Update()
        {

        }

        public void Delete(Fromage unFromage)
        {
            string query = "Fromage WHERE identifiant = " + unFromage.getIdentifiant() + ";";
            this._DBAL.Delete(query);
        }
    }
}
