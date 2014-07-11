﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using autotrade.model;
using CTPMdApi;
using autotrade.util;

namespace autotrade.business
{
    class MarketManager
    {
        private readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private MdApi mdApi;

        public delegate void MarketDataHandler(object sender, MarketDataEventArgs e);

        public event MarketDataHandler OnRtnMarketData;

        public MarketManager(MdApi mdApi)
        {
            this.mdApi = mdApi;
            this.mdApi.OnRtnDepthMarketData += mdApi_OnRtnDepthMarketData;
        }

        void mdApi_OnRtnDepthMarketData(ref CThostFtdcDepthMarketDataField pDepthMarketData)
        {
            MarketData marketData = new MarketData();

            ObjectUtils.Copy(pDepthMarketData, marketData);

            log.Info(marketData);
            OnRtnMarketData(this, new MarketDataEventArgs(marketData));
        }

        public void SubMarketData(params string[] instruments)
        {
            mdApi.SubMarketData(instruments);
        }
    }

    internal class MarketDataEventArgs : EventArgs
    {
        public MarketData marketData { get; set; }
        public MarketDataEventArgs(MarketData marketData)
            : base()
        {
            this.marketData = marketData;
        }
    }
}
