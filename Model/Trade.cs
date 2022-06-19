using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<Item> soldItems = new ObservableCollection<Item>();


        /// <summary>
        /// Alle gekauften Items
        /// </summary>
        public ObservableCollection<Item> boughtItems = new ObservableCollection<Item>();

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public Trade()
        {
            
        }

        /// <summary>
        /// Clone erstellen
        /// </summary>
        /// <returns>Eine Kopie von dem aktuellen Trade</returns>
        public Trade Clone()
        {
            return (Trade)MemberwiseClone();
        }

        ///// <summary>
        ///// Ctor (Items für Items Trade)
        ///// </summary>
        ///// <param name="soldItems">Verkaufte Items</param>
        ///// <param name="boughtItems">Gekaufte Items</param>
        //public Trade(ObservableCollection<Item> soldItems, ObservableCollection<Item> boughtItems)
        //{          
        //    this.soldItems = soldItems;
        //    this.boughtItems = boughtItems;
        //}

        ///// <summary>
        ///// Ctor (Item für Credits gekauft)
        ///// </summary>
        ///// <param name="boughtItem">Gekauftes Item</param>
        ///// <param name="lostCredits">Credits bezahlt</param>
        //public Trade(Item boughtItem, int lostCredits)
        //{
        //    this.lostCredits = lostCredits;
        //    boughtItems.Add(boughtItem);
        //}

        ///// <summary>
        ///// Ctor (Item für Credits verkauft
        ///// </summary>
        ///// <param name="gotCredits">Erhaltene Credits</param>
        ///// <param name="soldItem">Verkauftes Item</param>
        //public Trade(int gotCredits, Item soldItem)
        //{
        //    this.gotCredits = gotCredits;
        //    soldItems.Add(soldItem);
        //}

        ///// <summary>
        ///// Ctor (Grosser Trade)
        ///// </summary>
        ///// <param name="gotCredits">Erhaltene Credits</param>
        ///// <param name="lostCredits">Credits bezahlt</param>
        ///// <param name="soldItems">Verkaufte Items</param>
        ///// <param name="boughtItems">Gekaufte Items</param>
        //public Trade(int gotCredits, int lostCredits, ObservableCollection<Item> soldItems, ObservableCollection<Item> boughtItems)
        //{
        //    this.gotCredits = gotCredits;
        //    this.lostCredits = lostCredits;
        //    this.soldItems = soldItems;
        //    this.boughtItems = boughtItems;
        //}

        #endregion
    }
}
