using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubFromage
{
    class daoPays
    {
        DBAL dbalpays = new DBAL();
        public void Insert(Pays unPays)
        {
            string query = "Pays VALUES " + "(" + unPays.getIdPays() + ",'" + unPays.getNom() + "');";
            dbalpays.Insert(query);
        }

        public void Update()
        {

        }

        public void Delete(Pays unPays)
        {
            string query = "Pays WHERE idPays = " + unPays.getIdPays()+";";
            dbalpays.Delete(query);
        }
    }
}
