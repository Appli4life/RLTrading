using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RLTrading.Model
{
    /// <summary>
    /// Json Saver
    /// </summary>
    public class JsonSaver : ISaver
    {
        #region Property

        /// <summary>
        /// Pfad zur Json Datei (ab Current Directory)
        /// </summary>
        public static string Path = @"data\Trades.json";

        #endregion

        #region Methoden

        /// <summary>
        /// Ladet alle Trades von der Json datei(siehe Property "path") in eine ObservableCollection
        /// </summary>
        /// <returns>ObservableCollection mit allen Trades</returns>
        public ObservableCollection<Trade> loadTrades()
        {
            try
            {
                if (!File.Exists(Path))
                {
                    File.Open(Path, FileMode.Create);
                }
                using (StreamReader r = new StreamReader(Path))
                {
                    string json = r.ReadToEnd();
                    if (json == "")
                    {
                        return new ObservableCollection<Trade>();
                    }
                    r.Close();
                    return JsonConvert.DeserializeObject<ObservableCollection<Trade>>(json);
                }
            }
            catch (Exception)
            {
                return new ObservableCollection<Trade>();
            }

        }

        /// <summary>
        /// Speicher alle Trades in der Json Datei(siehe Property "path")
        /// </summary>
        /// <param name="allTrades">ObservableCollection mit den zu speichernden Trades</param>
        /// <returns>True / False je nach erfolg</returns>
        public bool saveTrades(ObservableCollection<Trade> allTrades)
        {
            try
            {
                using (StreamWriter w = new StreamWriter(Path, false))
                {
                    string json = JsonConvert.SerializeObject(allTrades);
                    w.Write(json);
                    w.Close();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion
    }
}
