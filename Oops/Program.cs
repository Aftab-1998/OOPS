﻿

using Oops;

List<Stock> stocks = new List<Stock>()
{
    new Stock()
    {
        Price = 10, Name = "Gold", nostocks  = 5, Symbol = "Gold.Pic"

    },
    new Stock()
    {
        Name = "Sliver", Price = 20, Symbol = "Sliver.coc", nostocks = 10
    }
};

 StockMangement stockMangement = new StockMangement();
stockMangement.CalutateTotalValue(stocks);
