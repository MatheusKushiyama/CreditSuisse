using Application.InterfaceAplication;
using Domain.InterfaceService;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Application.Aplication
{
    public class AplicationTrade : IAplicationTrade
    {
        private readonly ITradeService _iTradeService;

        public AplicationTrade(ITradeService iTradeService)
        {
            _iTradeService = iTradeService;
        }
        public void Classify()
        {

            Console.WriteLine("Digite a data:");
            var data = Console.ReadLine();
            Console.WriteLine("Diginte o numero de trades:");
            var numberOfTrades = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Diginte as trades:");
            var listOfTrads = new List<TradeModel>();
            for (var i = 1; i <= numberOfTrades; i++)
            {
                var tradeInput = Console.ReadLine().Split(" ");
                try
                {
                    var trade = new TradeModel()
                    {
                        Value = Convert.ToDouble(tradeInput[0]),
                        ClientSector = tradeInput[1].ToLower(),
                        NextPaymentDate = DateTime.ParseExact(tradeInput[2],"MM/dd/yyyy", new CultureInfo("en-US"), DateTimeStyles.None),
                        IsPoliticallyExposed = Convert.ToBoolean(tradeInput[3])                        
                    };
                    listOfTrads.Add(trade);
                }
                catch 
                {
                    listOfTrads = new List<TradeModel>();
                    Console.WriteLine("Dados Incorretos");
                    break;
                }                
                
            }            

            if(listOfTrads != null && listOfTrads.Count > 0)
            {
                Console.WriteLine("Classificação:");
                var tradesOutput = _iTradeService.Classify(listOfTrads);
                foreach (var trades in tradesOutput)
                {
                    Console.WriteLine(trades.Category);
                }
            }         

           
        }
    }
}
