#!usr/bin/env python3
from bs4 import BeautifulSoup
import requests

url = "https://www.zooplus.nl/shop/katten/kattennet_kattenluik/kattenluik/petporte/661157"
headers = {"User-Agent" : "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:89.0) Gecko/20100101 Firefox/89.0"}

def get_page_html(url):
    page = requests.get(url, headers=headers)
    print(page.status_code)
    return page.content

def check_item_in_stock(page_html):
    soup = BeautifulSoup(page_html, 'html.parser')
    out_of_stock_divs = soup.findAll("div", {"class": "warning__title text-danger"})
    #print(out_of_stock_divs)
    return len(out_of_stock_divs) != 0

def check_inventory():
    page_html = get_page_html(url)
    if check_item_in_stock(page_html):
        print("In Stock")
    else:
        print("Out of Stock")

check_inventory()