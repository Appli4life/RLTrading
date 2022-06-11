using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLTrading
{
    public class Trade
    {
        public int ID { get; } = 0;
        public int gotCredits { get; set; } = 0;
        public int lostCredits { get; set; } = 0;

        public List<Item> soldItems = new List<Item>();

        public List<Item> boughtItems = new List<Item>();

        public Trade()
        {

        }

        /// <summary>
        /// Ctor (Items für Items Trade)
        /// </summary>
        /// <param name="soldItems">Verkaufte Items</param>
        /// <param name="boughtItems">Gekaufte Items</param>
        public Trade(List<Item> soldItems, List<Item> boughtItems)
        {          
            this.soldItems = soldItems;
            this.boughtItems = boughtItems;
        }

        /// <summary>
        /// Ctor (Item für Credits gekauft)
        /// </summary>
        /// <param name="boughtItem">Gekauftes Item</param>
        /// <param name="lostCredits">Credits bezahlt</param>
        public Trade(Item boughtItem, int lostCredits)
        {
            this.lostCredits = lostCredits;
            boughtItems.Add(boughtItem);
        }

        /// <summary>
        /// Ctor (Item für Credits verkauft
        /// </summary>
        /// <param name="gotCredits">Erhaltene Credits</param>
        /// <param name="soldItem">Verkauftes Item</param>
        public Trade(int gotCredits, Item soldItem)
        {
            this.gotCredits = gotCredits;
            soldItems.Add(soldItem);
        }

        /// <summary>
        /// Ctor (Grosser Trade)
        /// </summary>
        /// <param name="gotCredits">Erhaltene Credits</param>
        /// <param name="lostCredits">Credits bezahlt</param>
        /// <param name="soldItems">Verkaufte Items</param>
        /// <param name="boughtItems">Gekaufte Items</param>
        public Trade(int gotCredits, int lostCredits, List<Item> soldItems, List<Item> boughtItems)
        {
            this.gotCredits = gotCredits;
            this.lostCredits = lostCredits;
            this.soldItems = soldItems;
            this.boughtItems = boughtItems;
        }
    }
}
