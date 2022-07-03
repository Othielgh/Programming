# nothing=12345
# Keeps giving new numbers.
# Idea is to automate scraping the next page
# https://urbansecurityresearch.com/tag/python-challenge-level-4/ for hints
from bs4 import BeautifulSoup
import requests

url = "http://www.pythonchallenge.com/pc/def/linkedlist.php?nothing="
nothing = str(input("Please enter the first number: "))

def get_page(nothing):
    header = {"User-Agent" : ("Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:90.0) Gecko/20100101 Firefox/90.0")}
    page = requests.get((url + nothing), headers=header)
    txt = page.text
    soup = BeautifulSoup(txt, 'html.parser')
    data = str(soup)
    return get_nothing(data)

def get_nothing(data):
    text = "and the next nothing is"
    if text in data:
        nothing = data[data.find("is ") + 3:]
        print(nothing)
        return nothing
    else:
        return data

#while nothing.isnumeric() == True:
#    nothing = get_page(nothing)

while True:
    if nothing.isnumeric():
        nothing = get_page(nothing)
    else:
        print(nothing)
        nothing = input("Something unexpected showed up\nwhat is the next number?: ")
