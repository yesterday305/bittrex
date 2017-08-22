using Bittrex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitcoinTrader
{
    public partial class BitTrex : Form
    {
        public BitTrex()
        {
            InitializeComponent();
        }

        private void btnGetMarketSummary_Click(object sender, EventArgs e)
        {

            var bitcoinName = txbBitcoinName.Text;
            //var result = exchange.GetMarketSummary(bitcoinName);
            var result = PublicAPI.Instance.GetMarketSummary(bitcoinName.Trim());
            txbResult.Text = FormatAllProperties(result);
        }
        public string FormatAllProperties(object obj)
        {
            string returnValue = string.Empty;
            var allProperties = obj.GetType().GetProperties();
            foreach (var pro in allProperties)
            {
                returnValue += string.Format("{0} : {1}", pro.Name, obj.GetType().GetProperty(pro.Name).GetValue(obj)) + Environment.NewLine;
            }
            return returnValue;
        }
    }
}
