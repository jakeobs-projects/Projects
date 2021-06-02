import ctypes
ctypes.windll.kernel32.SetConsoleTitleW("Jakes Spammer")
import time
from colorama import init
from termcolor import colored
from colorama import Fore, Back, Style
import os
from os import system, name
import os.path
import pyautogui
init(convert=True)


def spammingtheh():
        system('cls')
        try:
            print(Fore.BLUE)
            print()
            print('''
      /$$$$$$                                   
     /$$__  $$                                  
    | $$  \__/  /$$$$$$   /$$$$$$  /$$$$$$/$$$$ 
    |  $$$$$$  /$$__  $$ |____  $$| $$_  $$_  $$
     \____  $$| $$  \ $$  /$$$$$$$| $$ \ $$ \ $$
     /$$  \ $$| $$  | $$ /$$__  $$| $$ | $$ | $$
    |  $$$$$$/| $$$$$$$/|  $$$$$$$| $$ | $$ | $$
     \______/ | $$____/  \_______/|__/ |__/ |__/
              | $$                              
              | $$                              
              |__/                              
    ''')
            print(Fore.CYAN)
            msg = input("Enter the message:> ")
            print()
            n = input("How many times:> ")
            print()
            print('Examples:\n1.0 = wait one second(slow)\n000.1 = fast')
            print()
            delay = float(input('How Many Milliseconds in between each message:> '))

            print('\nAt any time press CTRL+C to stop')
            print("\nStarting...\n")

            count = 5
            while(count != 0):
                    print(count)
                    time.sleep(1)
                    count -= 1

            for i in range(0,int(n)):
                    pyautogui.typewrite(msg + '\n')
                    time.sleep(delay)
            print('\nTask Done\n')
            choice = input('1: Restart\n2: Close\n\n:> ')
            if choice == '1':
                spammingtheh()
            elif choice == '2':
                exit()
            else:
                print('Key Unrcognized Closing')
                time.sleep(2)
                exit()
                
        except KeyboardInterrupt:
            print('KeyboardInterrupt Detected')
            time.sleep(2)
            
            
        except Exception as e:
            print('Error: ',e)
            input()



spammingtheh()
