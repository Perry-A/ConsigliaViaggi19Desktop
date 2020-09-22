using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Collections.ObjectModel;
using System.Configuration;

namespace ConsigliaViaggi19App
{
    static class Queries
    {         
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

        /*public static List<Recensione> GetRecensioni(ParametriRicercaRecensione parametri)
        {
            string query = $"select * " +
                $"from Utenti U, Recensioni R " +
                $"where U.Nickname = R.NicknameUtente and R.idStruttura = {parametri.IdStruttura} and " +
                $"R.valutazione >= {parametri.ValutazioneMinimo} and R.valutazione <= {parametri.ValutazioneMassimo} and " +
                $"R.dataCreazione <= '{parametri.DataAl.ToString("yyyy-MM-dd")}' and R.dataCreazione >= '{parametri.DataDal.ToString("yyyy-MM-dd")}' " +
                $"and R.stato = 'approvato';";
            DataTable table = EseguiComando(query);
            List<Recensione> recensioni = new List<Recensione>();
            foreach(DataRow row in table.Rows)
            {
                Recensione recensione = new Recensione()
                {
                    IdRecensione = (int)row["idRecensione"],
                    NicknameUtente = row["NickNameUtente"].ToString(),
                    NomeUtente = row["Nome"].ToString(),
                    CognomeUtente = row["Cognome"].ToString(),
                    VisibileConNickname = (bool)row["visibileConNickname"],
                    Commento = row["Commento"].ToString(),
                    DataCreazione = (DateTime)row["DataCreazione"],
                    Valutazione = (int)row["Valutazione"]
                };
                recensioni.Add(recensione);
            }
            return recensioni;
        }*/       
        /*public static List<Struttura> GetLuoghiTrovati(ParametriRicercaStrutture parametri)
        {
            StringBuilder sottoQueryUno = new StringBuilder($"select S.idStruttura, S.nome, S.immagine, S.tipo, S.latitudine, " +
                $"S.longitudine, S.descrizione, C.nome as nomeCitta " +
                $"from Strutture S, Citta C " +
                $"where S.idCitta = C.idCitta ");
            if (!(parametri.NomeStruttura is null))
                sottoQueryUno.Append($"and lower(S.Nome) like '%{parametri.NomeStruttura.Replace("'", "''")}%' ");
            if (parametri.TipoStruttura != "Qualsiasi struttura")
                sottoQueryUno.Append($"and S.Tipo = '{parametri.TipoStruttura}' ");
            if (parametri.Citta != "Posizione corrente")
                sottoQueryUno.Append($"and C.Nome = '{parametri.Citta}' ");
            StringBuilder sottoQueryDue = new StringBuilder($"select S.idStruttura, CAST(ISNULL(avg(CAST(TMP.valutazione as DECIMAL(10, 2))), 0) as DECIMAL(10, 2)) as valutazioneMedia " +
               "from Strutture S left outer join " +
               "(select * " +
               "from Recensioni R " +
               "where R.stato = 'approvato') TMP on S.idStruttura = TMP.idStruttura " +
               "group by S.idStruttura");
            string query = "select * " +
                $"from ({sottoQueryUno}) TMP1, ({sottoQueryDue}) TMP2 " +
                $"where TMP1.idStruttura = TMP2.idStruttura and " +
                $"TMP2.valutazioneMedia >= {parametri.ValutazioneMediaMinima} and TMP2.valutazioneMedia <= {parametri.ValutazioneMediaMassima};";
            DataTable table = EseguiComando(query);
            if (parametri.IsFiltroPosizioneAttivo)
                return FiltraStrutturePerDistanza(parametri.PosizioneCorrente, table, parametri.DistanzaMinima, parametri.DistanzaMassima);
            return GetLuoghiTrovatiDaDataTable(parametri.PosizioneCorrente, table);
        }*/
        
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
