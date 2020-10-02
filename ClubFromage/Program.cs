using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubFromage
{
    class Program
    {
        static void Main(string[] args)
        {
            DBAL clubfromage = new DBAL();
            string requetesql;
            
            //clubfromage.Insert(requetesql);
            requetesql = "SELECT * FROM Pays;";
            //clubfromage.Select(requetesql);
            requetesql = " Pays SET nom = 'Brezil' WHERE id=1 ;";
            //clubfromage.Update(requetesql);
            requetesql = " Pays WHERE idPays = 1;";
            //clubfromage.Delete(requetesql);

            requetesql = " Pays VALUES (1,'France');";
            requetesql = "SELECT * FROM Pays;";
            requetesql = " Pays SET nom = 'Brezil' WHERE idPays=1 ;";
            requetesql = " Pays WHERE idPays = 1;";
            clubfromage.Delete(requetesql);
        }
    }
}
