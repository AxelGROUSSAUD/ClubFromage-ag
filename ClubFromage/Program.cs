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
            //clubfromage.Delete(reque
            Pays unPays = new Pays(4, "Belgique");
            daoPays undaoPays = new daoPays(clubfromage);
            daoFromage undaofromage = new daoFromage(clubfromage, undaoPays);
            //undaoPays.Insert(unPays);
            //DateTime unedate = new DateTime(0 , 0 , 0,15,0,0);
            //DateTime uneautredate = new DateTime(2000, 5, 25);
            //Console.WriteLine(unedate);
            ///DateTime DureeAffinage = new DateTime(0, 0, 0, 15, 0, 0);
            ///DateTime DateCreation = new DateTime(2000, 5, 25);
            ///Fromage camenbert = new Fromage(15, 4, "camenbert", DureeAffinage,DateCreation, "le lait ...", "un laitier ...");
            //undaoPays.Delete(unPays);
            unPays.setNom("France");
            undaoPays.Update(unPays);
            ///undaofromage.Insert(camenbert);

            undaoPays.InsertByFile("D:\\Axel_Groussaud\\Projets.Exercices_visual_studio\\ClubFromage\\ClubFromage\\bin\\Debug\\pays.csv");
        }
    }
}
