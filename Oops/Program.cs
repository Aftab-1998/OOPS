

using Oops;

List<Stock> stocks = new List<Stock>()
{
    new Stock()
    {
        Price = 10, Name = "Bajaj", nostocks  = 5, Symbol = "Bajaj.Pic"

    },
    new Stock()
    {
        Name = "Flipkart", Price = 20, Symbol = "Flipkart.coc", nostocks = 10
    },
     new Stock()
    {
        Name = "Amazon", Price = 200, Symbol = "Amazon.coc", nostocks = 10
    },

};

 StockMangement stockMangement = new StockMangement(stocks);

stockMangement.CalutateTotalValue();
stockMangement.Buy(100, "Bajaj");
stockMangement.Sell(40, "Flipkart");
stockMangement.PrintReport(20, "Flipkart,Bajaj");
stockMangement.Add(200, "Amazon");



