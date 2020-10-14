using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;
using Ubiety.Dns.Core.Records;

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
            string query = "Pays VALUES " + "(" + unPays.IdPays + ",'" + unPays.Nom + "');";
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
    }
}
