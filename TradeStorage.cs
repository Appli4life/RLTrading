using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RLTrading
{
    public class TradeStorage
    {
        public List<Trade> allTrades = new List<Trade>();
        static public string path = string.Format(Directory.GetCurrentDirectory() + @"\data\Trades.json");
        public bool loadTrades()
        {
            try
            {
                allTrades.Clear();

                using (StreamReader r = new StreamReader(path))
                {
                    string json = r.ReadToEnd();
                    r.Close();
                    allTrades = JsonConvert.DeserializeObject<List<Trade>>(json);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool saveTrades()
        {
            try
            {
                using (StreamWriter w = new StreamWriter(path, false))
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

        public bool updateTrade(int ID, Trade trade)
        {
            try
            {
                if (allTrades.Count > 0)
                {
                    Trade oldtrade = allTrades.Where(a => a.ID == ID).First();

                    if (null != oldtrade)
                    {
                        allTrades.Remove(oldtrade);
                        allTrades.Add(trade);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool deleteTrade(Trade trade)
        {
            try
            {
                allTrades.Remove(trade);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            throw new NotImplementedException();
        }
    }
}
