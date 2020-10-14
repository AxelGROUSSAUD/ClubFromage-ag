using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Data;
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
            unPays.Nom = "France";
            //undaoPays.Update(unPays);
            ///undaofromage.Insert(camenbert);

            //undaoPays.InsertByFile("D:\\Axel_Groussaud\\Projets.Exercices_visual_studio\\Club_Fromage\\ClubFromage\\pays.csv");

            /*DataSet mondataset = clubfromage.RQuery("SELECT * FROM Pays;");
            foreach (DataRow dtr in mondataset.Tables[0].Rows)
            {
                Console.WriteLine(dtr["nom"]);
            }*/
            /*DataTable unDataTableAll = clubfromage.SelectAll("Pays");
            foreach(DataRow dtr in unDataTableAll.Rows)
            {
                Console.WriteLine(dtr["nom"]);
            }*/
            //DataTable unDataTablebyfield = clubfromage.SelectByField("Pays", "nom LIKE 'G%';");
            //foreach (DataRow dtr in unDataTablebyfield.Rows)
            //{
            //    Console.WriteLine(dtr["nom"]);
            //}

            //Console.WriteLine(clubfromage.SelectById("Pays", 52)["nom"]);
            //List < Pays > unelistePays = undaoPays.SelectAll();
            //foreach (Pays p in unelistePays)
            //{
            //    Console.WriteLine(p.Nom);
            //}

            Console.WriteLine(undaoPays.SelectByName("Greece").IdPays +"   "+ undaoPays.SelectByName("Greece").Nom);
            Console.WriteLine(undaoPays.SelectById(15).IdPays + "   " + undaoPays.SelectById(15).Nom);
        }
    }
}
