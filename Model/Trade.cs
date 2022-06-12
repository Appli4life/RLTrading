using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLTrading.Model
{
    /// <summary>
    /// Trade Model
    /// </summary>
    public class Trade
    {
        #region Property

        /// <summary>
        /// Alle erhaltenen Credits
        /// </summary>
        public int gotCredits { get; set; } = 0;

        /// <summary>
        /// Alle verlorenen Credits
        /// </summary>
        public int lostCredits { get; set; } = 0;

        /// <summary>
        /// Alle verkauften Items
        /// </summary>
        public List<Item> soldItems = new();


        /// <summary>
        /// Alle gekauften Items
        /// </summary>
        public List<Item> boughtItems = new();

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
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

        #endregion
    }
}
