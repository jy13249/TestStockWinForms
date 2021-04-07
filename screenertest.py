from finviz.screener import Screener
import finviz


"""
filters = ['exch_nasd', 'idx_sp500']  # Shows companies in NASDAQ which are in the S&P500
stock_list = Screener(filters=filters, table='Performance', order='price')  # Get the performance table and sort it by price ascending


for stock in stock_list[9:19]:  # Loop through 10th - 20th stocks
    print(stock['Ticker'], stock['Price']) # Print symbol and price

#prints individual stock info
print(finviz.get_stock("AAPL"))
"""

filters = ["an_recom_holdbetter,cap_midunder,geo_usa,sh_avgvol_o300,sh_curvol_o300,sh_price_5to50,ta_highlow52w_b5h,ta_perf_13wup,ta_perf2_ytdup,ta_rsi_nob60,ta_sma20_pca,ta_sma200_pa,ta_sma50_pa"]
stock_list = Screener(filters=filters)
print(stock_list)
