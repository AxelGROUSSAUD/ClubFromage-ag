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
            string query = "Fromage VALUES " + "(" + unFromage.Identifiant + "," + unFromage.IdPays + ",'"+unFromage.Nom+"','"+unFromage.DureeAffinage+"','"+unFromage.DateCreation+"','"+unFromage.Image+"','"+unFromage.Recette+"','"+unFromage.Histoire+"');";
            this._DBAL.Insert(query);
        }

        public void Update(Fromage unFromage)
        {
            string query = "Fromage SET identifiant = " + unFromage.Identifiant + ", idPays = " + unFromage.IdPays + ", nom = '"+unFromage.Nom+"' , DureeAffinage = '"+unFromage.DureeAffinage+"', DateCreation = '"+unFromage.DateCreation+"', image = '"+unFromage.Image+"', recette = '"+unFromage.Recette+"', histoire = '"+unFromage.Histoire+"' WHERE identifiant = " + unFromage.Identifiant + " ;";
            this._DBAL.Update(query);
        }

        public void Delete(Fromage unFromage)
        {
            string query = "Fromage WHERE identifiant = " + unFromage.Identifiant + ";";
            this._DBAL.Delete(query);
        }

        public List<Fromage> SelectAll()
        {
            List<Fromage> unelistefromage = new List<Fromage>();
            DataTable unDataTable = _DBAL.SelectAll("Fromage");
            foreach (DataRow dtr in unDataTable.Rows)
            {
                Fromage unFromage = new Fromage((int)dtr["identifiant"], (int)dtr["idPays"], (string)dtr["nom"],(DateTime)dtr["DureeAffinage"], (DateTime)dtr["DateCreation"], (string)dtr["image"], (string)dtr["recette"], (string)dtr["histoire"]);
                unelistefromage.Add(unFromage);
            }
            return unelistefromage;
        }

        public Fromage SelectByName(string name)
        {
            Fromage unFromage = new Fromage();
            DataTable unDataTable = _DBAL.SelectByField("Fromage", "nom = '" + name + "';");
            DataRow dtr = unDataTable.Rows[0];
            unFromage.Identifiant = (int)dtr["identifiant"];
            unFromage.IdPays = (int)dtr["idPays"];
            unFromage.Nom = (string)dtr["nom"];
            unFromage.DureeAffinage = (DateTime)dtr["DureeAffinage"];
            unFromage.DateCreation = (DateTime)dtr["DateCreation"];
            unFromage.Image = (string)dtr["image"];
            unFromage.Recette = (string)dtr["recette"];
            unFromage.Histoire = (string)dtr["histoire"];
            return unFromage;
        }

        public Fromage SelectById(int id)
        {
            Fromage unFromage = new Fromage();
            DataTable unDataTable = _DBAL.SelectByField("Fromage", "identifiant = '" + id + "';");
            DataRow dtr = unDataTable.Rows[0];
            unFromage.Identifiant = (int)dtr["identifiant"];
            unFromage.IdPays = (int)dtr["idPays"];
            unFromage.Nom = (string)dtr["nom"];
            unFromage.DureeAffinage = (DateTime)dtr["DureeAffinage"];
            unFromage.DateCreation = (DateTime)dtr["DateCreation"];
            unFromage.Image = (string)dtr["image"];
            unFromage.Recette = (string)dtr["recette"];
            unFromage.Histoire = (string)dtr["histoire"];
            return unFromage;
        }
    }

}

