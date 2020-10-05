using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubFromage
{
    class daoPays
    {
        private DBAL _DBAL;

        public daoPays(DBAL unDBAL)
        {
            _DBAL = unDBAL;
        }
        public void Insert(Pays unPays)
        {
            string query = "Pays VALUES " + "(" + unPays.getIdPays() + ",'" + unPays.getNom() + "');";
            this._DBAL.Insert(query);
        }

        public void Update(Pays unPays)
        {
            string query = "Pays SET idPays = " + unPays.getIdPays() + ", nom = '" + unPays.getNom() + "' WHERE idPays = " + unPays.getIdPays()+" ;";
            this._DBAL.Update(query);
        }

        public void Delete(Pays unPays)
        {
            string query = "Pays WHERE idPays = " + unPays.getIdPays()+";";
            this._DBAL.Delete(query);
        }
    }
}
