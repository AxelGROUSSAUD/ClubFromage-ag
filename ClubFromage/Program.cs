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
            requetesql = "UPDATE Pays SET nom = 'Brezil' WHERE id=1 ;";
            //clubfromage.Update(requetesql);
            requetesql = "DELETE FROM Pays WHERE id = 3;";
            //clubfromage.Delete(requetesql);

            requetesql = "DELETE FROM Pays WHERE id = 25;";
            clubfromage.ExecQuery(requetesql);
        }
    }
}
