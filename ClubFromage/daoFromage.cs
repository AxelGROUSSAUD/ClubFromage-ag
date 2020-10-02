using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubFromage
{
    class daoFromage
    {
        DBAL dbalfromage = new DBAL();
        public void Insert(Fromage unFromage)
        {
            string query = "Fromage VALUES " + "(" + unFromage.getIdentifiant() + "," + unFromage.getIdPays() + ",'"+unFromage.getNom()+"','"+unFromage.getDureeAffinage()+"','"+unFromage.getDateCreation()+"','"+unFromage.getImage()+"','"+unFromage.getRecette()+"','"+unFromage.getHistoire()+"');";
            dbalfromage.Insert(query);
        }

        public void Update()
        {

        }

        public void Delete(Fromage unFromage)
        {
            string query = "Fromage WHERE identifiant = " + unFromage.getIdentifiant() + ";";
            dbalfromage.Delete(query);
        }
    }
}
