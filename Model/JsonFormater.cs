using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace RLTrading.Model
{
    /// <summary>
    /// Json Saver
    /// </summary>
    public class JsonFormater
    {

        #region Methoden

        public ObservableCollection<Trade> DeserializeTrade(string json)
        {

            var trades = JsonSerializer.Deserialize<List<Trade>>(json);

            return new ObservableCollection<Trade>(trades);
        }

        public string SerializeTrade(IEnumerable<Trade> allTrades)
        {
            return JsonSerializer.Serialize(allTrades);
        }

        #endregion
    }
}
