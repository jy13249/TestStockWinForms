import pandas as pd
from finvizfinance.quote import finvizfinance
from finviz.screener import Screener
import finviz

""" Download stock chart
stock = finvizfinance("TSLA")
stock.TickerCharts()
print("Successfully executed python script from WinForms app!") """


def GrabStockList():
    filters = ["an_recom_holdbetter,cap_midunder,geo_usa,sh_avgvol_o300,sh_curvol_o300,sh_price_5to50,ta_highlow52w_b5h,ta_perf_13wup,ta_perf2_ytdup,ta_rsi_nob60,ta_sma20_pca,ta_sma200_pa,ta_sma50_pa"]
    stock_list = Screener(filters=filters)
    for stock in stock_list:
        print(stock["Ticker"])


GrabStockList()
