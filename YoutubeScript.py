import youtube_dl
from colorama import init
from termcolor import colored
from colorama import Fore, Back, Style
import ctypes
ctypes.windll.kernel32.SetConsoleTitleW("Jakes Youtube Downloader")
import os
from os import system, name
import time
init(convert=True)
def main():
    
    try:
             print(Fore.CYAN+"""
                                                                       
 _|      _|                      _|                _|                  
   _|  _|    _|_|    _|    _|  _|_|_|_|  _|    _|  _|_|_|      _|_|    
     _|    _|    _|  _|    _|    _|      _|    _|  _|    _|  _|_|_|_|  
     _|    _|    _|  _|    _|    _|      _|    _|  _|    _|  _|        
     _|      _|_|      _|_|_|      _|_|    _|_|_|  _|_|_|      _|_|_|  
                                                                       
                                                                       
""")
             print('')
             name33 = input('Name of file you want it to be:> ')
             print('')
             print('Examples: .wav or .mp4 or .mp3 or .webm')
             print('')
             formattselct = input('Format:> ')
             print()
             utublnk = input('Link:> ')
             ydl_opts = {'outtmpl': name33+formattselct}

             with youtube_dl.YoutubeDL(ydl_opts) as ydl:
                 ydl.download([utublnk])
                 print('')
                 print('')
                 print('Song downloaded\n')
                 print('')
                 print('Redirecting To Menu')
                 time.sleep(2)
                 system('cls')
                 main()
    except Exception as e:
            print(Fore.RED,e)
            time.sleep(2)
            input()


main()
