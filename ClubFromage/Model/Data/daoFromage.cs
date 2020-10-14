using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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

        public List<Fromage> SelectAll()
        {
            List<Fromage> unelistefromage = new List<Fromage>();
            DataTable unDataTable = _DBAL.SelectAll("Pays");
            foreach (DataRow dtr in unDataTable.Rows)
            {
                Fromage unFromage = new Fromage();
                unelistefromage.Add(unFromage);
            }
            return unelistefromage;
        }

        public Pays SelectByName(string namePays)
        {
            Pays unPays = new Pays();
            DataTable unDataTable = _DBAL.SelectByField("Pays", "nom = '" + namePays + "';");
            DataRow dtr = unDataTable.Rows[0];
            unPays.IdPays = int.Parse(dtr["idPays"].ToString());
            unPays.Nom = dtr["nom"].ToString();
            return unPays;
        }

        public Pays SelectById(int idPays)
        {
            Pays unPays = new Pays();
            DataTable unDataTable = _DBAL.SelectByField("Pays", "idPays = '" + idPays + "';");
            DataRow dtr = unDataTable.Rows[0];
            unPays.IdPays = int.Parse(dtr["idPays"].ToString());
            unPays.Nom = dtr["nom"].ToString();
            return unPays;
        }
    }

}
}
