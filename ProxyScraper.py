import ctypes
ctypes.windll.kernel32.SetConsoleTitleW("Jakes Proxy Scrapper")
from colorama import init
from termcolor import colored
from colorama import Fore, Back, Style
import os
from os import system, name
import os.path
import requests
import sys
from bs4 import BeautifulSoup
import time
init(convert=True)
def scraptheinternet():
    try:
        print(Fore.BLUE)
        print("""
$$$$$$$\                                $$\                     
$$  __$$\                               \__|                    
$$ |  $$ | $$$$$$\   $$$$$$\  $$\   $$\ $$\  $$$$$$\   $$$$$$$\ 
$$$$$$$  |$$  __$$\ $$  __$$\ \$$\ $$  |$$ |$$  __$$\ $$  _____|
$$  ____/ $$ |  \__|$$ /  $$ | \$$$$  / $$ |$$$$$$$$ |\$$$$$$\  
$$ |      $$ |      $$ |  $$ | $$  $$<  $$ |$$   ____| \____$$\ 
$$ |      $$ |      \$$$$$$  |$$  /\$$\ $$ |\$$$$$$$\ $$$$$$$  |
\__|      \__|       \______/ \__/  \__|\__| \_______|\_______/ 
                                                                
                                                                
                                                                
""")
        print(Fore.BLUE)
        headers = {
            'user-agent': 'Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36',
        }
        
        with open('Proxies.txt', 'w')as file:
            try:
                url = 'https://api.proxyscrape.com/?request=getproxies&proxytype=http&timeout=10000&country=all&ssl=all&anonymity=all'
                r = requests.get(url)
                for item in r.text.split():
                    print(item)
                    file.write(item+'\n')
                url = 'https://api.proxyscrape.com/?request=getproxies&proxytype=socks4&timeout=10000&country=all'
                r = requests.get(url)
                for item in r.text.split():
                    print(item)
                    file.write(item+'\n')
                url = 'https://api.proxyscrape.com/?request=getproxies&proxytype=socks5&timeout=10000&country=all'
                r = requests.get(url)
                for item in r.text.split():
                    print(item)
                    file.write(item+'\n')

                
            except:
                pass
            
        file.close()

            
        url = 'https://free-proxy-list.net/'
        mytext = requests.get(url,headers=headers)
        soup = BeautifulSoup(mytext.text,"html.parser")
        table = soup.find('table',{"id" : "proxylisttable"})
        
        with open('Proxies.txt','a')as file:
            for row in table.find_all('tr'):
                columns = row.find_all('td')
                try:
                    print(columns[0].get_text()+':'+columns[1].get_text())
                    file.write(columns[0].get_text()+':'+columns[1].get_text()+'\n')
                except:
                    pass
        file.close()
        print('-'*40)
        url = 'https://www.socks-proxy.net/'
        mytext = requests.get(url,headers=headers,)
        soup = BeautifulSoup(mytext.text,"html.parser")
        table = soup.find('table',{"id" : "proxylisttable"})
        with open('Proxies.txt','a')as file:
                for row in table.find_all('tr'):
                    columns = row.find_all('td')
                    try:
                        print(columns[0].get_text()+':'+columns[1].get_text())
                        file.write(columns[0].get_text()+':'+columns[1].get_text()+'\n')
                    except:
                        pass

        print('-'*40)
        url = 'https://www.sslproxies.org/'
        mytext = requests.get(url,headers=headers,)
        soup = BeautifulSoup(mytext.text,"html.parser")
        table = soup.find('table',{"id" : "proxylisttable"})
        with open('Proxies.txt','a')as file:
                for row in table.find_all('tr'):
                    columns = row.find_all('td')
                    try:
                        print(columns[0].get_text()+':'+columns[1].get_text())
                        file.write(columns[0].get_text()+':'+columns[1].get_text()+'\n')
                    except:
                        pass
        file.close()



        print('-'*40)
        url = 'https://www.us-proxy.org/'
        mytext = requests.get(url,headers=headers,)
        soup = BeautifulSoup(mytext.text,"html.parser")
        table = soup.find('table',{"id" : "proxylisttable"})
        with open('Proxies.txt','a')as file:
                for row in table.find_all('tr'):
                    columns = row.find_all('td')
                    try:
                        print(columns[0].get_text()+':'+columns[1].get_text())
                        file.write(columns[0].get_text()+':'+columns[1].get_text()+'\n')
                    except:
                        print()

                        
        print(Fore.GREEN)
        print('File Saved To:  '+os.path.abspath('Proxies.txt'))
        file.close()
        input()

        
    except Exception as e:
        print(Fore.RED)
        print('Error: ',e)
        file.close()



scraptheinternet()
