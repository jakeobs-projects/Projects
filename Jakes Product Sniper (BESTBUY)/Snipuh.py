#this is meant for windows not linux
print('Loading Packages...')
import time
from selenium.webdriver.common.keys import Keys
from selenium import webdriver
from selenium.webdriver.support.wait import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC
from selenium.webdriver.common.proxy import Proxy, ProxyType
from selenium.webdriver.common.action_chains import ActionChains
from selenium.webdriver.common.by import By
import os
from os import system, name
import ctypes
ctypes.windll.kernel32.SetConsoleTitleW("Jakes Snipuh : Product Sniper")
from colorama import init
from termcolor import colored
from colorama import Fore, Back, Style
import threading
import requests
import urllib.request
import subprocess
from bs4 import BeautifulSoup
init(convert=True)
title = """
███████╗███╗   ██╗██╗██████╗ ██╗   ██╗██╗  ██╗
██╔════╝████╗  ██║██║██╔══██╗██║   ██║██║  ██║
███████╗██╔██╗ ██║██║██████╔╝██║   ██║███████║
╚════██║██║╚██╗██║██║██╔═══╝ ██║   ██║██╔══██║
███████║██║ ╚████║██║██║     ╚██████╔╝██║  ██║
╚══════╝╚═╝  ╚═══╝╚═╝╚═╝      ╚═════╝ ╚═╝  ╚═╝"""
fixy = "'"
refresingcounter = 0
def main():
    system('cls')
    print(title)
    print()
    print("1: BestBuy\n2: Microsoft\n3: Coming Soon\n4: Settings\n")
    choice = input("User:> ")
    if choice == '1':
        bestbuy()
    elif choice == '2':
        microsoftscalp()
    elif choice == '3':
        system('cls')
        print(title)
        print("\nWalmart\nTarget\nGamestop\nAmazon\nCostco\n")
        choice_2 = input("1: Return To Main Menu\n\nUser:> ")
        if choice_2 == '1':
            main()
        else:
            main()
    elif choice == '4':
        system('cls')
        print(title)
        print("\n1: Change Color\n2: Update Log\n3: Return To Main Menu\n")
        choice_3 = input("User:> ")
        if choice_3 == '1':
            choosecolor()
        elif choice_3 == '2':
            updateloglul()
        elif choice_3 == '3':
            main()
        else:
            print("\nUnrecognized Option Returning To Menu...")
            time.sleep(2)
            main()

    else:
        main()


def updateloglul():
    try:
        system('cls')
        print(title)
        print()
        print("-"*50)
        print("1.0: Released")
        print("-"*50)
        choicee = input("\n\n1: Return To Main Menu\n\nUser:> ")
        if choicee == '1':
            main()
        else:
            main()
    except Exception:
        pass

def ipInfo(addr=''):
    from urllib.request import urlopen
    from json import load
    if addr == '':
        url = 'https://ipinfo.io/json'
    else:
        url = 'https://ipinfo.io/' + addr + '/json'
    res = urlopen(url)
    data = load(res)
    for attr in data.keys():
        print(attr,' '*13+'\t->\t',data[attr])

def bestbuy():
    global refresingcounter
    system('cls')
    print("""
██████╗ ███████╗███████╗████████╗██████╗ ██╗   ██╗██╗   ██╗
██╔══██╗██╔════╝██╔════╝╚══██╔══╝██╔══██╗██║   ██║╚██╗ ██╔╝
██████╔╝█████╗  ███████╗   ██║   ██████╔╝██║   ██║ ╚████╔╝ 
██╔══██╗██╔══╝  ╚════██║   ██║   ██╔══██╗██║   ██║  ╚██╔╝  
██████╔╝███████╗███████║   ██║   ██████╔╝╚██████╔╝   ██║   
╚═════╝ ╚══════╝╚══════╝   ╚═╝   ╚═════╝  ╚═════╝    ╚═╝   
""")
    print()
    xboxoneseriesx = 'https://www.bestbuy.com/site/microsoft-xbox-series-x-1tb-console-black/6428324.p?skuId=6428324'
    xboxoneseriess = 'https://www.bestbuy.com/site/microsoft-xbox-series-s-512-gb-all-digital-console-disc-free-gaming-white/6430277.p?skuId=6430277'
    playstation5 = 'https://www.bestbuy.com/site/sony-playstation-5-console/6426149.p?skuId=6426149'
    playstation5digitalversion = 'https://www.bestbuy.com/site/sony-playstation-5-digital-edition-console/6430161.p?skuId=6430161'
    nvidia3060 = 'https://www.bestbuy.com/site/nvidia-geforce-rtx-3060-ti-8gb-gddr6-pci-express-4-0-graphics-card-steel-and-black/6439402.p?skuId=6439402'
    nvidia3070 = 'https://www.bestbuy.com/site/nvidia-geforce-rtx-3070-8gb-gddr6-pci-express-4-0-graphics-card-dark-platinum-and-black/6429442.p?skuId=6429442'
    nvidia3080 = 'https://www.bestbuy.com/site/nvidia-geforce-rtx-3080-10gb-gddr6x-pci-express-4-0-graphics-card-titanium-and-black/6429440.p?skuId=6429440'
    print("1: Xbox One Series X\n2: Xbox One Series S\n3: Playstation 5\n4: Playstation 5 Digital Version\n5: Nvidia 3060\n6: Nvidia 3070\n7: Nvidia 3080\n8: Custom Product\n9: Return To Main Menu\n")
    product = input("Product:> ")
    if product == '1':
        product = xboxoneseriesx
    elif product == '2':
        product = xboxoneseriess
    elif product == '3':
        product = playstation5
    elif product == '4':
        product = playstation5digitalversion
    elif product == '5':
        product = nvidia3060
    elif product == '6':
        product = nvidia3070
    elif product == '7':
        product = nvidia3080
    elif product == '9':
        main()
    elif product == '8':
        system('cls')
        print("""
██████╗ ███████╗███████╗████████╗██████╗ ██╗   ██╗██╗   ██╗
██╔══██╗██╔════╝██╔════╝╚══██╔══╝██╔══██╗██║   ██║╚██╗ ██╔╝
██████╔╝█████╗  ███████╗   ██║   ██████╔╝██║   ██║ ╚████╔╝ 
██╔══██╗██╔══╝  ╚════██║   ██║   ██╔══██╗██║   ██║  ╚██╔╝  
██████╔╝███████╗███████║   ██║   ██████╔╝╚██████╔╝   ██║   
╚═════╝ ╚══════╝╚══════╝   ╚═╝   ╚═════╝  ╚═════╝    ╚═╝   
""")
        print()
        print("-- SETTINGS --\n\n")
        product = input("Product URL:> ")
    else:
        bestbuy()
    system('cls')
    print("""
██████╗ ███████╗███████╗████████╗██████╗ ██╗   ██╗██╗   ██╗
██╔══██╗██╔════╝██╔════╝╚══██╔══╝██╔══██╗██║   ██║╚██╗ ██╔╝
██████╔╝█████╗  ███████╗   ██║   ██████╔╝██║   ██║ ╚████╔╝ 
██╔══██╗██╔══╝  ╚════██║   ██║   ██╔══██╗██║   ██║  ╚██╔╝  
██████╔╝███████╗███████║   ██║   ██████╔╝╚██████╔╝   ██║   
╚═════╝ ╚══════╝╚══════╝   ╚═╝   ╚═════╝  ╚═════╝    ╚═╝   
""")
    print()
    print("-- SETTINGS --\n\n")
    print("URL: ",product)
    print()
    print()
    print("Use a Proxy\n\n1: Yes\n2: No\n")
    choices = input("Option:> ")
    if choices == '1':
        system('cls')
        print("""
██████╗ ███████╗███████╗████████╗██████╗ ██╗   ██╗██╗   ██╗
██╔══██╗██╔════╝██╔════╝╚══██╔══╝██╔══██╗██║   ██║╚██╗ ██╔╝
██████╔╝█████╗  ███████╗   ██║   ██████╔╝██║   ██║ ╚████╔╝ 
██╔══██╗██╔══╝  ╚════██║   ██║   ██╔══██╗██║   ██║  ╚██╔╝  
██████╔╝███████╗███████║   ██║   ██████╔╝╚██████╔╝   ██║   
╚═════╝ ╚══════╝╚══════╝   ╚═╝   ╚═════╝  ╚═════╝    ╚═╝   
""")
        print()
        print("-- SETTINGS --\n\n")
        print("URL: ",product)
        print()
        print()
        proxii = input("Proxy:> ")
        system('cls')
        print("""
██████╗ ███████╗███████╗████████╗██████╗ ██╗   ██╗██╗   ██╗
██╔══██╗██╔════╝██╔════╝╚══██╔══╝██╔══██╗██║   ██║╚██╗ ██╔╝
██████╔╝█████╗  ███████╗   ██║   ██████╔╝██║   ██║ ╚████╔╝ 
██╔══██╗██╔══╝  ╚════██║   ██║   ██╔══██╗██║   ██║  ╚██╔╝  
██████╔╝███████╗███████║   ██║   ██████╔╝╚██████╔╝   ██║   
╚═════╝ ╚══════╝╚══════╝   ╚═╝   ╚═════╝  ╚═════╝    ╚═╝   
""")
        print("-- SETTINGS --\n\n")
        print("URL: ",product)
        print("Proxy: ",proxii)
        print()
        print()
        email = input("Email:> ")
        system('cls')
        print("""
██████╗ ███████╗███████╗████████╗██████╗ ██╗   ██╗██╗   ██╗
██╔══██╗██╔════╝██╔════╝╚══██╔══╝██╔══██╗██║   ██║╚██╗ ██╔╝
██████╔╝█████╗  ███████╗   ██║   ██████╔╝██║   ██║ ╚████╔╝ 
██╔══██╗██╔══╝  ╚════██║   ██║   ██╔══██╗██║   ██║  ╚██╔╝  
██████╔╝███████╗███████║   ██║   ██████╔╝╚██████╔╝   ██║   
╚═════╝ ╚══════╝╚══════╝   ╚═╝   ╚═════╝  ╚═════╝    ╚═╝   
""")
        print()
        print("-- SETTINGS --\n\n")
        print("URL: ",product)
        print("Proxy: ",proxii)
        print("Email: ",email)
        print()
        print()
        password = input("Password:> ")
        system('cls')
        print("""
██████╗ ███████╗███████╗████████╗██████╗ ██╗   ██╗██╗   ██╗
██╔══██╗██╔════╝██╔════╝╚══██╔══╝██╔══██╗██║   ██║╚██╗ ██╔╝
██████╔╝█████╗  ███████╗   ██║   ██████╔╝██║   ██║ ╚████╔╝ 
██╔══██╗██╔══╝  ╚════██║   ██║   ██╔══██╗██║   ██║  ╚██╔╝  
██████╔╝███████╗███████║   ██║   ██████╔╝╚██████╔╝   ██║   
╚═════╝ ╚══════╝╚══════╝   ╚═╝   ╚═════╝  ╚═════╝    ╚═╝   
""")
        print()
        print("-- SETTINGS --\n\n")
        print("URL: ",product)
        print("Proxy: ",proxii)
        print("Email: ",email)
        print("Password: ",password)
        print()
        print()
        threearc = int(input("CC Security Code:> "))
        system('cls')
        print("Starting...")
        try:
                prox = Proxy()
                prox.proxy_type = ProxyType.MANUAL
                prox.http_proxy = proxii
                capabilities = webdriver.DesiredCapabilities.CHROME
                prox.add_to_capabilities(capabilities)
                option = webdriver.ChromeOptions()
                option.add_argument('--disable-blink-features=AutomationControlled')
                option.add_argument("window-size=1280,800")
                option.add_argument("user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36")
                browser = webdriver.Chrome(executable_path='chromedriver.exe',options=option,desired_capabilities=capabilities)
                loginurl = 'https://www.bestbuy.com/identity/global/signin'
                browser.get(loginurl)
                time.sleep(5)
                elem = browser.find_element_by_id("fld-e")
                elem.clear()
                elem.send_keys(email)
                elem.send_keys(Keys.RETURN)
                time.sleep(1)
                elem = browser.find_element_by_id("fld-p1")
                elem.clear()
                elem.send_keys(password)
                elem.send_keys(Keys.RETURN)
                time.sleep(5)
                if "Sorry, something went wrong. Please try again." in browser.page_source:
                        print("ERROR ON LOGIN TRYING ONE MORE TIME")
                        browser.get(loginurl)
                        time.sleep(5)
                        elem = browser.find_element_by_id("fld-e")
                        elem.clear()
                        elem.send_keys(email_b)
                        elem.send_keys(Keys.RETURN)
                        time.sleep(1)
                        elem = browser.find_element_by_id("fld-p1")
                        elem.clear()
                        elem.send_keys(password_b)
                        elem.send_keys(Keys.RETURN)
                        time.sleep(2)
                        if "Sorry, something went wrong. Please try again." in browser.page_source:
                            browser.close()
                            quit()
                time.sleep(5)
                browser.find_element_by_xpath("//button[@class='c-close-icon c-modal-close-icon']").click()
                time.sleep(2)
                browser.get(product)
                time.sleep(5)
                buyButton = False
                while not buyButton:
                        try:
                            addToCartBtn = addButton = browser.find_element_by_xpath("//button[@class='btn btn-primary btn-lg btn-block btn-leading-ficon add-to-cart-button']")
                            print('Added to Cart')
                            addToCartBtn.click()
                            buyButton = True
                            time.sleep(1)
                            
                        except:
                                addToCartBtn = addButton = browser.find_element_by_xpath("//button[@class='btn btn-disabled btn-lg btn-block add-to-cart-button']")
                                refresingcounter += 1
                                system('cls')
                                print("STATUS: RUNNING\n\n")
                                print('Detected Disabled Button Refreshing | Attempts: ',refresingcounter)
                                time.sleep(1)
                                browser.refresh()
                        browser.get("https://www.bestbuy.com/cart")
                        time.sleep(5)
                        browser.find_element_by_xpath("//button[@class='btn btn-lg btn-block btn-primary']").click()
                        time.sleep(2)
                        browser.find_element_by_id("credit-card-cvv").send_keys(threearc)
                        time.sleep(1)
                        browser.find_element_by_xpath("//button[@class='btn btn-lg btn-block btn-primary button__fast-track']").click()
                        print("PURCHASED PRODUCT EZ\n")
                        aoe = browser.find_element_by_xpath("//span[@class='oss-col-l-4']")
                        print("ORDER DETAILS: "+aoe)
                        input()
        except Exception as e:
                print(e)
                input()
        else:
            bestbuy()
    elif choices == '2':
        system('cls')
        print("""
██████╗ ███████╗███████╗████████╗██████╗ ██╗   ██╗██╗   ██╗
██╔══██╗██╔════╝██╔════╝╚══██╔══╝██╔══██╗██║   ██║╚██╗ ██╔╝
██████╔╝█████╗  ███████╗   ██║   ██████╔╝██║   ██║ ╚████╔╝ 
██╔══██╗██╔══╝  ╚════██║   ██║   ██╔══██╗██║   ██║  ╚██╔╝  
██████╔╝███████╗███████║   ██║   ██████╔╝╚██████╔╝   ██║   
╚═════╝ ╚══════╝╚══════╝   ╚═╝   ╚═════╝  ╚═════╝    ╚═╝   
""")
        print()
        print("-- SETTINGS --\n\n")
        print("URL: ",product)
        print("Proxy: No")
        print()
        print()
        email = input("Email:> ")
        system('cls')
        print("""
██████╗ ███████╗███████╗████████╗██████╗ ██╗   ██╗██╗   ██╗
██╔══██╗██╔════╝██╔════╝╚══██╔══╝██╔══██╗██║   ██║╚██╗ ██╔╝
██████╔╝█████╗  ███████╗   ██║   ██████╔╝██║   ██║ ╚████╔╝ 
██╔══██╗██╔══╝  ╚════██║   ██║   ██╔══██╗██║   ██║  ╚██╔╝  
██████╔╝███████╗███████║   ██║   ██████╔╝╚██████╔╝   ██║   
╚═════╝ ╚══════╝╚══════╝   ╚═╝   ╚═════╝  ╚═════╝    ╚═╝   
""")
        print()
        print("-- SETTINGS --\n\n")
        print("URL: ",product)
        print("Proxy: No")
        print("Email: ",email)
        print()
        print()
        password = input("Password:> ")
        system('cls')
        print("""
██████╗ ███████╗███████╗████████╗██████╗ ██╗   ██╗██╗   ██╗
██╔══██╗██╔════╝██╔════╝╚══██╔══╝██╔══██╗██║   ██║╚██╗ ██╔╝
██████╔╝█████╗  ███████╗   ██║   ██████╔╝██║   ██║ ╚████╔╝ 
██╔══██╗██╔══╝  ╚════██║   ██║   ██╔══██╗██║   ██║  ╚██╔╝  
██████╔╝███████╗███████║   ██║   ██████╔╝╚██████╔╝   ██║   
╚═════╝ ╚══════╝╚══════╝   ╚═╝   ╚═════╝  ╚═════╝    ╚═╝   
""")
        print()
        print("-- SETTINGS --\n\n")
        print("URL: ",product)
        print("Proxy: No")
        print("Email: ",email)
        print("Password: ",password)
        print()
        print()
        threearc = int(input("CC Security Code:> "))
        system('cls')
        print("Starting...")
        try:
            option = webdriver.ChromeOptions()
            option.add_argument('--disable-blink-features=AutomationControlled')
            option.add_argument("window-size=1280,800")
            option.add_argument("user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36")
            browser = webdriver.Chrome(executable_path='chromedriver.exe',options=option)
            loginurl = 'https://www.bestbuy.com/identity/global/signin'
            browser.get(loginurl)
            time.sleep(5)
            elem = browser.find_element_by_id("fld-e")
            elem.clear()
            elem.send_keys(email)
            elem.send_keys(Keys.RETURN)
            time.sleep(1)
            elem = browser.find_element_by_id("fld-p1")
            elem.clear()
            elem.send_keys(password)
            elem.send_keys(Keys.RETURN)
            time.sleep(5)
            if "Sorry, something went wrong. Please try again." in browser.page_source:
                print("ERROR ON LOGIN TRYING ONE MORE TIME")
                browser.get(loginurl)
                time.sleep(5)
                elem = browser.find_element_by_id("fld-e")
                elem.clear()
                elem.send_keys(email)
                elem.send_keys(Keys.RETURN)
                time.sleep(1)
                elem = browser.find_element_by_id("fld-p1")
                elem.clear()
                elem.send_keys(password)
                elem.send_keys(Keys.RETURN)
                time.sleep(2)
                if "Sorry, something went wrong. Please try again." in browser.page_source:
                    browser.close()
                    quit()
                    input()
            time.sleep(5)
            browser.find_element_by_xpath("//button[@class='c-close-icon c-modal-close-icon']").click()
            time.sleep(2)
            browser.get(product)
            time.sleep(5)
            buyButton = False
            while not buyButton:
                try:
                    addToCartBtn = addButton = browser.find_element_by_xpath("//button[@class='btn btn-primary btn-lg btn-block btn-leading-ficon add-to-cart-button']")
                    print('Added to Cart\n')
                    addToCartBtn.click()
                    buyButton = True
                    time.sleep(1)
                except:
                        addToCartBtn = addButton = browser.find_element_by_xpath("//button[@class='btn btn-disabled btn-lg btn-block add-to-cart-button']")
                        refresingcounter += 1
                        system('cls')
                        print("STATUS: RUNNING\n\n")
                        print('Detected Disabled Button Refreshing | Attempts: ',refresingcounter)
                        time.sleep(1)
                        browser.refresh()
            browser.get("https://www.bestbuy.com/cart")
            time.sleep(4)
            browser.find_element_by_xpath("//button[@class='btn btn-lg btn-block btn-primary']").click()
            time.sleep(2)
            browser.find_element_by_id("credit-card-cvv").send_keys(threearc)
            time.sleep(1)
            browser.find_element_by_xpath("//button[@class='btn btn-lg btn-block btn-primary button__fast-track']").click()
            print("PURCHASED PRODUCT EZ\n")
            aoe = browser.find_element_by_xpath("//span[@class='oss-col-l-4']")
            print("ORDER DETAILS: "+aoe)
            input()
        except Exception as e:
            print(e)
            input()
        else:
            bestbuy()
    

def amazon():
    try:
        option = webdriver.ChromeOptions()
        option.add_argument('--disable-blink-features=AutomationControlled')
        option.add_argument("window-size=1280,800")
        option.add_argument("user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36")
        browser = webdriver.Chrome(executable_path='chromedriver.exe',options=option)
        loginurl = 'https://www.bestbuy.com/identity/global/signin'
        browser.get(loginurl)
    except Exception as e:
        print(e)
        input()



def gamestop():
    try:
        system('cls')
        print("""""")
        print()
        email = input("Email:> ")
        print()
        password = input("Password:> ")
        print()
        option = webdriver.ChromeOptions()
        option.add_argument('--disable-blink-features=AutomationControlled')
        option.add_argument("window-size=1280,800")
        option.add_argument("user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36")
        browser = webdriver.Chrome(executable_path='chromedriver.exe',options=option)
        browser.get('https://www.gamestop.com/')
        time.sleep(5)
        actions = ActionChains(browser)
        actions.send_keys(Keys.TAB)
        actions.send_keys(Keys.TAB)
        actions.send_keys(Keys.TAB)
        actions.send_keys(Keys.TAB)
        actions.send_keys(Keys.TAB)
        actions.send_keys(Keys.TAB)
        actions.send_keys(Keys.TAB)
        actions.send_keys(Keys.TAB)
        actions.send_keys(Keys.TAB)
        actions.send_keys(Keys.TAB)
        actions.send_keys(Keys.TAB)
        actions.send_keys(Keys.TAB)
        actions.send_keys(Keys.TAB)
        actions.send_keys(Keys.RETURN)
        actions.perform()
        time.sleep(1)
        browser.find_element_by_id('signIn').click()
        time.sleep(2)
        elemJC = browser.find_element_by_id("login-form-email")
        elemJC.clear()
        elemJC.send_keys(email)
        time.sleep(1)
        elemJC1 = browser.find_element_by_id("login-form-password")
        elemJC1.clear()
        elemJC1.send_keys(password)
        elemJC1.send_keys(Keys.RETURN)
        elemJC1.send_keys(Keys.Enter)
        print("done")
        #now make a gamestop account and do the rest i stopped at logged in success
    except Exception as e:
        print(e)
        print("error done lol")
        input()



def microsoftscalp():
    try:
        system('cls')
        print("""""")
        print()
        option = webdriver.ChromeOptions()
        option.add_argument('--disable-blink-features=AutomationControlled')
        option.add_argument("window-size=1280,800")
        option.add_argument("user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36")
        browser = webdriver.Chrome(executable_path='chromedriver.exe',options=option)
        loginurl = 'https://www.microsoft.com/en-us/p/xbox-series-x/8wj714n3rbtl?icid=XboxCat_CP3_SeriesFamily_X&activetab=pivot%3aoverviewtab'
        browser.get(loginurl)
    except Exception as e:
        print(e)
        input()




def choosecolor():
    print(Fore.WHITE)
    system("cls")
    print("Choose A Color\n")
    print("1: Red\n2: Blue\n3: Cyan\n4: Green\n5: Yellow\n6: Magenta\n7: White\n")
    choiceslul = input("User:> ")
    if choiceslul == '1':
        print(Fore.RED)
        main()
    elif choiceslul == '2':
        print(Fore.BLUE)
        main()
    elif choiceslul == '3':
        print(Fore.CYAN)
        main()
    elif choiceslul == '4':
        print(Fore.GREEN)
        main()
    elif choiceslul == '5':
        print(Fore.YELLOW)
        main()
    elif choiceslul == '6':
        print(Fore.MAGENTA)
        main()
    elif choiceslul == '7':
        print(Fore.WHITE)
        main()
    else:
        print("Unrecognized Option...")
        time.sleep(3)
        choosecolor()





choosecolor()
