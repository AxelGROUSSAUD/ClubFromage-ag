using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;
using Ubiety.Dns.Core.Records;
using System.Data;

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
            string query = "Pays VALUES " + "(" + unPays.IdPays + ",'" + unPays.Nom.Replace("'","''") + "');";
            this._DBAL.Insert(query);
        }

        public void Update(Pays unPays)
        {
            string query = "Pays SET idPays = " + unPays.IdPays + ", nom = '" + unPays.Nom + "' WHERE idPays = " + unPays.IdPays+" ;";
            this._DBAL.Update(query);
        }

        public void Delete(Pays unPays)
        {
            string query = "Pays WHERE idPays = " + unPays.IdPays+";";
            this._DBAL.Delete(query);
        }

        public void InsertByFile(string Chemin)
        {

            using (var reader = new StreamReader(Chemin)) 
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
                var record = new Pays();
                var records = csv.EnumerateRecords(record);
                foreach (Pays p in records)
                {
                    Insert(p);
                }
            }
        }

        public List<Pays> SelectAll()
        {
            List<Pays> unelistepays = new List<Pays>();
            DataTable unDataTable = _DBAL.SelectAll("Pays");
            foreach (DataRow dtr in unDataTable.Rows)
            {
                Pays unPays = new Pays((int)dtr["idPays"],(string)dtr["nom"]);
                unelistepays.Add(unPays);
            }
            return unelistepays;
        }

        public Pays SelectByName(string namePays)
        {
            Pays unPays = new Pays();
            DataTable unDataTable = _DBAL.SelectByField("Pays","nom = '"+namePays+"';");
            DataRow dtr = unDataTable.Rows[0];
            unPays.IdPays = (int)dtr["idPays"];
            unPays.Nom = (string)dtr["nom"];
            return unPays;
        }

        public Pays SelectById(int idPays)
        {
            Pays unPays = new Pays();
            DataTable unDataTable = _DBAL.SelectByField("Pays", "idPays = '" + idPays + "';");
            DataRow dtr = unDataTable.Rows[0];
            unPays.IdPays = (int)dtr["idPays"];
            unPays.Nom = (string)dtr["nom"];
            return unPays;
        }
    }
}
