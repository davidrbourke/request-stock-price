﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketAnalysis.Model
{
    public class Quote
    {
        #region Properties
        public int QuoteId { get; set; }
        public Decimal Ask { get; set; }
        public Decimal Bid { get; set; }
        public string AskRealtime { get; set; }
        public string BidRealtime { get; set; }
        public string BookValue { get; set; }
        public string Change_PercentChange { get; set; }
        public string Change { get; set; }
        public string Commission { get; set; }
        public string ChangeRealtime { get; set; }
        public string AfterHoursChangeRealtime { get; set; }
        public string DividendShare { get; set; }
        public string LastTradeDate { get; set; }
        public string TradeDate { get; set; }
        public string EarningsShare { get; set; }
        public string ErrorIndicationreturnedforsymbolchangedinvalid { get; set; }
        public string EPSEstimateCurrentYear { get; set; }
        public string EPSEstimateNextYear { get; set; }
        public string EPSEstimateNextQuarter { get; set; }
        public string DaysLow { get; set; }
        public string DaysHigh { get; set; }
        public string YearLow { get; set; }
        public string YearHigh { get; set; }
        public string HoldingsGainPercent { get; set; }
        public string AnnualizedGain { get; set; }
        public string HoldingsGain { get; set; }
        public string HoldingsGainPercentRealtime { get; set; }
        public string HoldingsGainRealtime { get; set; }
        public string MoreInfo { get; set; }
        public string OrderBookRealtime { get; set; }
        public string MarketCapitalization { get; set; }
        public string MarketCapRealtime { get; set; }
        public string EBITDA { get; set; }
        public string ChangeFromYearLow { get; set; }
        public string PercentChangeFromYearLow { get; set; }
        public string LastTradeRealtimeWithTime { get; set; }
        public string ChangePercentRealtime { get; set; }
        public string ChangeFromYearHigh { get; set; }
        public string PercentChangeFromYearHigh { get; set; }
        public string LastTradeWithTime { get; set; }
        public string LastTradePriceOnly { get; set; }
        public string HighLimit { get; set; }
        public string LowLimit { get; set; }
        public string DaysRange { get; set; }
        public string DaysRangeRealtime { get; set; }
        public string FiftydayMovingAverage { get; set; }
        public string TwoHundreddayMovingAverage { get; set; }
        public string ChangeFromTwoHundreddayMovingAverage { get; set; }
        public string PercentChangeFromTwoHundreddayMovingAverage { get; set; }
        public string ChangeFromFiftydayMovingAverage { get; set; }
        public string PercentChangeFromFiftydayMovingAverage { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public string Open { get; set; }
        public string PreviousClose { get; set; }
        public string PricePaid { get; set; }
        public string ChangeinPercent { get; set; }
        public string PriceSales { get; set; }
        public string PriceBook { get; set; }
        public string ExDividendDate { get; set; }
        public string PERatio { get; set; }
        public string DividendPayDate { get; set; }
        public string PERatioRealtime { get; set; }
        public string PEGRatio { get; set; }
        public string PriceEPSEstimateCurrentYear { get; set; }
        public string PriceEPSEstimateNextYear { get; set; }
        public string Symbol { get; set; }
        public string SharesOwned { get; set; }
        public string ShortRatio { get; set; }
        public string LastTradeTime { get; set; }
        public string TickerTrend { get; set; }
        public string OneyrTargetPrice { get; set; }
        public string Volume { get; set; }
        public string HoldingsValue { get; set; }
        public string HoldingsValueRealtime { get; set; }
        public string YearRange { get; set; }
        public string DaysValueChange { get; set; }
        public string DaysValueChangeRealtime { get; set; }
        public string StockExchange { get; set; }
        public string DividendYield { get; set; }
        public string PercentChange { get; set; }
        public DateTime Created { get; set; }
        #endregion
    }
}
