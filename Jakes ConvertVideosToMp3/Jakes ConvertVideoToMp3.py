#using moviepy this is meant to takes videos such as mp4s and turn them into mp3 format
from moviepy.editor import *
import os
print('running')
def main():
                file_1 = input("Filename:> ")
                videoClip = VideoFileClip(file_1+'.mp4')
                audioclip = videoClip.audio
                audioclip.write_audiofile(file_1+'.mp3')
                audioclip.close()
                videoClip.close()
                file_to_remove = file_1+'.mp4'
                os.remove(file_to_remove)
                main()
main()
