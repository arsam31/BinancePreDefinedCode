
using Binance.Net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceConsole1
{
    public class Message
    {
        public string[] registration_ids { get; set; }
        public Notification notification { get; set; }
        public object data { get; set; }
    }
    public class Notification
    {
        public string title { get; set; }
        public string text { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {


            using (var client = new BinanceSocketClient())
            {
                var listenKey = string.Empty;
                var successOrderBook = client.SubscribeToUserStream(listenKey,
                (accountInfoUpdate) =>
                {
                    // handle account info update
                },
                (orderInfoUpdate) =>
                {
                    // handle order info update
                });
            }





        }
     
        //static void Raw()
        //{
        //    //string ApiKey = "RyABEeXGT29fD7mezKfpN3aoNqiX8fzTWseacYSED8fOyIXdos69SMWIr1muhSDp";
        //    //string SecretKey = "WQhmLA1usL2JsDkAxtf7hB0V6rtWR1ZfqukSVh64O5xkwuuIhAH81KpViahGp8DR";
        //    string ApiKey = "sLtzgs6gdmjfZy1q4Gjb482lyv0xJPTKBpeMHdPh3dxO7ZFnhO7HxhhGQxBBBgRx";
        //    string SecretKey = "KfPWRcVivy8bKWP9KqzoVRIQzKvRC6zAw1sxqp3aa7ERiatmLrGEjIbN42TtKQ0c";
        //    //BinanceSocketClient binanceClient;
        //    //binanceClient = new BinanceSocketClient();
        //    BinanceClient binanceClient;
        //    binanceClient = new BinanceClient();
        //    //Binance.Net.BinanceClient binanceClient = new Binance.Net.BinanceClient();

        //    binanceClient.SetApiCredentials(ApiKey, SecretKey);

        //    var avialableBalance = string.Empty;

        //    decimal btcTotal = 0;
        //    var tickers = binanceClient.GetAllPrices();
        //    var accountInformation = binanceClient.GetAccountInfo();
        //    var userBinanceBalances = accountInformation.Data.Balances;
        //    userBinanceBalances = userBinanceBalances.Where(a => a.Asset.StartsWith("TNB")).ToList();
        //    decimal clientBTCAllocated = 0;
        //    decimal clientUSDTAllocated = 0;
        //    if (userBinanceBalances != null && userBinanceBalances.Count() > 0)
        //    {
        //        clientBTCAllocated = userBinanceBalances.Where(m => m.Asset == "BTC").Select(m => m.Free).DefaultIfEmpty(0).FirstOrDefault();
        //        clientUSDTAllocated = userBinanceBalances.Where(m => m.Asset == "USDT").Select(m => m.Free).DefaultIfEmpty(0).FirstOrDefault();
        //    }
        //    var assetDetails = binanceClient.GetAssetDetails();
        //    if (accountInformation != null)
        //    {

        //        foreach (var item in accountInformation.Data.Balances)
        //        {
        //            decimal btcValue = 0;
        //            if (item.Free > 0)
        //            {
        //                try
        //                {
        //                    //if (item.Asset == "BTC") btcValue = item.Total;
        //                    //else if (item.Asset == "USDT") btcValue = item.Total / lObj_BinanceClient.GetPrice("BTCUSDT").Data.Price;
        //                    //else btcValue = item.Total * lObj_BinanceClient.GetPrice(item.Asset + "BTC").Data.Price;
        //                    //btcTotal += btcValue;
        //                    if (!assetDetails.Data.Where(a => a.Key == item.Asset).First().Value.DepositStatus)
        //                    {
        //                        continue;
        //                    }
        //                    if (item.Asset == "BTC") btcValue = item.Total;
        //                    else if (item.Asset == "USDT") btcValue = item.Total / tickers.Data.ToList().Where(x => x.Symbol == "BTCUSDT").FirstOrDefault().Price;
        //                    else btcValue = item.Total * tickers.Data.ToList().Where(x => x.Symbol == item.Asset + "BTC").FirstOrDefault().Price;
        //                    btcTotal += btcValue;
        //                }
        //                catch (Exception)
        //                {
        //                }

        //            }
        //        }
        //        avialableBalance = btcTotal.ToString();
        //    }

        //    decimal availableBalance2 = 0;
        //    if (!string.IsNullOrEmpty(avialableBalance) && avialableBalance != "Failed")
        //    {
        //        availableBalance2 = Math.Round(Convert.ToDecimal(avialableBalance), 8);
        //    }

        //    //decimal availableBalance = 0;
        //    //if (!string.IsNullOrEmpty(AvailableBalance) && AvailableBalance != "Failed")
        //    //{
        //    //    availableBalance = Math.Round(Convert.ToDecimal(AvailableBalance), 8);
        //    //}

        //    ////get BTC price in USD  


        //    //var tradingParameterInput = new TradingParameterInput
        //    //{
        //    //    Pair = item.MarketName,
        //    //    UserId = groupAssociatedUserSession.Key.UserId
        //    //};
        //    var tickerValueBTCToUSD = binanceClient.GetPrice("BTCUSDT").Data.Price;
        //    var TickerBTCtoUSDT = Convert.ToDecimal(tickerValueBTCToUSD);

        //    decimal ExchangeMinimumBalance = 500;
        //    decimal MinimumBalanceConvertDollarToBTC = 0;
        //    if (ExchangeMinimumBalance != 0 && TickerBTCtoUSDT != 0)
        //    {
        //        MinimumBalanceConvertDollarToBTC = Math.Round(ExchangeMinimumBalance / Convert.ToDecimal(tickerValueBTCToUSD), 8);
        //    }

        //    if (availableBalance2 >= MinimumBalanceConvertDollarToBTC)
        //    {
        //        //info.IsValidateMinimumAccumulatedBalance = true;
        //    }

        //    //tradingParameterInput.price = Price;
        //    //tradingParameterInput.quantity = Quantity;
        //    // var zb =  binanceClient.CheckTradeRules("BTCUSDT", Quantity, Price, Binance.Net.Objects.OrderType.Market);



        //    //var accountInformation =  binanceClient.GetAccountInfo();
        //    //var assetDetails = binanceClient.GetPrice("BTTUSDT");
        //    //var tickers = binanceClient.getm();
        //    //string avialableBalance = string.Empty;
        //    decimal balance = 0;
        //    //decimal btcTotal = 0;
        //    string Res = "Failed";
        //    //try
        //    //{
        //    //    if (accountInformation != null)
        //    //    {

        //    //        foreach (var item in accountInformation.Data.Balances)
        //    //        {
        //    //            decimal btcValue = 0;
        //    //            if (item.Free > 0)
        //    //            {
        //    //                try
        //    //                {
        //    //                    //if (item.Asset == "BTC") btcValue = item.Total;
        //    //                    //else if (item.Asset == "USDT") btcValue = item.Total / lObj_BinanceClient.GetPrice("BTCUSDT").Data.Price;
        //    //                    //else btcValue = item.Total * lObj_BinanceClient.GetPrice(item.Asset + "BTC").Data.Price;
        //    //                    //btcTotal += btcValue;
        //    //                    if (!assetDetails.Data.Where(a => a.Key == item.Asset).First().Value.DepositStatus)
        //    //                    {
        //    //                        continue;
        //    //                    }
        //    //                    if (item.Asset == "BTC") btcValue = item.Total;
        //    //                    else if (item.Asset == "USDT") btcValue = item.Total / tickers.Data.ToList().Where(x => x.Symbol == "BTCUSDT").FirstOrDefault().Price;
        //    //                    else btcValue = item.Total * tickers.Data.ToList().Where(x => x.Symbol == item.Asset + "BTC").FirstOrDefault().Price;
        //    //                    btcTotal += btcValue;
        //    //                }
        //    //                catch (Exception)
        //    //                {
        //    //                }

        //    //            }
        //    //        }
        //    //        avialableBalance = btcTotal.ToString();
        //    //    }
        //    //    else
        //    //        avialableBalance = Res;
        //    //}
        //    //catch (Exception ex)
        //    //{

        //    //    throw;
        //    //}

        //    //using (var client = new BinanceSocketClient())
        //    //{
        //    //binanceClient.SetApiCredentials(ApiKey, SecretKey);
        //    // var data =binanceClient.PlaceTestOrder(,);

        //    //var accountInformation = binanceClient.GetAccountInfoAsync();
        //    //var data = binanceClient.get("BTC");
        //    //balanceResponse = accountInformation.da.Balances.Where(c => c.Free > 0).ToList();
        //    //var successKline = binanceClient.SubscribeToSymbolTicker("ETHBTC", (data) =>
        //    //{
        //    //    System.Console.WriteLine($"ETHBTC Price {DateTime.Now.ToLongTimeString()}: {JsonConvert.SerializeObject(data)}");
        //    //});
        //    //}
        //    //var startTimeSpan = TimeSpan.Zero;
        //    //var periodTimeSpan = TimeSpan.FromSeconds(2);

        //    //var timer = new System.Threading.Timer((e) =>
        //    //{
        //    //    var data = binanceClient.GetPrice("ETHBTC");
        //    //    System.Console.WriteLine($"ETHBTC Price {DateTime.Now.ToLongTimeString()}: {JsonConvert.SerializeObject(data.Data)}");

        //    //}, null, startTimeSpan, periodTimeSpan);


        //    // The code provided will print ‘Hello World’ to the console.
        //    // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
        //    // Console.WriteLine("Hello World!");
        //    //System.Console.WriteLine($"ETHBTC Price {DateTime.Now.ToLongTimeString()}: {JsonConvert.SerializeObject(data)}");

        //    Console.ReadKey();

        //    // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        //}
    }
}
