import requests
from bs4 import BeautifulSoup
 
nothing = "12345"
def get_data(nothing): 
    url = "http://www.pythonchallenge.com/pc/def/linkedlist.php?nothing=" + nothing 
    hdr = {'User-Agent': ('mozilla/5.0 (windows nt 10.0; win64; x64) applewebkit/537.36 (khtml, like gecko) chrome/78.0.3904.70 safari/537.36')} 
    req = requests.get(url, headers=hdr) 
    html = req.text 
    soup = BeautifulSoup(html, 'html.parser') 
    data = str(soup) 
    return get_nothing(data) 
    
def get_nothing(data): 
    txt = "and the next nothing is" 
    if txt in data: 
        nothing = data[data.find("is ") + 3:] 
        print(nothing) 
        return nothing 
    else: 
        return data 
            
            
if __name__ == "__main__": 
    while nothing.isnumeric() == True: 
        nothing = get_data(nothing) 
    print(nothing)

