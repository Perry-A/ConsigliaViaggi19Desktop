using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Collections.ObjectModel;
using System.Configuration;
using ConsigliaViaggi19;

namespace ConsigliaViaggi19
{
    static class Queries
    {    
        public static void CambiaStatoRecensione(int idRecensione, string nuovoStato)
        {
            string query = $"update Recensioni set stato = '{nuovoStato}' where idRecensione = {idRecensione}";
            EseguiModifica(query);
        }

        public static List<Recensione> GetRecensioni()
        {
            string query = "select R.idRecensione, R.valutazione, R.commento, R.stato, R.dataCreazione, R.nicknameUtente, " +
                           "U.nome, U.cognome, S.nome as nomeStruttura, S.tipo " +
                           "from Recensioni R, Utenti U, Strutture S " +
                           "where R.nicknameUtente = U.nickname and " +
                           "R.idStruttura = S.idStruttura;";
            DataTable table = EseguiComando(query);
            List<Recensione> recensioni = new List<Recensione>();
            foreach(DataRow row in table.Rows)
            {
                Recensione recensione = new Recensione()
                {
                    IdRecensione = (int)row["idRecensione"],
                    Valutazione = (int)row["valutazione"],
                    Commento = row["commento"].ToString(),
                    StatoApprovazione = row["stato"].ToString(),
                    DataCreazione = (DateTime)row["dataCreazione"],
                    NicknameUtente = row["nicknameUtente"].ToString(),
                    NomeUtente = row["nome"].ToString(),
                    CognomeUtente = row["cognome"].ToString(),
                    NomeStruttura = row["nomeStruttura"].ToString(),
                    TipoStruttura = row["tipo"].ToString()
                };
                recensioni.Add(recensione);
            }
            return recensioni;
        }

        public static bool IsAmministratoreEsistente(string username, string password)
        {
            string query = "select * " +
                           $"from Amministratori A " +
                           $"where A.username = '{username.Replace("'", "''")}' and A.password = '{password.Replace("'", "''")}'; ";
            DataTable table = EseguiComando(query);
            if (table.Rows.Count == 0)
                return false;
            return true;
        }
        
        public static List<string> GetCitta()
        {
            string query = "select distinct nome " +
                           "from Citta";
            DataTable table = EseguiComando(query);
            List<string> citta = new List<string>();
            foreach (DataRow row in table.Rows)
                citta.Add(row["nome"].ToString());
            return citta;
        }
        
        public static List<string> GetTipiStrutture()
        {
            string query = "select distinct tipo " +
                           "from Strutture";
            DataTable table = EseguiComando(query);
            List<string> tipi = new List<string>();
            foreach (DataRow row in table.Rows)
                tipi.Add(row["tipo"].ToString());
            return tipi;
        }

        private static void EseguiModifica(string query)
        {
            SqlConnection connection = new SqlConnection(stringConnection);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Dispose();
        }

        private static DataTable EseguiComando(string query)
        {
            SqlConnection connection = new SqlConnection(stringConnection);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            DataTable table = new DataTable();
            table.Load(command.ExecuteReader());
            connection.Dispose();
            return table;
        }

        /*private static ImageSource ConvertImage(object obj)
        {
            byte[] immagine = (byte[])obj;
            return ImageSource.FromStream(() => new MemoryStream(immagine));
        }*/

        public static readonly string stringConnection = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
    }
}
