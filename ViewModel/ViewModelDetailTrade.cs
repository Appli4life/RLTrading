using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RLTrading.Model;

namespace RLTrading.ViewModel
{
    public class ViewModelDetailTrade : ViewModelBase
    {
        /// <summary>
        /// Der Trades
        /// </summary>
        private Trade trade;

        /// <summary>
        /// Accsessor für Trade
        /// </summary>
        public Trade Trade => trade;

        /// <summary>
        /// Ctor
        /// </summary>
        public ViewModelDetailTrade()
        {

        }

    }
}
