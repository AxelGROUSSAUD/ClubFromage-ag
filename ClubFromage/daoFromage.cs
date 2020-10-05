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
        private daoPays _daoPays;

        public daoFromage(DBAL unDBAL, daoPays unDaoPays)
        {
            _DBAL = unDBAL;
            _daoPays = unDaoPays;
        }
        public void Insert(Fromage unFromage)
        {
            string query = "Fromage VALUES " + "(" + unFromage.getIdentifiant() + "," + unFromage.getIdPays() + ",'"+unFromage.getNom()+"','"+unFromage.getDureeAffinage()+"','"+unFromage.getDateCreation()+"','"+unFromage.getImage()+"','"+unFromage.getRecette()+"','"+unFromage.getHistoire()+"');";
            this._DBAL.Insert(query);
        }

        public void Update(Fromage unFromage)
        {
            string query = "Fromage SET identifiant = " + unFromage.getIdentifiant() + ", idPays = " + unFromage.getIdPays() + ", nom = '"+unFromage.getNom()+"' , DureeAffinage = '"+unFromage.getDureeAffinage()+"', DateCreation = '"+unFromage.getDateCreation()+"', image = '"+unFromage.getImage()+"', recette = '"+unFromage.getRecette()+"', histoire = '"+unFromage.getHistoire()+"' WHERE identifiant = " + unFromage.getIdentifiant() + " ;";
            this._DBAL.Update(query);
        }

        public void Delete(Fromage unFromage)
        {
            string query = "Fromage WHERE identifiant = " + unFromage.getIdentifiant() + ";";
            this._DBAL.Delete(query);
        }
    }
}
