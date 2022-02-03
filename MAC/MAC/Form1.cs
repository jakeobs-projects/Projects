using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput.Native;
using WindowsInput;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Collections;
using System.IO;
using System.Threading;
using System.Diagnostics;
using Microsoft.CSharp;
using System.CodeDom.Compiler;

namespace MAC
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(String sClassName, String SAppName);
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        InputSimulator sim = new InputSimulator();
        private int idusedfirst;
        private int idusedsecond;
        private bool timer2checktoggle = false;
        private bool newcheck1 = false;
        private bool turnbackoncheck = false;
        private string remembermebind1 = "";
        private string remembermebind2 = "";
        Point lastPoint;
        public Form1()
        {
            InitializeComponent();
        }
        public enum fsModifiers
        {
            Alt = 0x0001,
            Control = 0x0002,
            Shift = 0x0004,
            Window = 0x0008
        }
        protected override void WndProc(ref Message keyPressed)
        {
            if (keyPressed.Msg == 0x0312)
            {
                int id = keyPressed.WParam.ToInt32();
                if (id == 16)
                {
                    runconfig();
                }
                else if (id == 17)
                {
                    remembertheforceluke();
                }
            }
            base.WndProc(ref keyPressed);
        }
        private void remembertheforceluke()
        {
            string line1 = remembermebind2;
            using (StringReader reader1 = new StringReader(remembermebind2))
            {
                while ((line1 = reader1.ReadLine()) != null)
                {

                    if (line1 == "key_press VK_A")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_A);
                    }
                    if (line1 == "key_press VK_B")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_B);
                    }
                    if (line1 == "key_press VK_C")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_C);
                    }
                    if (line1 == "key_press VK_D")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_D);
                    }
                    if (line1 == "key_press VK_E")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_E);
                    }
                    if (line1 == "key_press VK_F")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_F);
                    }
                    if (line1 == "key_press VK_G")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_G);
                    }
                    if (line1 == "key_press VK_H")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_H);
                    }
                    if (line1 == "key_press VK_I")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_I);
                    }
                    if (line1 == "key_press VK_J")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_J);
                    }
                    if (line1 == "key_press VK_K")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_K);
                    }
                    if (line1 == "key_press VK_L")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_L);
                    }
                    if (line1 == "key_press VK_M")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_M);
                    }
                    if (line1 == "key_press VK_N")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_N);
                    }
                    if (line1 == "key_press VK_O")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_O);
                    }
                    if (line1 == "key_press VK_P")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_P);
                    }
                    if (line1 == "key_press VK_Q")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_Q);
                    }
                    if (line1 == "key_press VK_R")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_R);
                    }
                    if (line1 == "key_press VK_S")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_S);
                    }
                    if (line1 == "key_press VK_T")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_T);
                    }
                    if (line1 == "key_press VK_U")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_U);
                    }
                    if (line1 == "key_press VK_V")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_V);
                    }
                    if (line1 == "key_press VK_W")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_W);
                    }
                    if (line1 == "key_press VK_X")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_X);
                    }
                    if (line1 == "key_press VK_Y")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_Y);
                    }
                    if (line1 == "key_press VK_Z")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_Z);
                    }
                    if (line1 == "key_press F1")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F1);
                    }
                    if (line1 == "key_press F2")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F2);
                    }
                    if (line1 == "key_press F3")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F3);
                    }
                    if (line1 == "key_press F4")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F4);
                    }
                    if (line1 == "key_press F5")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F5);
                    }
                    if (line1 == "key_press F6")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F6);
                    }
                    if (line1 == "key_press F7")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F7);
                    }
                    if (line1 == "key_press F8")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F8);
                    }
                    if (line1 == "key_press F9")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F9);
                    }
                    if (line1 == "key_press F10")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F10);
                    }
                    if (line1 == "key_press F11")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F11);
                    }
                    if (line1 == "key_press F12")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F12);
                    }
                    if (line1 == "key_press F13")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F13);
                    }
                    if (line1 == "key_press F14")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F14);
                    }
                    if (line1 == "key_press F15")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F15);
                    }
                    if (line1 == "key_press F16")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F16);
                    }
                    if (line1 == "key_press F17")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F17);
                    }
                    if (line1 == "key_press F18")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F18);
                    }
                    if (line1 == "key_press F19")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F19);
                    }
                    if (line1 == "key_press F20")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F20);
                    }
                    if (line1 == "key_press F21")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F21);
                    }
                    if (line1 == "key_press F22")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F22);
                    }
                    if (line1 == "key_press F23")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F23);
                    }
                    if (line1 == "key_press F24")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F24);
                    }
                    if (line1 == "key_press BACK")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.BACK);
                    }
                    if (line1 == "key_press TAB")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
                    }
                    if (line1 == "key_press CLEAR")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.CLEAR);
                    }
                    if (line1 == "key_press RETURN")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                    }
                    if (line1 == "key_press SHIFT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.SHIFT);
                    }
                    if (line1 == "key_press CONTROL")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.CONTROL);
                    }
                    if (line1 == "key_press MENU")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.MENU);
                    }
                    if (line1 == "key_press PAUSE")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.PAUSE);
                    }
                    if (line1 == "key_press CAPITAL")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.CAPITAL);
                    }
                    if (line1 == "key_press HANGUL")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.HANGUL);
                    }
                    if (line1 == "key_press JUNJA")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.JUNJA);
                    }
                    if (line1 == "key_press HANJA")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.HANJA);
                    }
                    if (line1 == "key_press ESCAPE")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.ESCAPE);
                    }
                    if (line1 == "key_press CONVERT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.CONVERT);
                    }
                    if (line1 == "key_press NONCONVERT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NONCONVERT);
                    }
                    if (line1 == "key_press ACCEPT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.ACCEPT);
                    }
                    if (line1 == "key_press MODECHANGE")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.MODECHANGE);
                    }
                    if (line1 == "key_press SPACE")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.SPACE);
                    }
                    if (line1 == "key_press PRIOR")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.PRIOR);
                    }
                    if (line1 == "key_press NEXT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NEXT);
                    }
                    if (line1 == "key_press END")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.END);
                    }
                    if (line1 == "key_press HOME")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.HOME);
                    }
                    if (line1 == "key_press LEFT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.LEFT);
                    }
                    if (line1 == "key_press RIGHT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.RIGHT);
                    }
                    if (line1 == "key_press DOWN")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.DOWN);
                    }
                    if (line1 == "key_press SELECT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.SELECT);
                    }
                    if (line1 == "key_press PRINT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.PRINT);
                    }
                    if (line1 == "key_press EXECUTE")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.EXECUTE);
                    }
                    if (line1 == "key_press SNAPSHOT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.SNAPSHOT);
                    }
                    if (line1 == "key_press INSERT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.INSERT);
                    }
                    if (line1 == "key_press DELETE")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.DELETE);
                    }
                    if (line1 == "key_press HELP")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.HELP);
                    }
                    if (line1 == "key_press VK_0")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_0);
                    }
                    if (line1 == "key_press VK_1")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_1);
                    }
                    if (line1 == "key_press VK_2")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_2);
                    }
                    if (line1 == "key_press VK_3")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_3);
                    }
                    if (line1 == "key_press VK_4")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_4);
                    }
                    if (line1 == "key_press VK_5")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_5);
                    }
                    if (line1 == "key_press VK_6")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_6);
                    }
                    if (line1 == "key_press VK_7")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_7);
                    }
                    if (line1 == "key_press VK_8")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_8);
                    }
                    if (line1 == "key_press VK_9")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_9);
                    }
                    if (line1 == "key_press LWIN")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.LWIN);
                    }
                    if (line1 == "key_press RWIN")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.RWIN);
                    }
                    if (line1 == "key_press SLEEP")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.SLEEP);
                    }
                    if (line1 == "key_press APPS")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.APPS);
                    }
                    if (line1 == "key_press NUMPAD0")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NUMPAD0);
                    }
                    if (line1 == "key_press NUMPAD1")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NUMPAD1);
                    }
                    if (line1 == "key_press NUMPAD2")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NUMPAD2);
                    }
                    if (line1 == "key_press NUMPAD3")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NUMPAD3);
                    }
                    if (line1 == "key_press NUMPAD4")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NUMPAD4);
                    }
                    if (line1 == "key_press NUMPAD5")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NUMPAD5);
                    }
                    if (line1 == "key_press NUMPAD6")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NUMPAD6);
                    }
                    if (line1 == "key_press NUMPAD7")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NUMPAD7);
                    }
                    if (line1 == "key_press NUMPAD8")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NUMPAD8);
                    }
                    if (line1 == "key_press NUMPAD9")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NUMPAD9);
                    }
                    if (line1 == "key_press MULTIPLY")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.MULTIPLY);
                    }
                    if (line1 == "key_press ADD")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.ADD);
                    }
                    if (line1 == "key_press SEPARATOR")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.SEPARATOR);
                    }
                    if (line1 == "key_press SUBTRACT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.SUBTRACT);
                    }
                    if (line1 == "key_press DECIMAL")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.DECIMAL);
                    }
                    if (line1 == "key_press DIVIDE")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.DIVIDE);
                    }
                    if (line1 == "key_press NUMLOCK")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NUMLOCK);
                    }
                    if (line1 == "key_press SCROLL")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.SCROLL);
                    }
                    if (line1 == "key_press LSHIFT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.LSHIFT);
                    }
                    if (line1 == "key_press RSHIFT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.RSHIFT);
                    }
                    if (line1 == "key_press LCONTROL")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.LCONTROL);
                    }
                    if (line1 == "key_press RCONTROL")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.RCONTROL);
                    }
                    if (line1 == "key_press LMENU")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.LMENU);
                    }
                    if (line1 == "key_press RMENU")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.RMENU);
                    }
                    if (line1 == "key_press BROWSER_BACK")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.BROWSER_BACK);
                    }
                    if (line1 == "key_press BROWSER_FORWARD")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.BROWSER_FORWARD);
                    }
                    if (line1 == "key_press BROWSER_REFRESH")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.BROWSER_REFRESH);
                    }
                    if (line1 == "key_press BROWSER_STOP")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.BROWSER_STOP);
                    }
                    if (line1 == "key_press BROWSER_SEARCH")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.BROWSER_SEARCH);
                    }
                    if (line1 == "key_press BROWSER_FAVORITES")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.BROWSER_FAVORITES);
                    }
                    if (line1 == "key_press BROWSER_HOME")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.BROWSER_HOME);
                    }
                    if (line1 == "key_press VOLUME_MUTE")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VOLUME_MUTE);
                    }
                    if (line1 == "key_press VOLUME_DOWN")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VOLUME_DOWN);
                    }
                    if (line1 == "key_press VOLUME_UP")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VOLUME_UP);
                    }
                    if (line1 == "key_press MEDIA_NEXT_TRACK")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.MEDIA_NEXT_TRACK);
                    }
                    if (line1 == "key_press MEDIA_PREV_TRACK")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.MEDIA_PREV_TRACK);
                    }
                    if (line1 == "key_press MEDIA_STOP")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.MEDIA_STOP);
                    }
                    if (line1 == "key_press MEDIA_PLAY_PAUSE")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.MEDIA_PLAY_PAUSE);
                    }
                    if (line1 == "key_press LAUNCH_MAIL")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.LAUNCH_MAIL);
                    }
                    if (line1 == "key_press LAUNCH_MEDIA_SELECT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.LAUNCH_MEDIA_SELECT);
                    }
                    if (line1 == "key_press LAUNCH_APP1")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.LAUNCH_APP1);
                    }
                    if (line1 == "key_press LAUNCH_APP2")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.LAUNCH_APP2);
                    }
                    if (line1 == "key_press OEM_1")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_1);
                    }
                    if (line1 == "key_press OEM_PLUS")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_PLUS);
                    }
                    if (line1 == "key_press OEM_COMMA")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_COMMA);
                    }
                    if (line1 == "key_press OEM_MINUS")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_MINUS);
                    }
                    if (line1 == "key_press OEM_PERIOD")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_PERIOD);
                    }
                    if (line1 == "key_press OEM_2")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_2);
                    }
                    if (line1 == "key_press OEM_3")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_3);
                    }
                    if (line1 == "key_press OEM_4")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_4);
                    }
                    if (line1 == "key_press OEM_5")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_5);
                    }
                    if (line1 == "key_press OEM_6")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_6);
                    }
                    if (line1 == "key_press OEM_7")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_7);
                    }
                    if (line1 == "key_press OEM_8")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_8);
                    }
                    if (line1 == "key_press OEM_102")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_102);
                    }
                    if (line1 == "key_press PROCESSKEY")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.PROCESSKEY);
                    }
                    if (line1 == "key_press PACKET")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.PACKET);
                    }
                    if (line1 == "key_press ATTN")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.ATTN);
                    }
                    if (line1 == "key_press CRSEL")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.CRSEL);
                    }
                    if (line1 == "key_press EXSEL")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.EXSEL);
                    }
                    if (line1 == "key_press EREOF")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.EREOF);
                    }
                    if (line1 == "key_press PLAY")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.PLAY);
                    }
                    if (line1 == "key_press ZOOM")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.ZOOM);
                    }
                    if (line1 == "key_press NONAME")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NONAME);
                    }
                    if (line1 == "key_press PA1")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.PA1);
                    }
                    if (line1 == "key_press OEM_CLEAR")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_CLEAR);
                    }
                    if (line1 == "key_press XBUTTON2")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.XBUTTON2);
                    }
                    if (line1 == "key_press XBUTTON1")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.XBUTTON1);
                    }
                    if (line1 == "key_press MBUTTON")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.MBUTTON);
                    }
                    if (line1 == "key_press CANCEL")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.CANCEL);
                    }
                    if (line1 == "key_press RBUTTON")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.RBUTTON);
                    }
                    if (line1 == "key_press LBUTTON")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.LBUTTON);
                    }
                    if (line1 == "key_down VK_A")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_A);
                    }
                    if (line1 == "key_down VK_B")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_B);
                    }
                    if (line1 == "key_down VK_C")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_C);
                    }
                    if (line1 == "key_down VK_D")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_D);
                    }
                    if (line1 == "key_down VK_E")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_E);
                    }
                    if (line1 == "key_down VK_F")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_F);
                    }
                    if (line1 == "key_down VK_G")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_G);
                    }
                    if (line1 == "key_down VK_H")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_H);
                    }
                    if (line1 == "key_down VK_I")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_I);
                    }
                    if (line1 == "key_down VK_J")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_J);
                    }
                    if (line1 == "key_down VK_K")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_K);
                    }
                    if (line1 == "key_down VK_L")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_L);
                    }
                    if (line1 == "key_down VK_M")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_M);
                    }
                    if (line1 == "key_down VK_N")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_N);
                    }
                    if (line1 == "key_down VK_O")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_O);
                    }
                    if (line1 == "key_down VK_P")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_P);
                    }
                    if (line1 == "key_down VK_Q")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_Q);
                    }
                    if (line1 == "key_down VK_R")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_R);
                    }
                    if (line1 == "key_down VK_S")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_S);
                    }
                    if (line1 == "key_down VK_T")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_T);
                    }
                    if (line1 == "key_down VK_U")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_U);
                    }
                    if (line1 == "key_down VK_V")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_V);
                    }
                    if (line1 == "key_down VK_W")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_W);
                    }
                    if (line1 == "key_down VK_X")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_X);
                    }
                    if (line1 == "key_down VK_Y")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_Y);
                    }
                    if (line1 == "key_down VK_Z")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_Z);
                    }
                    if (line1 == "key_down F1")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F1);
                    }
                    if (line1 == "key_down F2")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F2);
                    }
                    if (line1 == "key_down F3")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F3);
                    }
                    if (line1 == "key_down F4")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F4);
                    }
                    if (line1 == "key_down F5")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F5);
                    }
                    if (line1 == "key_down F6")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F6);
                    }
                    if (line1 == "key_down F7")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F7);
                    }
                    if (line1 == "key_down F8")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F8);
                    }
                    if (line1 == "key_down F9")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F9);
                    }
                    if (line1 == "key_down F10")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F10);
                    }
                    if (line1 == "key_down F11")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F11);
                    }
                    if (line1 == "key_down F12")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F12);
                    }
                    if (line1 == "key_down F13")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F13);
                    }
                    if (line1 == "key_down F14")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F14);
                    }
                    if (line1 == "key_down F15")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F15);
                    }
                    if (line1 == "key_down F16")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F16);
                    }
                    if (line1 == "key_down F17")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F17);
                    }
                    if (line1 == "key_down F18")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F18);
                    }
                    if (line1 == "key_down F19")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F19);
                    }
                    if (line1 == "key_down F20")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F20);
                    }
                    if (line1 == "key_down F21")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F21);
                    }
                    if (line1 == "key_down F22")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F22);
                    }
                    if (line1 == "key_down F23")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F23);
                    }
                    if (line1 == "key_down F24")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F24);
                    }
                    if (line1 == "key_down BACK")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.BACK);
                    }
                    if (line1 == "key_down TAB")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.TAB);
                    }
                    if (line1 == "key_down CLEAR")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.CLEAR);
                    }
                    if (line1 == "key_down RETURN")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.RETURN);
                    }
                    if (line1 == "key_down SHIFT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    }
                    if (line1 == "key_down CONTROL")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.CONTROL);
                    }
                    if (line1 == "key_down MENU")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.MENU);
                    }
                    if (line1 == "key_down PAUSE")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.PAUSE);
                    }
                    if (line1 == "key_down CAPITAL")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.CAPITAL);
                    }
                    if (line1 == "key_down HANGUL")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.HANGUL);
                    }
                    if (line1 == "key_down JUNJA")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.JUNJA);
                    }
                    if (line1 == "key_down HANJA")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.HANJA);
                    }
                    if (line1 == "key_down ESCAPE")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.ESCAPE);
                    }
                    if (line1 == "key_down CONVERT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.CONVERT);
                    }
                    if (line1 == "key_down NONCONVERT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NONCONVERT);
                    }
                    if (line1 == "key_down ACCEPT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.ACCEPT);
                    }
                    if (line1 == "key_down MODECHANGE")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.MODECHANGE);
                    }
                    if (line1 == "key_down SPACE")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.SPACE);
                    }
                    if (line1 == "key_down PRIOR")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.PRIOR);
                    }
                    if (line1 == "key_down NEXT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NEXT);
                    }
                    if (line1 == "key_down END")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.END);
                    }
                    if (line1 == "key_down HOME")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.HOME);
                    }
                    if (line1 == "key_down LEFT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.LEFT);
                    }
                    if (line1 == "key_down RIGHT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.RIGHT);
                    }
                    if (line1 == "key_down DOWN")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.DOWN);
                    }
                    if (line1 == "key_down SELECT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.SELECT);
                    }
                    if (line1 == "key_down PRINT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.PRINT);
                    }
                    if (line1 == "key_down EXECUTE")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.EXECUTE);
                    }
                    if (line1 == "key_down SNAPSHOT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.SNAPSHOT);
                    }
                    if (line1 == "key_down INSERT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.INSERT);
                    }
                    if (line1 == "key_down DELETE")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.DELETE);
                    }
                    if (line1 == "key_down HELP")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.HELP);
                    }
                    if (line1 == "key_down VK_0")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_0);
                    }
                    if (line1 == "key_down VK_1")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_1);
                    }
                    if (line1 == "key_down VK_2")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_2);
                    }
                    if (line1 == "key_down VK_3")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_3);
                    }
                    if (line1 == "key_down VK_4")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_4);
                    }
                    if (line1 == "key_down VK_5")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_5);
                    }
                    if (line1 == "key_down VK_6")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_6);
                    }
                    if (line1 == "key_down VK_7")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_7);
                    }
                    if (line1 == "key_down VK_8")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_8);
                    }
                    if (line1 == "key_down VK_9")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_9);
                    }
                    if (line1 == "key_down LWIN")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.LWIN);
                    }
                    if (line1 == "key_down RWIN")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.RWIN);
                    }
                    if (line1 == "key_down SLEEP")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.SLEEP);
                    }
                    if (line1 == "key_down APPS")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.APPS);
                    }
                    if (line1 == "key_down NUMPAD0")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NUMPAD0);
                    }
                    if (line1 == "key_down NUMPAD1")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NUMPAD1);
                    }
                    if (line1 == "key_down NUMPAD2")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NUMPAD2);
                    }
                    if (line1 == "key_down NUMPAD3")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NUMPAD3);
                    }
                    if (line1 == "key_down NUMPAD4")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NUMPAD4);
                    }
                    if (line1 == "key_down NUMPAD5")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NUMPAD5);
                    }
                    if (line1 == "key_down NUMPAD6")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NUMPAD6);
                    }
                    if (line1 == "key_down NUMPAD7")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NUMPAD7);
                    }
                    if (line1 == "key_down NUMPAD8")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NUMPAD8);
                    }
                    if (line1 == "key_down NUMPAD9")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NUMPAD9);
                    }
                    if (line1 == "key_down MULTIPLY")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.MULTIPLY);
                    }
                    if (line1 == "key_down ADD")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.ADD);
                    }
                    if (line1 == "key_down SEPARATOR")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.SEPARATOR);
                    }
                    if (line1 == "key_down SUBTRACT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.SUBTRACT);
                    }
                    if (line1 == "key_down DECIMAL")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.DECIMAL);
                    }
                    if (line1 == "key_down DIVIDE")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.DIVIDE);
                    }
                    if (line1 == "key_down NUMLOCK")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NUMLOCK);
                    }
                    if (line1 == "key_down SCROLL")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.SCROLL);
                    }
                    if (line1 == "key_down LSHIFT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.LSHIFT);
                    }
                    if (line1 == "key_down RSHIFT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.RSHIFT);
                    }
                    if (line1 == "key_down LCONTROL")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.LCONTROL);
                    }
                    if (line1 == "key_down RCONTROL")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.RCONTROL);
                    }
                    if (line1 == "key_down LMENU")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.LMENU);
                    }
                    if (line1 == "key_down RMENU")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.RMENU);
                    }
                    if (line1 == "key_down BROWSER_BACK")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.BROWSER_BACK);
                    }
                    if (line1 == "key_down BROWSER_FORWARD")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.BROWSER_FORWARD);
                    }
                    if (line1 == "key_down BROWSER_REFRESH")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.BROWSER_REFRESH);
                    }
                    if (line1 == "key_down BROWSER_STOP")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.BROWSER_STOP);
                    }
                    if (line1 == "key_down BROWSER_SEARCH")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.BROWSER_SEARCH);
                    }
                    if (line1 == "key_down BROWSER_FAVORITES")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.BROWSER_FAVORITES);
                    }
                    if (line1 == "key_down BROWSER_HOME")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.BROWSER_HOME);
                    }
                    if (line1 == "key_down VOLUME_MUTE")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VOLUME_MUTE);
                    }
                    if (line1 == "key_down VOLUME_DOWN")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VOLUME_DOWN);
                    }
                    if (line1 == "key_down VOLUME_UP")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VOLUME_UP);
                    }
                    if (line1 == "key_down MEDIA_NEXT_TRACK")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.MEDIA_NEXT_TRACK);
                    }
                    if (line1 == "key_down MEDIA_PREV_TRACK")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.MEDIA_PREV_TRACK);
                    }
                    if (line1 == "key_down MEDIA_STOP")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.MEDIA_STOP);
                    }
                    if (line1 == "key_down MEDIA_PLAY_PAUSE")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.MEDIA_PLAY_PAUSE);
                    }
                    if (line1 == "key_down LAUNCH_MAIL")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.LAUNCH_MAIL);
                    }
                    if (line1 == "key_down LAUNCH_MEDIA_SELECT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.LAUNCH_MEDIA_SELECT);
                    }
                    if (line1 == "key_down LAUNCH_APP1")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.LAUNCH_APP1);
                    }
                    if (line1 == "key_down LAUNCH_APP2")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.LAUNCH_APP2);
                    }
                    if (line1 == "key_down OEM_1")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_1);
                    }
                    if (line1 == "key_down OEM_PLUS")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_PLUS);
                    }
                    if (line1 == "key_down OEM_COMMA")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_COMMA);
                    }
                    if (line1 == "key_down OEM_MINUS")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_MINUS);
                    }
                    if (line1 == "key_down OEM_PERIOD")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_PERIOD);
                    }
                    if (line1 == "key_down OEM_2")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_2);
                    }
                    if (line1 == "key_down OEM_3")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_3);
                    }
                    if (line1 == "key_down OEM_4")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_4);
                    }
                    if (line1 == "key_down OEM_5")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_5);
                    }
                    if (line1 == "key_down OEM_6")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_6);
                    }
                    if (line1 == "key_down OEM_7")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_7);
                    }
                    if (line1 == "key_down OEM_8")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_8);
                    }
                    if (line1 == "key_down OEM_102")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_102);
                    }
                    if (line1 == "key_down PROCESSKEY")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.PROCESSKEY);
                    }
                    if (line1 == "key_down PACKET")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.PACKET);
                    }
                    if (line1 == "key_down ATTN")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.ATTN);
                    }
                    if (line1 == "key_down CRSEL")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.CRSEL);
                    }
                    if (line1 == "key_down EXSEL")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.EXSEL);
                    }
                    if (line1 == "key_down EREOF")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.EREOF);
                    }
                    if (line1 == "key_down PLAY")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.PLAY);
                    }
                    if (line1 == "key_down ZOOM")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.ZOOM);
                    }
                    if (line1 == "key_down NONAME")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NONAME);
                    }
                    if (line1 == "key_down PA1")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.PA1);
                    }
                    if (line1 == "key_down OEM_CLEAR")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_CLEAR);
                    }
                    if (line1 == "key_down XBUTTON2")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.XBUTTON2);
                    }
                    if (line1 == "key_down XBUTTON1")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.XBUTTON1);
                    }
                    if (line1 == "key_down MBUTTON")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.MBUTTON);
                    }
                    if (line1 == "key_down CANCEL")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.CANCEL);
                    }
                    if (line1 == "key_down RBUTTON")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.RBUTTON);
                    }
                    if (line1 == "key_down LBUTTON")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.LBUTTON);
                    }
                    if (line1 == "key_up VK_A")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_A);
                    }
                    if (line1 == "key_up VK_B")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_B);
                    }
                    if (line1 == "key_up VK_C")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_C);
                    }
                    if (line1 == "key_up VK_D")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_D);
                    }
                    if (line1 == "key_up VK_E")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_E);
                    }
                    if (line1 == "key_up VK_F")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_F);
                    }
                    if (line1 == "key_up VK_G")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_G);
                    }
                    if (line1 == "key_up VK_H")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_H);
                    }
                    if (line1 == "key_up VK_I")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_I);
                    }
                    if (line1 == "key_up VK_J")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_J);
                    }
                    if (line1 == "key_up VK_K")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_K);
                    }
                    if (line1 == "key_up VK_L")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_L);
                    }
                    if (line1 == "key_up VK_M")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_M);
                    }
                    if (line1 == "key_up VK_N")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_N);
                    }
                    if (line1 == "key_up VK_O")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_O);
                    }
                    if (line1 == "key_up VK_P")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_P);
                    }
                    if (line1 == "key_up VK_Q")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_Q);
                    }
                    if (line1 == "key_up VK_R")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_R);
                    }
                    if (line1 == "key_up VK_S")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_S);
                    }
                    if (line1 == "key_up VK_T")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_T);
                    }
                    if (line1 == "key_up VK_U")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_U);
                    }
                    if (line1 == "key_up VK_V")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_V);
                    }
                    if (line1 == "key_up VK_W")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_W);
                    }
                    if (line1 == "key_up VK_X")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_X);
                    }
                    if (line1 == "key_up VK_Y")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_Y);
                    }
                    if (line1 == "key_up VK_Z")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_Z);
                    }
                    if (line1 == "key_up F1")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F1);
                    }
                    if (line1 == "key_up F2")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F2);
                    }
                    if (line1 == "key_up F3")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F3);
                    }
                    if (line1 == "key_up F4")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F4);
                    }
                    if (line1 == "key_up F5")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F5);
                    }
                    if (line1 == "key_up F6")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F6);
                    }
                    if (line1 == "key_up F7")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F7);
                    }
                    if (line1 == "key_up F8")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F8);
                    }
                    if (line1 == "key_up F9")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F9);
                    }
                    if (line1 == "key_up F10")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F10);
                    }
                    if (line1 == "key_up F11")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F11);
                    }
                    if (line1 == "key_up F12")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F12);
                    }
                    if (line1 == "key_up F13")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F13);
                    }
                    if (line1 == "key_up F14")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F14);
                    }
                    if (line1 == "key_up F15")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F15);
                    }
                    if (line1 == "key_up F16")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F16);
                    }
                    if (line1 == "key_up F17")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F17);
                    }
                    if (line1 == "key_up F18")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F18);
                    }
                    if (line1 == "key_up F19")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F19);
                    }
                    if (line1 == "key_up F20")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F20);
                    }
                    if (line1 == "key_up F21")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F21);
                    }
                    if (line1 == "key_up F22")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F22);
                    }
                    if (line1 == "key_up F23")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F23);
                    }
                    if (line1 == "key_up F24")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F24);
                    }
                    if (line1 == "key_up BACK")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.BACK);
                    }
                    if (line1 == "key_up TAB")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.TAB);
                    }
                    if (line1 == "key_up CLEAR")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.CLEAR);
                    }
                    if (line1 == "key_up RETURN")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.RETURN);
                    }
                    if (line1 == "key_up SHIFT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    }
                    if (line1 == "key_up CONTROL")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.CONTROL);
                    }
                    if (line1 == "key_up MENU")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.MENU);
                    }
                    if (line1 == "key_up PAUSE")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.PAUSE);
                    }
                    if (line1 == "key_up CAPITAL")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.CAPITAL);
                    }
                    if (line1 == "key_up HANGUL")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.HANGUL);
                    }
                    if (line1 == "key_up JUNJA")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.JUNJA);
                    }
                    if (line1 == "key_up HANJA")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.HANJA);
                    }
                    if (line1 == "key_up ESCAPE")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.ESCAPE);
                    }
                    if (line1 == "key_up CONVERT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.CONVERT);
                    }
                    if (line1 == "key_up NONCONVERT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NONCONVERT);
                    }
                    if (line1 == "key_up ACCEPT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.ACCEPT);
                    }
                    if (line1 == "key_up MODECHANGE")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.MODECHANGE);
                    }
                    if (line1 == "key_up SPACE")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.SPACE);
                    }
                    if (line1 == "key_up PRIOR")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.PRIOR);
                    }
                    if (line1 == "key_up NEXT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NEXT);
                    }
                    if (line1 == "key_up END")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.END);
                    }
                    if (line1 == "key_up HOME")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.HOME);
                    }
                    if (line1 == "key_up LEFT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.LEFT);
                    }
                    if (line1 == "key_up RIGHT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.RIGHT);
                    }
                    if (line1 == "key_up DOWN")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.DOWN);
                    }
                    if (line1 == "key_up SELECT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.SELECT);
                    }
                    if (line1 == "key_up PRINT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.PRINT);
                    }
                    if (line1 == "key_up EXECUTE")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.EXECUTE);
                    }
                    if (line1 == "key_up SNAPSHOT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.SNAPSHOT);
                    }
                    if (line1 == "key_up INSERT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.INSERT);
                    }
                    if (line1 == "key_up DELETE")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.DELETE);
                    }
                    if (line1 == "key_up HELP")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.HELP);
                    }
                    if (line1 == "key_up VK_0")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_0);
                    }
                    if (line1 == "key_up VK_1")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_1);
                    }
                    if (line1 == "key_up VK_2")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_2);
                    }
                    if (line1 == "key_up VK_3")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_3);
                    }
                    if (line1 == "key_up VK_4")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_4);
                    }
                    if (line1 == "key_up VK_5")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_5);
                    }
                    if (line1 == "key_up VK_6")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_6);
                    }
                    if (line1 == "key_up VK_7")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_7);
                    }
                    if (line1 == "key_up VK_8")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_8);
                    }
                    if (line1 == "key_up VK_9")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_9);
                    }
                    if (line1 == "key_up LWIN")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.LWIN);
                    }
                    if (line1 == "key_up RWIN")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.RWIN);
                    }
                    if (line1 == "key_up SLEEP")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.SLEEP);
                    }
                    if (line1 == "key_up APPS")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.APPS);
                    }
                    if (line1 == "key_up NUMPAD0")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NUMPAD0);
                    }
                    if (line1 == "key_up NUMPAD1")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NUMPAD1);
                    }
                    if (line1 == "key_up NUMPAD2")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NUMPAD2);
                    }
                    if (line1 == "key_up NUMPAD3")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NUMPAD3);
                    }
                    if (line1 == "key_up NUMPAD4")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NUMPAD4);
                    }
                    if (line1 == "key_up NUMPAD5")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NUMPAD5);
                    }
                    if (line1 == "key_up NUMPAD6")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NUMPAD6);
                    }
                    if (line1 == "key_up NUMPAD7")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NUMPAD7);
                    }
                    if (line1 == "key_up NUMPAD8")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NUMPAD8);
                    }
                    if (line1 == "key_up NUMPAD9")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NUMPAD9);
                    }
                    if (line1 == "key_up MULTIPLY")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.MULTIPLY);
                    }
                    if (line1 == "key_up ADD")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.ADD);
                    }
                    if (line1 == "key_up SEPARATOR")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.SEPARATOR);
                    }
                    if (line1 == "key_up SUBTRACT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.SUBTRACT);
                    }
                    if (line1 == "key_up DECIMAL")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.DECIMAL);
                    }
                    if (line1 == "key_up DIVIDE")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.DIVIDE);
                    }
                    if (line1 == "key_up NUMLOCK")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NUMLOCK);
                    }
                    if (line1 == "key_up SCROLL")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.SCROLL);
                    }
                    if (line1 == "key_up LSHIFT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.LSHIFT);
                    }
                    if (line1 == "key_up RSHIFT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.RSHIFT);
                    }
                    if (line1 == "key_up LCONTROL")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.LCONTROL);
                    }
                    if (line1 == "key_up RCONTROL")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.RCONTROL);
                    }
                    if (line1 == "key_up LMENU")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.LMENU);
                    }
                    if (line1 == "key_up RMENU")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.RMENU);
                    }
                    if (line1 == "key_up BROWSER_BACK")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.BROWSER_BACK);
                    }
                    if (line1 == "key_up BROWSER_FORWARD")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.BROWSER_FORWARD);
                    }
                    if (line1 == "key_up BROWSER_REFRESH")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.BROWSER_REFRESH);
                    }
                    if (line1 == "key_up BROWSER_STOP")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.BROWSER_STOP);
                    }
                    if (line1 == "key_up BROWSER_SEARCH")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.BROWSER_SEARCH);
                    }
                    if (line1 == "key_up BROWSER_FAVORITES")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.BROWSER_FAVORITES);
                    }
                    if (line1 == "key_up BROWSER_HOME")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.BROWSER_HOME);
                    }
                    if (line1 == "key_up VOLUME_MUTE")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VOLUME_MUTE);
                    }
                    if (line1 == "key_up VOLUME_DOWN")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VOLUME_DOWN);
                    }
                    if (line1 == "key_up VOLUME_UP")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VOLUME_UP);
                    }
                    if (line1 == "key_up MEDIA_NEXT_TRACK")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.MEDIA_NEXT_TRACK);
                    }
                    if (line1 == "key_up MEDIA_PREV_TRACK")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.MEDIA_PREV_TRACK);
                    }
                    if (line1 == "key_up MEDIA_STOP")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.MEDIA_STOP);
                    }
                    if (line1 == "key_up MEDIA_PLAY_PAUSE")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.MEDIA_PLAY_PAUSE);
                    }
                    if (line1 == "key_up LAUNCH_MAIL")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.LAUNCH_MAIL);
                    }
                    if (line1 == "key_up LAUNCH_MEDIA_SELECT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.LAUNCH_MEDIA_SELECT);
                    }
                    if (line1 == "key_up LAUNCH_APP1")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.LAUNCH_APP1);
                    }
                    if (line1 == "key_up LAUNCH_APP2")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.LAUNCH_APP2);
                    }
                    if (line1 == "key_up OEM_1")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_1);
                    }
                    if (line1 == "key_up OEM_PLUS")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_PLUS);
                    }
                    if (line1 == "key_up OEM_COMMA")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_COMMA);
                    }
                    if (line1 == "key_up OEM_MINUS")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_MINUS);
                    }
                    if (line1 == "key_up OEM_PERIOD")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_PERIOD);
                    }
                    if (line1 == "key_up OEM_2")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_2);
                    }
                    if (line1 == "key_up OEM_3")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_3);
                    }
                    if (line1 == "key_up OEM_4")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_4);
                    }
                    if (line1 == "key_up OEM_5")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_5);
                    }
                    if (line1 == "key_up OEM_6")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_6);
                    }
                    if (line1 == "key_up OEM_7")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_7);
                    }
                    if (line1 == "key_up OEM_8")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_8);
                    }
                    if (line1 == "key_up OEM_102")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_102);
                    }
                    if (line1 == "key_up PROCESSKEY")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.PROCESSKEY);
                    }
                    if (line1 == "key_up PACKET")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.PACKET);
                    }
                    if (line1 == "key_up ATTN")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.ATTN);
                    }
                    if (line1 == "key_up CRSEL")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.CRSEL);
                    }
                    if (line1 == "key_up EXSEL")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.EXSEL);
                    }
                    if (line1 == "key_up EREOF")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.EREOF);
                    }
                    if (line1 == "key_up PLAY")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.PLAY);
                    }
                    if (line1 == "key_up ZOOM")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.ZOOM);
                    }
                    if (line1 == "key_up NONAME")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NONAME);
                    }
                    if (line1 == "key_up PA1")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.PA1);
                    }
                    if (line1 == "key_up OEM_CLEAR")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_CLEAR);
                    }
                    if (line1 == "key_up XBUTTON2")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.XBUTTON2);
                    }
                    if (line1 == "key_up XBUTTON1")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.XBUTTON1);
                    }
                    if (line1 == "key_up MBUTTON")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.MBUTTON);
                    }
                    if (line1 == "key_up CANCEL")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.CANCEL);
                    }
                    if (line1 == "key_up RBUTTON")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.RBUTTON);
                    }
                    if (line1 == "key_up LBUTTON")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.LBUTTON);
                    }
                    if (line1.Contains("LeftButtonClick"))
                    {
                        var part2 = line1.Substring(line1.LastIndexOf(':') + 1);
                        string part1 = line1.Split(':')[1];
                        uint Xaxis = uint.Parse(part1);
                        uint Yaxis = uint.Parse(part2);
                        int Xaxis1 = int.Parse(part1);
                        int Yaxis1 = int.Parse(part2);
                        Cursor.Position = new Point(Xaxis1, Yaxis1);
                        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, Xaxis, Yaxis, 0, 0);
                    }
                    if (line1.Contains("LeftButtonDoubleClick"))
                    {
                        var part2 = line1.Substring(line1.LastIndexOf(':') + 1);
                        string part1 = line1.Split(':')[1];
                        uint Xaxis = uint.Parse(part1);
                        uint Yaxis = uint.Parse(part2);
                        int Xaxis1 = int.Parse(part1);
                        int Yaxis1 = int.Parse(part2);
                        Cursor.Position = new Point(Xaxis1, Yaxis1);
                        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, Xaxis, Yaxis, 0, 0);
                        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, Xaxis, Yaxis, 0, 0);
                    }
                    if (line1.Contains("LeftButtonDown"))
                    {
                        var part2 = line1.Substring(line1.LastIndexOf(':') + 1);
                        string part1 = line1.Split(':')[1];
                        uint Xaxis = uint.Parse(part1);
                        uint Yaxis = uint.Parse(part2);
                        int Xaxis1 = int.Parse(part1);
                        int Yaxis1 = int.Parse(part2);
                        Cursor.Position = new Point(Xaxis1, Yaxis1);
                        mouse_event(MOUSEEVENTF_LEFTDOWN, Xaxis, Yaxis, 0, 0);
                    }
                    if (line1.Contains("LeftButtonUp"))
                    {
                        var part2 = line1.Substring(line1.LastIndexOf(':') + 1);
                        string part1 = line1.Split(':')[1];
                        uint Xaxis = uint.Parse(part1);
                        uint Yaxis = uint.Parse(part2);
                        int Xaxis1 = int.Parse(part1);
                        int Yaxis1 = int.Parse(part2);
                        Cursor.Position = new Point(Xaxis1, Yaxis1);
                        mouse_event(MOUSEEVENTF_LEFTUP, Xaxis, Yaxis, 0, 0);
                    }
                    if (line1.Contains("RightButtonClick"))
                    {
                        var part2 = line1.Substring(line1.LastIndexOf(':') + 1);
                        string part1 = line1.Split(':')[1];
                        uint Xaxis = uint.Parse(part1);
                        uint Yaxis = uint.Parse(part2);
                        int Xaxis1 = int.Parse(part1);
                        int Yaxis1 = int.Parse(part2);
                        Cursor.Position = new Point(Xaxis1, Yaxis1);
                        mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, Xaxis, Yaxis, 0, 0);
                    }
                    if (line1.Contains("RightButtonDoubleClick"))
                    {
                        var part2 = line1.Substring(line1.LastIndexOf(':') + 1);
                        string part1 = line1.Split(':')[1];
                        uint Xaxis = uint.Parse(part1);
                        uint Yaxis = uint.Parse(part2);
                        int Xaxis1 = int.Parse(part1);
                        int Yaxis1 = int.Parse(part2);
                        Cursor.Position = new Point(Xaxis1, Yaxis1);
                        mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, Xaxis, Yaxis, 0, 0);
                        mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, Xaxis, Yaxis, 0, 0);
                    }
                    if (line1.Contains("RightButtonDown"))
                    {
                        var part2 = line1.Substring(line1.LastIndexOf(':') + 1);
                        string part1 = line1.Split(':')[1];
                        uint Xaxis = uint.Parse(part1);
                        uint Yaxis = uint.Parse(part2);
                        int Xaxis1 = int.Parse(part1);
                        int Yaxis1 = int.Parse(part2);
                        Cursor.Position = new Point(Xaxis1, Yaxis1);
                        mouse_event(MOUSEEVENTF_RIGHTDOWN, Xaxis, Yaxis, 0, 0);
                    }
                    if (line1.Contains("RightButtonUp"))
                    {
                        var part2 = line1.Substring(line1.LastIndexOf(':') + 1);
                        string part1 = line1.Split(':')[1];
                        uint Xaxis = uint.Parse(part1);
                        uint Yaxis = uint.Parse(part2);
                        int Xaxis1 = int.Parse(part1);
                        int Yaxis1 = int.Parse(part2);
                        Cursor.Position = new Point(Xaxis1, Yaxis1);
                        mouse_event(MOUSEEVENTF_RIGHTUP, Xaxis, Yaxis, 0, 0);
                    }
                    if (line1.Contains("MoveMouseBy"))
                    {
                        var part2 = line1.Substring(line1.LastIndexOf(':') + 1);
                        string part1 = line1.Split(':')[1];
                        int Xaxis1 = int.Parse(part1);
                        int Yaxis1 = int.Parse(part2);
                        sim.Mouse.MoveMouseBy(Xaxis1, Yaxis1);
                    }
                    if (line1.Contains("MoveMouseTo"))
                    {
                        var part2 = line1.Substring(line1.LastIndexOf(':') + 1);
                        string part1 = line1.Split(':')[1];
                        int Xaxis1 = int.Parse(part1);
                        int Yaxis1 = int.Parse(part2);
                        double startX = 65535 * Xaxis1 / Screen.PrimaryScreen.Bounds.Width;
                        double startY = 65535 * Yaxis1 / Screen.PrimaryScreen.Bounds.Height;
                        sim.Mouse.MoveMouseTo(startX, startY);
                    }
                    if (line1.Contains("MoveMouseToPositionOnVirtualDesktop"))
                    {
                        var part2 = line1.Substring(line1.LastIndexOf(':') + 1);
                        string part1 = line1.Split(':')[1];
                        int Xaxis1 = int.Parse(part1);
                        int Yaxis1 = int.Parse(part2);
                        double startX = 65535 * Xaxis1 / Screen.PrimaryScreen.Bounds.Width;
                        double startY = 65535 * Yaxis1 / Screen.PrimaryScreen.Bounds.Height;
                        sim.Mouse.MoveMouseToPositionOnVirtualDesktop(startX, startY);
                    }
                    if (line1.Contains("VerticalScroll"))
                    {
                        var part2 = line1.Substring(line1.LastIndexOf(':') + 1);
                        string part1 = line1.Split(':')[1];
                        int scrollint = int.Parse(part1);
                        sim.Mouse.VerticalScroll(scrollint);
                    }
                    if (line1.Contains("XButtonClick"))
                    {
                        var part2 = line1.Substring(line1.LastIndexOf(':') + 1);
                        string part1 = line1.Split(':')[1];
                        int scrollint = int.Parse(part1);
                        sim.Mouse.XButtonClick(scrollint);
                    }
                    if (line1.Contains("XButtonDoubleClick"))
                    {
                        var part2 = line1.Substring(line1.LastIndexOf(':') + 1);
                        string part1 = line1.Split(':')[1];
                        int scrollint = int.Parse(part1);
                        sim.Mouse.XButtonDoubleClick(scrollint);
                        sim.Mouse.XButtonDoubleClick(scrollint);
                    }
                    if (line1.Contains("XButtonDown"))
                    {
                        var part2 = line1.Substring(line1.LastIndexOf(':') + 1);
                        string part1 = line1.Split(':')[1];
                        int scrollint = int.Parse(part1);
                        sim.Mouse.XButtonDown(scrollint);
                    }
                    if (line1.Contains("XButtonUp"))
                    {
                        var part2 = line1.Substring(line1.LastIndexOf(':') + 1);
                        string part1 = line1.Split(':')[1];
                        int scrollint = int.Parse(part1);
                        sim.Mouse.XButtonUp(scrollint);
                    }
                    if (line1.Contains("wait"))
                    {
                        var result = line1.Substring(line1.LastIndexOf(':') + 1);
                        Thread.Sleep(int.Parse(result));
                    }
                }
            }
        }
        private void runconfig()
        {
            using (StringReader reader = new StringReader(remembermebind1))
            {
                string line = remembermebind1;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line == "key_press VK_A")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_A);
                    }
                    if (line == "key_press VK_B")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_B);
                    }
                    if (line == "key_press VK_C")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_C);
                    }
                    if (line == "key_press VK_D")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_D);
                    }
                    if (line == "key_press VK_E")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_E);
                    }
                    if (line == "key_press VK_F")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_F);
                    }
                    if (line == "key_press VK_G")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_G);
                    }
                    if (line == "key_press VK_H")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_H);
                    }
                    if (line == "key_press VK_I")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_I);
                    }
                    if (line == "key_press VK_J")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_J);
                    }
                    if (line == "key_press VK_K")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_K);
                    }
                    if (line == "key_press VK_L")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_L);
                    }
                    if (line == "key_press VK_M")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_M);
                    }
                    if (line == "key_press VK_N")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_N);
                    }
                    if (line == "key_press VK_O")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_O);
                    }
                    if (line == "key_press VK_P")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_P);
                    }
                    if (line == "key_press VK_Q")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_Q);
                    }
                    if (line == "key_press VK_R")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_R);
                    }
                    if (line == "key_press VK_S")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_S);
                    }
                    if (line == "key_press VK_T")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_T);
                    }
                    if (line == "key_press VK_U")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_U);
                    }
                    if (line == "key_press VK_V")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_V);
                    }
                    if (line == "key_press VK_W")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_W);
                    }
                    if (line == "key_press VK_X")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_X);
                    }
                    if (line == "key_press VK_Y")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_Y);
                    }
                    if (line == "key_press VK_Z")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_Z);
                    }
                    if (line == "key_press F1")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F1);
                    }
                    if (line == "key_press F2")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F2);
                    }
                    if (line == "key_press F3")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F3);
                    }
                    if (line == "key_press F4")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F4);
                    }
                    if (line == "key_press F5")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F5);
                    }
                    if (line == "key_press F6")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F6);
                    }
                    if (line == "key_press F7")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F7);
                    }
                    if (line == "key_press F8")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F8);
                    }
                    if (line == "key_press F9")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F9);
                    }
                    if (line == "key_press F10")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F10);
                    }
                    if (line == "key_press F11")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F11);
                    }
                    if (line == "key_press F12")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F12);
                    }
                    if (line == "key_press F13")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F13);
                    }
                    if (line == "key_press F14")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F14);
                    }
                    if (line == "key_press F15")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F15);
                    }
                    if (line == "key_press F16")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F16);
                    }
                    if (line == "key_press F17")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F17);
                    }
                    if (line == "key_press F18")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F18);
                    }
                    if (line == "key_press F19")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F19);
                    }
                    if (line == "key_press F20")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F20);
                    }
                    if (line == "key_press F21")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F21);
                    }
                    if (line == "key_press F22")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F22);
                    }
                    if (line == "key_press F23")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F23);
                    }
                    if (line == "key_press F24")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.F24);
                    }
                    if (line == "key_press BACK")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.BACK);
                    }
                    if (line == "key_press TAB")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.TAB);
                    }
                    if (line == "key_press CLEAR")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.CLEAR);
                    }
                    if (line == "key_press RETURN")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                    }
                    if (line == "key_press SHIFT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.SHIFT);
                    }
                    if (line == "key_press CONTROL")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.CONTROL);
                    }
                    if (line == "key_press MENU")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.MENU);
                    }
                    if (line == "key_press PAUSE")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.PAUSE);
                    }
                    if (line == "key_press CAPITAL")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.CAPITAL);
                    }
                    if (line == "key_press HANGUL")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.HANGUL);
                    }
                    if (line == "key_press JUNJA")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.JUNJA);
                    }
                    if (line == "key_press HANJA")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.HANJA);
                    }
                    if (line == "key_press ESCAPE")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.ESCAPE);
                    }
                    if (line == "key_press CONVERT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.CONVERT);
                    }
                    if (line == "key_press NONCONVERT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NONCONVERT);
                    }
                    if (line == "key_press ACCEPT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.ACCEPT);
                    }
                    if (line == "key_press MODECHANGE")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.MODECHANGE);
                    }
                    if (line == "key_press SPACE")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.SPACE);
                    }
                    if (line == "key_press PRIOR")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.PRIOR);
                    }
                    if (line == "key_press NEXT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NEXT);
                    }
                    if (line == "key_press END")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.END);
                    }
                    if (line == "key_press HOME")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.HOME);
                    }
                    if (line == "key_press LEFT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.LEFT);
                    }
                    if (line == "key_press RIGHT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.RIGHT);
                    }
                    if (line == "key_press DOWN")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.DOWN);
                    }
                    if (line == "key_press SELECT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.SELECT);
                    }
                    if (line == "key_press PRINT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.PRINT);
                    }
                    if (line == "key_press EXECUTE")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.EXECUTE);
                    }
                    if (line == "key_press SNAPSHOT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.SNAPSHOT);
                    }
                    if (line == "key_press INSERT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.INSERT);
                    }
                    if (line == "key_press DELETE")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.DELETE);
                    }
                    if (line == "key_press HELP")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.HELP);
                    }
                    if (line == "key_press VK_0")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_0);
                    }
                    if (line == "key_press VK_1")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_1);
                    }
                    if (line == "key_press VK_2")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_2);
                    }
                    if (line == "key_press VK_3")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_3);
                    }
                    if (line == "key_press VK_4")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_4);
                    }
                    if (line == "key_press VK_5")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_5);
                    }
                    if (line == "key_press VK_6")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_6);
                    }
                    if (line == "key_press VK_7")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_7);
                    }
                    if (line == "key_press VK_8")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_8);
                    }
                    if (line == "key_press VK_9")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VK_9);
                    }
                    if (line == "key_press LWIN")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.LWIN);
                    }
                    if (line == "key_press RWIN")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.RWIN);
                    }
                    if (line == "key_press SLEEP")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.SLEEP);
                    }
                    if (line == "key_press APPS")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.APPS);
                    }
                    if (line == "key_press NUMPAD0")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NUMPAD0);
                    }
                    if (line == "key_press NUMPAD1")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NUMPAD1);
                    }
                    if (line == "key_press NUMPAD2")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NUMPAD2);
                    }
                    if (line == "key_press NUMPAD3")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NUMPAD3);
                    }
                    if (line == "key_press NUMPAD4")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NUMPAD4);
                    }
                    if (line == "key_press NUMPAD5")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NUMPAD5);
                    }
                    if (line == "key_press NUMPAD6")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NUMPAD6);
                    }
                    if (line == "key_press NUMPAD7")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NUMPAD7);
                    }
                    if (line == "key_press NUMPAD8")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NUMPAD8);
                    }
                    if (line == "key_press NUMPAD9")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NUMPAD9);
                    }
                    if (line == "key_press MULTIPLY")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.MULTIPLY);
                    }
                    if (line == "key_press ADD")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.ADD);
                    }
                    if (line == "key_press SEPARATOR")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.SEPARATOR);
                    }
                    if (line == "key_press SUBTRACT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.SUBTRACT);
                    }
                    if (line == "key_press DECIMAL")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.DECIMAL);
                    }
                    if (line == "key_press DIVIDE")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.DIVIDE);
                    }
                    if (line == "key_press NUMLOCK")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NUMLOCK);
                    }
                    if (line == "key_press SCROLL")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.SCROLL);
                    }
                    if (line == "key_press LSHIFT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.LSHIFT);
                    }
                    if (line == "key_press RSHIFT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.RSHIFT);
                    }
                    if (line == "key_press LCONTROL")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.LCONTROL);
                    }
                    if (line == "key_press RCONTROL")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.RCONTROL);
                    }
                    if (line == "key_press LMENU")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.LMENU);
                    }
                    if (line == "key_press RMENU")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.RMENU);
                    }
                    if (line == "key_press BROWSER_BACK")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.BROWSER_BACK);
                    }
                    if (line == "key_press BROWSER_FORWARD")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.BROWSER_FORWARD);
                    }
                    if (line == "key_press BROWSER_REFRESH")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.BROWSER_REFRESH);
                    }
                    if (line == "key_press BROWSER_STOP")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.BROWSER_STOP);
                    }
                    if (line == "key_press BROWSER_SEARCH")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.BROWSER_SEARCH);
                    }
                    if (line == "key_press BROWSER_FAVORITES")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.BROWSER_FAVORITES);
                    }
                    if (line == "key_press BROWSER_HOME")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.BROWSER_HOME);
                    }
                    if (line == "key_press VOLUME_MUTE")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VOLUME_MUTE);
                    }
                    if (line == "key_press VOLUME_DOWN")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VOLUME_DOWN);
                    }
                    if (line == "key_press VOLUME_UP")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.VOLUME_UP);
                    }
                    if (line == "key_press MEDIA_NEXT_TRACK")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.MEDIA_NEXT_TRACK);
                    }
                    if (line == "key_press MEDIA_PREV_TRACK")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.MEDIA_PREV_TRACK);
                    }
                    if (line == "key_press MEDIA_STOP")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.MEDIA_STOP);
                    }
                    if (line == "key_press MEDIA_PLAY_PAUSE")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.MEDIA_PLAY_PAUSE);
                    }
                    if (line == "key_press LAUNCH_MAIL")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.LAUNCH_MAIL);
                    }
                    if (line == "key_press LAUNCH_MEDIA_SELECT")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.LAUNCH_MEDIA_SELECT);
                    }
                    if (line == "key_press LAUNCH_APP1")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.LAUNCH_APP1);
                    }
                    if (line == "key_press LAUNCH_APP2")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.LAUNCH_APP2);
                    }
                    if (line == "key_press OEM_1")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_1);
                    }
                    if (line == "key_press OEM_PLUS")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_PLUS);
                    }
                    if (line == "key_press OEM_COMMA")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_COMMA);
                    }
                    if (line == "key_press OEM_MINUS")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_MINUS);
                    }
                    if (line == "key_press OEM_PERIOD")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_PERIOD);
                    }
                    if (line == "key_press OEM_2")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_2);
                    }
                    if (line == "key_press OEM_3")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_3);
                    }
                    if (line == "key_press OEM_4")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_4);
                    }
                    if (line == "key_press OEM_5")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_5);
                    }
                    if (line == "key_press OEM_6")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_6);
                    }
                    if (line == "key_press OEM_7")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_7);
                    }
                    if (line == "key_press OEM_8")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_8);
                    }
                    if (line == "key_press OEM_102")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_102);
                    }
                    if (line == "key_press PROCESSKEY")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.PROCESSKEY);
                    }
                    if (line == "key_press PACKET")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.PACKET);
                    }
                    if (line == "key_press ATTN")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.ATTN);
                    }
                    if (line == "key_press CRSEL")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.CRSEL);
                    }
                    if (line == "key_press EXSEL")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.EXSEL);
                    }
                    if (line == "key_press EREOF")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.EREOF);
                    }
                    if (line == "key_press PLAY")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.PLAY);
                    }
                    if (line == "key_press ZOOM")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.ZOOM);
                    }
                    if (line == "key_press NONAME")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.NONAME);
                    }
                    if (line == "key_press PA1")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.PA1);
                    }
                    if (line == "key_press OEM_CLEAR")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.OEM_CLEAR);
                    }
                    if (line == "key_press XBUTTON2")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.XBUTTON2);
                    }
                    if (line == "key_press XBUTTON1")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.XBUTTON1);
                    }
                    if (line == "key_press MBUTTON")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.MBUTTON);
                    }
                    if (line == "key_press CANCEL")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.CANCEL);
                    }
                    if (line == "key_press RBUTTON")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.RBUTTON);
                    }
                    if (line == "key_press LBUTTON")
                    {
                        sim.Keyboard.KeyPress(VirtualKeyCode.LBUTTON);
                    }
                    if (line == "key_down VK_A")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_A);
                    }
                    if (line == "key_down VK_B")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_B);
                    }
                    if (line == "key_down VK_C")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_C);
                    }
                    if (line == "key_down VK_D")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_D);
                    }
                    if (line == "key_down VK_E")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_E);
                    }
                    if (line == "key_down VK_F")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_F);
                    }
                    if (line == "key_down VK_G")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_G);
                    }
                    if (line == "key_down VK_H")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_H);
                    }
                    if (line == "key_down VK_I")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_I);
                    }
                    if (line == "key_down VK_J")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_J);
                    }
                    if (line == "key_down VK_K")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_K);
                    }
                    if (line == "key_down VK_L")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_L);
                    }
                    if (line == "key_down VK_M")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_M);
                    }
                    if (line == "key_down VK_N")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_N);
                    }
                    if (line == "key_down VK_O")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_O);
                    }
                    if (line == "key_down VK_P")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_P);
                    }
                    if (line == "key_down VK_Q")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_Q);
                    }
                    if (line == "key_down VK_R")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_R);
                    }
                    if (line == "key_down VK_S")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_S);
                    }
                    if (line == "key_down VK_T")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_T);
                    }
                    if (line == "key_down VK_U")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_U);
                    }
                    if (line == "key_down VK_V")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_V);
                    }
                    if (line == "key_down VK_W")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_W);
                    }
                    if (line == "key_down VK_X")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_X);
                    }
                    if (line == "key_down VK_Y")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_Y);
                    }
                    if (line == "key_down VK_Z")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_Z);
                    }
                    if (line == "key_down F1")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F1);
                    }
                    if (line == "key_down F2")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F2);
                    }
                    if (line == "key_down F3")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F3);
                    }
                    if (line == "key_down F4")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F4);
                    }
                    if (line == "key_down F5")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F5);
                    }
                    if (line == "key_down F6")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F6);
                    }
                    if (line == "key_down F7")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F7);
                    }
                    if (line == "key_down F8")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F8);
                    }
                    if (line == "key_down F9")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F9);
                    }
                    if (line == "key_down F10")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F10);
                    }
                    if (line == "key_down F11")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F11);
                    }
                    if (line == "key_down F12")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F12);
                    }
                    if (line == "key_down F13")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F13);
                    }
                    if (line == "key_down F14")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F14);
                    }
                    if (line == "key_down F15")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F15);
                    }
                    if (line == "key_down F16")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F16);
                    }
                    if (line == "key_down F17")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F17);
                    }
                    if (line == "key_down F18")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F18);
                    }
                    if (line == "key_down F19")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F19);
                    }
                    if (line == "key_down F20")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F20);
                    }
                    if (line == "key_down F21")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F21);
                    }
                    if (line == "key_down F22")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F22);
                    }
                    if (line == "key_down F23")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F23);
                    }
                    if (line == "key_down F24")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.F24);
                    }
                    if (line == "key_down BACK")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.BACK);
                    }
                    if (line == "key_down TAB")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.TAB);
                    }
                    if (line == "key_down CLEAR")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.CLEAR);
                    }
                    if (line == "key_down RETURN")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.RETURN);
                    }
                    if (line == "key_down SHIFT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
                    }
                    if (line == "key_down CONTROL")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.CONTROL);
                    }
                    if (line == "key_down MENU")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.MENU);
                    }
                    if (line == "key_down PAUSE")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.PAUSE);
                    }
                    if (line == "key_down CAPITAL")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.CAPITAL);
                    }
                    if (line == "key_down HANGUL")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.HANGUL);
                    }
                    if (line == "key_down JUNJA")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.JUNJA);
                    }
                    if (line == "key_down HANJA")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.HANJA);
                    }
                    if (line == "key_down ESCAPE")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.ESCAPE);
                    }
                    if (line == "key_down CONVERT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.CONVERT);
                    }
                    if (line == "key_down NONCONVERT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NONCONVERT);
                    }
                    if (line == "key_down ACCEPT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.ACCEPT);
                    }
                    if (line == "key_down MODECHANGE")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.MODECHANGE);
                    }
                    if (line == "key_down SPACE")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.SPACE);
                    }
                    if (line == "key_down PRIOR")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.PRIOR);
                    }
                    if (line == "key_down NEXT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NEXT);
                    }
                    if (line == "key_down END")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.END);
                    }
                    if (line == "key_down HOME")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.HOME);
                    }
                    if (line == "key_down LEFT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.LEFT);
                    }
                    if (line == "key_down RIGHT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.RIGHT);
                    }
                    if (line == "key_down DOWN")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.DOWN);
                    }
                    if (line == "key_down SELECT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.SELECT);
                    }
                    if (line == "key_down PRINT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.PRINT);
                    }
                    if (line == "key_down EXECUTE")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.EXECUTE);
                    }
                    if (line == "key_down SNAPSHOT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.SNAPSHOT);
                    }
                    if (line == "key_down INSERT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.INSERT);
                    }
                    if (line == "key_down DELETE")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.DELETE);
                    }
                    if (line == "key_down HELP")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.HELP);
                    }
                    if (line == "key_down VK_0")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_0);
                    }
                    if (line == "key_down VK_1")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_1);
                    }
                    if (line == "key_down VK_2")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_2);
                    }
                    if (line == "key_down VK_3")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_3);
                    }
                    if (line == "key_down VK_4")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_4);
                    }
                    if (line == "key_down VK_5")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_5);
                    }
                    if (line == "key_down VK_6")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_6);
                    }
                    if (line == "key_down VK_7")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_7);
                    }
                    if (line == "key_down VK_8")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_8);
                    }
                    if (line == "key_down VK_9")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VK_9);
                    }
                    if (line == "key_down LWIN")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.LWIN);
                    }
                    if (line == "key_down RWIN")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.RWIN);
                    }
                    if (line == "key_down SLEEP")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.SLEEP);
                    }
                    if (line == "key_down APPS")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.APPS);
                    }
                    if (line == "key_down NUMPAD0")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NUMPAD0);
                    }
                    if (line == "key_down NUMPAD1")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NUMPAD1);
                    }
                    if (line == "key_down NUMPAD2")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NUMPAD2);
                    }
                    if (line == "key_down NUMPAD3")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NUMPAD3);
                    }
                    if (line == "key_down NUMPAD4")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NUMPAD4);
                    }
                    if (line == "key_down NUMPAD5")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NUMPAD5);
                    }
                    if (line == "key_down NUMPAD6")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NUMPAD6);
                    }
                    if (line == "key_down NUMPAD7")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NUMPAD7);
                    }
                    if (line == "key_down NUMPAD8")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NUMPAD8);
                    }
                    if (line == "key_down NUMPAD9")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NUMPAD9);
                    }
                    if (line == "key_down MULTIPLY")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.MULTIPLY);
                    }
                    if (line == "key_down ADD")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.ADD);
                    }
                    if (line == "key_down SEPARATOR")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.SEPARATOR);
                    }
                    if (line == "key_down SUBTRACT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.SUBTRACT);
                    }
                    if (line == "key_down DECIMAL")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.DECIMAL);
                    }
                    if (line == "key_down DIVIDE")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.DIVIDE);
                    }
                    if (line == "key_down NUMLOCK")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NUMLOCK);
                    }
                    if (line == "key_down SCROLL")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.SCROLL);
                    }
                    if (line == "key_down LSHIFT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.LSHIFT);
                    }
                    if (line == "key_down RSHIFT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.RSHIFT);
                    }
                    if (line == "key_down LCONTROL")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.LCONTROL);
                    }
                    if (line == "key_down RCONTROL")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.RCONTROL);
                    }
                    if (line == "key_down LMENU")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.LMENU);
                    }
                    if (line == "key_down RMENU")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.RMENU);
                    }
                    if (line == "key_down BROWSER_BACK")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.BROWSER_BACK);
                    }
                    if (line == "key_down BROWSER_FORWARD")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.BROWSER_FORWARD);
                    }
                    if (line == "key_down BROWSER_REFRESH")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.BROWSER_REFRESH);
                    }
                    if (line == "key_down BROWSER_STOP")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.BROWSER_STOP);
                    }
                    if (line == "key_down BROWSER_SEARCH")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.BROWSER_SEARCH);
                    }
                    if (line == "key_down BROWSER_FAVORITES")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.BROWSER_FAVORITES);
                    }
                    if (line == "key_down BROWSER_HOME")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.BROWSER_HOME);
                    }
                    if (line == "key_down VOLUME_MUTE")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VOLUME_MUTE);
                    }
                    if (line == "key_down VOLUME_DOWN")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VOLUME_DOWN);
                    }
                    if (line == "key_down VOLUME_UP")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.VOLUME_UP);
                    }
                    if (line == "key_down MEDIA_NEXT_TRACK")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.MEDIA_NEXT_TRACK);
                    }
                    if (line == "key_down MEDIA_PREV_TRACK")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.MEDIA_PREV_TRACK);
                    }
                    if (line == "key_down MEDIA_STOP")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.MEDIA_STOP);
                    }
                    if (line == "key_down MEDIA_PLAY_PAUSE")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.MEDIA_PLAY_PAUSE);
                    }
                    if (line == "key_down LAUNCH_MAIL")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.LAUNCH_MAIL);
                    }
                    if (line == "key_down LAUNCH_MEDIA_SELECT")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.LAUNCH_MEDIA_SELECT);
                    }
                    if (line == "key_down LAUNCH_APP1")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.LAUNCH_APP1);
                    }
                    if (line == "key_down LAUNCH_APP2")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.LAUNCH_APP2);
                    }
                    if (line == "key_down OEM_1")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_1);
                    }
                    if (line == "key_down OEM_PLUS")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_PLUS);
                    }
                    if (line == "key_down OEM_COMMA")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_COMMA);
                    }
                    if (line == "key_down OEM_MINUS")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_MINUS);
                    }
                    if (line == "key_down OEM_PERIOD")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_PERIOD);
                    }
                    if (line == "key_down OEM_2")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_2);
                    }
                    if (line == "key_down OEM_3")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_3);
                    }
                    if (line == "key_down OEM_4")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_4);
                    }
                    if (line == "key_down OEM_5")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_5);
                    }
                    if (line == "key_down OEM_6")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_6);
                    }
                    if (line == "key_down OEM_7")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_7);
                    }
                    if (line == "key_down OEM_8")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_8);
                    }
                    if (line == "key_down OEM_102")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_102);
                    }
                    if (line == "key_down PROCESSKEY")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.PROCESSKEY);
                    }
                    if (line == "key_down PACKET")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.PACKET);
                    }
                    if (line == "key_down ATTN")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.ATTN);
                    }
                    if (line == "key_down CRSEL")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.CRSEL);
                    }
                    if (line == "key_down EXSEL")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.EXSEL);
                    }
                    if (line == "key_down EREOF")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.EREOF);
                    }
                    if (line == "key_down PLAY")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.PLAY);
                    }
                    if (line == "key_down ZOOM")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.ZOOM);
                    }
                    if (line == "key_down NONAME")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.NONAME);
                    }
                    if (line == "key_down PA1")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.PA1);
                    }
                    if (line == "key_down OEM_CLEAR")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.OEM_CLEAR);
                    }
                    if (line == "key_down XBUTTON2")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.XBUTTON2);
                    }
                    if (line == "key_down XBUTTON1")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.XBUTTON1);
                    }
                    if (line == "key_down MBUTTON")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.MBUTTON);
                    }
                    if (line == "key_down CANCEL")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.CANCEL);
                    }
                    if (line == "key_down RBUTTON")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.RBUTTON);
                    }
                    if (line == "key_down LBUTTON")
                    {
                        sim.Keyboard.KeyDown(VirtualKeyCode.LBUTTON);
                    }
                    if (line == "key_up VK_A")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_A);
                    }
                    if (line == "key_up VK_B")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_B);
                    }
                    if (line == "key_up VK_C")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_C);
                    }
                    if (line == "key_up VK_D")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_D);
                    }
                    if (line == "key_up VK_E")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_E);
                    }
                    if (line == "key_up VK_F")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_F);
                    }
                    if (line == "key_up VK_G")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_G);
                    }
                    if (line == "key_up VK_H")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_H);
                    }
                    if (line == "key_up VK_I")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_I);
                    }
                    if (line == "key_up VK_J")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_J);
                    }
                    if (line == "key_up VK_K")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_K);
                    }
                    if (line == "key_up VK_L")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_L);
                    }
                    if (line == "key_up VK_M")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_M);
                    }
                    if (line == "key_up VK_N")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_N);
                    }
                    if (line == "key_up VK_O")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_O);
                    }
                    if (line == "key_up VK_P")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_P);
                    }
                    if (line == "key_up VK_Q")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_Q);
                    }
                    if (line == "key_up VK_R")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_R);
                    }
                    if (line == "key_up VK_S")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_S);
                    }
                    if (line == "key_up VK_T")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_T);
                    }
                    if (line == "key_up VK_U")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_U);
                    }
                    if (line == "key_up VK_V")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_V);
                    }
                    if (line == "key_up VK_W")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_W);
                    }
                    if (line == "key_up VK_X")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_X);
                    }
                    if (line == "key_up VK_Y")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_Y);
                    }
                    if (line == "key_up VK_Z")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_Z);
                    }
                    if (line == "key_up F1")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F1);
                    }
                    if (line == "key_up F2")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F2);
                    }
                    if (line == "key_up F3")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F3);
                    }
                    if (line == "key_up F4")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F4);
                    }
                    if (line == "key_up F5")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F5);
                    }
                    if (line == "key_up F6")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F6);
                    }
                    if (line == "key_up F7")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F7);
                    }
                    if (line == "key_up F8")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F8);
                    }
                    if (line == "key_up F9")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F9);
                    }
                    if (line == "key_up F10")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F10);
                    }
                    if (line == "key_up F11")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F11);
                    }
                    if (line == "key_up F12")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F12);
                    }
                    if (line == "key_up F13")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F13);
                    }
                    if (line == "key_up F14")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F14);
                    }
                    if (line == "key_up F15")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F15);
                    }
                    if (line == "key_up F16")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F16);
                    }
                    if (line == "key_up F17")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F17);
                    }
                    if (line == "key_up F18")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F18);
                    }
                    if (line == "key_up F19")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F19);
                    }
                    if (line == "key_up F20")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F20);
                    }
                    if (line == "key_up F21")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F21);
                    }
                    if (line == "key_up F22")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F22);
                    }
                    if (line == "key_up F23")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F23);
                    }
                    if (line == "key_up F24")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.F24);
                    }
                    if (line == "key_up BACK")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.BACK);
                    }
                    if (line == "key_up TAB")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.TAB);
                    }
                    if (line == "key_up CLEAR")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.CLEAR);
                    }
                    if (line == "key_up RETURN")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.RETURN);
                    }
                    if (line == "key_up SHIFT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.SHIFT);
                    }
                    if (line == "key_up CONTROL")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.CONTROL);
                    }
                    if (line == "key_up MENU")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.MENU);
                    }
                    if (line == "key_up PAUSE")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.PAUSE);
                    }
                    if (line == "key_up CAPITAL")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.CAPITAL);
                    }
                    if (line == "key_up HANGUL")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.HANGUL);
                    }
                    if (line == "key_up JUNJA")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.JUNJA);
                    }
                    if (line == "key_up HANJA")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.HANJA);
                    }
                    if (line == "key_up ESCAPE")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.ESCAPE);
                    }
                    if (line == "key_up CONVERT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.CONVERT);
                    }
                    if (line == "key_up NONCONVERT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NONCONVERT);
                    }
                    if (line == "key_up ACCEPT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.ACCEPT);
                    }
                    if (line == "key_up MODECHANGE")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.MODECHANGE);
                    }
                    if (line == "key_up SPACE")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.SPACE);
                    }
                    if (line == "key_up PRIOR")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.PRIOR);
                    }
                    if (line == "key_up NEXT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NEXT);
                    }
                    if (line == "key_up END")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.END);
                    }
                    if (line == "key_up HOME")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.HOME);
                    }
                    if (line == "key_up LEFT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.LEFT);
                    }
                    if (line == "key_up RIGHT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.RIGHT);
                    }
                    if (line == "key_up DOWN")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.DOWN);
                    }
                    if (line == "key_up SELECT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.SELECT);
                    }
                    if (line == "key_up PRINT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.PRINT);
                    }
                    if (line == "key_up EXECUTE")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.EXECUTE);
                    }
                    if (line == "key_up SNAPSHOT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.SNAPSHOT);
                    }
                    if (line == "key_up INSERT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.INSERT);
                    }
                    if (line == "key_up DELETE")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.DELETE);
                    }
                    if (line == "key_up HELP")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.HELP);
                    }
                    if (line == "key_up VK_0")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_0);
                    }
                    if (line == "key_up VK_1")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_1);
                    }
                    if (line == "key_up VK_2")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_2);
                    }
                    if (line == "key_up VK_3")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_3);
                    }
                    if (line == "key_up VK_4")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_4);
                    }
                    if (line == "key_up VK_5")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_5);
                    }
                    if (line == "key_up VK_6")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_6);
                    }
                    if (line == "key_up VK_7")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_7);
                    }
                    if (line == "key_up VK_8")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_8);
                    }
                    if (line == "key_up VK_9")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VK_9);
                    }
                    if (line == "key_up LWIN")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.LWIN);
                    }
                    if (line == "key_up RWIN")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.RWIN);
                    }
                    if (line == "key_up SLEEP")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.SLEEP);
                    }
                    if (line == "key_up APPS")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.APPS);
                    }
                    if (line == "key_up NUMPAD0")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NUMPAD0);
                    }
                    if (line == "key_up NUMPAD1")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NUMPAD1);
                    }
                    if (line == "key_up NUMPAD2")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NUMPAD2);
                    }
                    if (line == "key_up NUMPAD3")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NUMPAD3);
                    }
                    if (line == "key_up NUMPAD4")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NUMPAD4);
                    }
                    if (line == "key_up NUMPAD5")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NUMPAD5);
                    }
                    if (line == "key_up NUMPAD6")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NUMPAD6);
                    }
                    if (line == "key_up NUMPAD7")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NUMPAD7);
                    }
                    if (line == "key_up NUMPAD8")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NUMPAD8);
                    }
                    if (line == "key_up NUMPAD9")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NUMPAD9);
                    }
                    if (line == "key_up MULTIPLY")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.MULTIPLY);
                    }
                    if (line == "key_up ADD")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.ADD);
                    }
                    if (line == "key_up SEPARATOR")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.SEPARATOR);
                    }
                    if (line == "key_up SUBTRACT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.SUBTRACT);
                    }
                    if (line == "key_up DECIMAL")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.DECIMAL);
                    }
                    if (line == "key_up DIVIDE")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.DIVIDE);
                    }
                    if (line == "key_up NUMLOCK")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NUMLOCK);
                    }
                    if (line == "key_up SCROLL")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.SCROLL);
                    }
                    if (line == "key_up LSHIFT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.LSHIFT);
                    }
                    if (line == "key_up RSHIFT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.RSHIFT);
                    }
                    if (line == "key_up LCONTROL")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.LCONTROL);
                    }
                    if (line == "key_up RCONTROL")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.RCONTROL);
                    }
                    if (line == "key_up LMENU")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.LMENU);
                    }
                    if (line == "key_up RMENU")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.RMENU);
                    }
                    if (line == "key_up BROWSER_BACK")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.BROWSER_BACK);
                    }
                    if (line == "key_up BROWSER_FORWARD")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.BROWSER_FORWARD);
                    }
                    if (line == "key_up BROWSER_REFRESH")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.BROWSER_REFRESH);
                    }
                    if (line == "key_up BROWSER_STOP")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.BROWSER_STOP);
                    }
                    if (line == "key_up BROWSER_SEARCH")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.BROWSER_SEARCH);
                    }
                    if (line == "key_up BROWSER_FAVORITES")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.BROWSER_FAVORITES);
                    }
                    if (line == "key_up BROWSER_HOME")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.BROWSER_HOME);
                    }
                    if (line == "key_up VOLUME_MUTE")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VOLUME_MUTE);
                    }
                    if (line == "key_up VOLUME_DOWN")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VOLUME_DOWN);
                    }
                    if (line == "key_up VOLUME_UP")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.VOLUME_UP);
                    }
                    if (line == "key_up MEDIA_NEXT_TRACK")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.MEDIA_NEXT_TRACK);
                    }
                    if (line == "key_up MEDIA_PREV_TRACK")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.MEDIA_PREV_TRACK);
                    }
                    if (line == "key_up MEDIA_STOP")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.MEDIA_STOP);
                    }
                    if (line == "key_up MEDIA_PLAY_PAUSE")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.MEDIA_PLAY_PAUSE);
                    }
                    if (line == "key_up LAUNCH_MAIL")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.LAUNCH_MAIL);
                    }
                    if (line == "key_up LAUNCH_MEDIA_SELECT")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.LAUNCH_MEDIA_SELECT);
                    }
                    if (line == "key_up LAUNCH_APP1")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.LAUNCH_APP1);
                    }
                    if (line == "key_up LAUNCH_APP2")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.LAUNCH_APP2);
                    }
                    if (line == "key_up OEM_1")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_1);
                    }
                    if (line == "key_up OEM_PLUS")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_PLUS);
                    }
                    if (line == "key_up OEM_COMMA")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_COMMA);
                    }
                    if (line == "key_up OEM_MINUS")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_MINUS);
                    }
                    if (line == "key_up OEM_PERIOD")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_PERIOD);
                    }
                    if (line == "key_up OEM_2")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_2);
                    }
                    if (line == "key_up OEM_3")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_3);
                    }
                    if (line == "key_up OEM_4")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_4);
                    }
                    if (line == "key_up OEM_5")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_5);
                    }
                    if (line == "key_up OEM_6")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_6);
                    }
                    if (line == "key_up OEM_7")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_7);
                    }
                    if (line == "key_up OEM_8")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_8);
                    }
                    if (line == "key_up OEM_102")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_102);
                    }
                    if (line == "key_up PROCESSKEY")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.PROCESSKEY);
                    }
                    if (line == "key_up PACKET")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.PACKET);
                    }
                    if (line == "key_up ATTN")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.ATTN);
                    }
                    if (line == "key_up CRSEL")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.CRSEL);
                    }
                    if (line == "key_up EXSEL")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.EXSEL);
                    }
                    if (line == "key_up EREOF")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.EREOF);
                    }
                    if (line == "key_up PLAY")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.PLAY);
                    }
                    if (line == "key_up ZOOM")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.ZOOM);
                    }
                    if (line == "key_up NONAME")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.NONAME);
                    }
                    if (line == "key_up PA1")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.PA1);
                    }
                    if (line == "key_up OEM_CLEAR")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.OEM_CLEAR);
                    }
                    if (line == "key_up XBUTTON2")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.XBUTTON2);
                    }
                    if (line == "key_up XBUTTON1")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.XBUTTON1);
                    }
                    if (line == "key_up MBUTTON")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.MBUTTON);
                    }
                    if (line == "key_up CANCEL")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.CANCEL);
                    }
                    if (line == "key_up RBUTTON")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.RBUTTON);
                    }
                    if (line == "key_up LBUTTON")
                    {
                        sim.Keyboard.KeyUp(VirtualKeyCode.LBUTTON);
                    }
                    if (line.Contains("LeftButtonClick"))
                    {
                        var part2 = line.Substring(line.LastIndexOf(':') + 1);
                        string part1 = line.Split(':')[1];
                        uint Xaxis = uint.Parse(part1);
                        uint Yaxis = uint.Parse(part2);
                        int Xaxis1 = int.Parse(part1);
                        int Yaxis1 = int.Parse(part2);
                        Cursor.Position = new Point(Xaxis1, Yaxis1);
                        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, Xaxis, Yaxis, 0, 0);
                    }
                    if (line.Contains("LeftButtonDoubleClick"))
                    {
                        var part2 = line.Substring(line.LastIndexOf(':') + 1);
                        string part1 = line.Split(':')[1];
                        uint Xaxis = uint.Parse(part1);
                        uint Yaxis = uint.Parse(part2);
                        int Xaxis1 = int.Parse(part1);
                        int Yaxis1 = int.Parse(part2);
                        Cursor.Position = new Point(Xaxis1, Yaxis1);
                        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, Xaxis, Yaxis, 0, 0);
                        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, Xaxis, Yaxis, 0, 0);
                    }
                    if (line.Contains("LeftButtonDown"))
                    {
                        var part2 = line.Substring(line.LastIndexOf(':') + 1);
                        string part1 = line.Split(':')[1];
                        uint Xaxis = uint.Parse(part1);
                        uint Yaxis = uint.Parse(part2);
                        int Xaxis1 = int.Parse(part1);
                        int Yaxis1 = int.Parse(part2);
                        Cursor.Position = new Point(Xaxis1, Yaxis1);
                        mouse_event(MOUSEEVENTF_LEFTDOWN, Xaxis, Yaxis, 0, 0);
                    }
                    if (line.Contains("LeftButtonUp"))
                    {
                        var part2 = line.Substring(line.LastIndexOf(':') + 1);
                        string part1 = line.Split(':')[1];
                        uint Xaxis = uint.Parse(part1);
                        uint Yaxis = uint.Parse(part2);
                        int Xaxis1 = int.Parse(part1);
                        int Yaxis1 = int.Parse(part2);
                        Cursor.Position = new Point(Xaxis1, Yaxis1);
                        mouse_event(MOUSEEVENTF_LEFTUP, Xaxis, Yaxis, 0, 0);
                    }
                    if (line.Contains("RightButtonClick"))
                    {
                        var part2 = line.Substring(line.LastIndexOf(':') + 1);
                        string part1 = line.Split(':')[1];
                        uint Xaxis = uint.Parse(part1);
                        uint Yaxis = uint.Parse(part2);
                        int Xaxis1 = int.Parse(part1);
                        int Yaxis1 = int.Parse(part2);
                        Cursor.Position = new Point(Xaxis1, Yaxis1);
                        mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, Xaxis, Yaxis, 0, 0);
                    }
                    if (line.Contains("RightButtonDoubleClick"))
                    {
                        var part2 = line.Substring(line.LastIndexOf(':') + 1);
                        string part1 = line.Split(':')[1];
                        uint Xaxis = uint.Parse(part1);
                        uint Yaxis = uint.Parse(part2);
                        int Xaxis1 = int.Parse(part1);
                        int Yaxis1 = int.Parse(part2);
                        Cursor.Position = new Point(Xaxis1, Yaxis1);
                        mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, Xaxis, Yaxis, 0, 0);
                        mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, Xaxis, Yaxis, 0, 0);
                    }
                    if (line.Contains("RightButtonDown"))
                    {
                        var part2 = line.Substring(line.LastIndexOf(':') + 1);
                        string part1 = line.Split(':')[1];
                        uint Xaxis = uint.Parse(part1);
                        uint Yaxis = uint.Parse(part2);
                        int Xaxis1 = int.Parse(part1);
                        int Yaxis1 = int.Parse(part2);
                        Cursor.Position = new Point(Xaxis1, Yaxis1);
                        mouse_event(MOUSEEVENTF_RIGHTDOWN, Xaxis, Yaxis, 0, 0);
                    }
                    if (line.Contains("RightButtonUp"))
                    {
                        var part2 = line.Substring(line.LastIndexOf(':') + 1);
                        string part1 = line.Split(':')[1];
                        uint Xaxis = uint.Parse(part1);
                        uint Yaxis = uint.Parse(part2);
                        int Xaxis1 = int.Parse(part1);
                        int Yaxis1 = int.Parse(part2);
                        Cursor.Position = new Point(Xaxis1, Yaxis1);
                        mouse_event(MOUSEEVENTF_RIGHTUP, Xaxis, Yaxis, 0, 0);
                    }
                    if (line.Contains("MoveMouseBy"))
                    {
                        var part2 = line.Substring(line.LastIndexOf(':') + 1);
                        string part1 = line.Split(':')[1];
                        int Xaxis1 = int.Parse(part1);
                        int Yaxis1 = int.Parse(part2);
                        sim.Mouse.MoveMouseBy(Xaxis1, Yaxis1);
                    }
                    if (line.Contains("MoveMouseTo"))
                    {
                        var part2 = line.Substring(line.LastIndexOf(':') + 1);
                        string part1 = line.Split(':')[1];
                        int Xaxis1 = int.Parse(part1);
                        int Yaxis1 = int.Parse(part2);
                        double startX = 65535 * Xaxis1 / Screen.PrimaryScreen.Bounds.Width;
                        double startY = 65535 * Yaxis1 / Screen.PrimaryScreen.Bounds.Height;
                        sim.Mouse.MoveMouseTo(startX, startY);
                    }
                    if (line.Contains("MoveMouseToPositionOnVirtualDesktop"))
                    {
                        var part2 = line.Substring(line.LastIndexOf(':') + 1);
                        string part1 = line.Split(':')[1];
                        int Xaxis1 = int.Parse(part1);
                        int Yaxis1 = int.Parse(part2);
                        double startX = 65535 * Xaxis1 / Screen.PrimaryScreen.Bounds.Width;
                        double startY = 65535 * Yaxis1 / Screen.PrimaryScreen.Bounds.Height;
                        sim.Mouse.MoveMouseToPositionOnVirtualDesktop(startX, startY);
                    }
                    if (line.Contains("VerticalScroll"))
                    {
                        var part2 = line.Substring(line.LastIndexOf(':') + 1);
                        string part1 = line.Split(':')[1];
                        int scrollint = int.Parse(part1);
                        sim.Mouse.VerticalScroll(scrollint);
                    }
                    if (line.Contains("XButtonClick"))
                    {
                        var part2 = line.Substring(line.LastIndexOf(':') + 1);
                        string part1 = line.Split(':')[1];
                        int scrollint = int.Parse(part1);
                        sim.Mouse.XButtonClick(scrollint);
                    }
                    if (line.Contains("XButtonDoubleClick"))
                    {
                        var part2 = line.Substring(line.LastIndexOf(':') + 1);
                        string part1 = line.Split(':')[1];
                        int scrollint = int.Parse(part1);
                        sim.Mouse.XButtonDoubleClick(scrollint);
                        sim.Mouse.XButtonDoubleClick(scrollint);
                    }
                    if (line.Contains("XButtonDown"))
                    {
                        var part2 = line.Substring(line.LastIndexOf(':') + 1);
                        string part1 = line.Split(':')[1];
                        int scrollint = int.Parse(part1);
                        sim.Mouse.XButtonDown(scrollint);
                    }
                    if (line.Contains("XButtonUp"))
                    {
                        var part2 = line.Substring(line.LastIndexOf(':') + 1);
                        string part1 = line.Split(':')[1];
                        int scrollint = int.Parse(part1);
                        sim.Mouse.XButtonUp(scrollint);
                    }
                    if (line.Contains("wait"))
                    {
                        var result = line.Substring(line.LastIndexOf(':') + 1);
                        Thread.Sleep(int.Parse(result));
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button7.Enabled = false;
            button4.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            foreach (var item in Enum.GetValues(typeof(VirtualKeyCode)))
            {
                comboBox1.Items.Add(item.ToString());
            }
            foreach (var item in Enum.GetValues(typeof(Keys)))
            {
                comboBox3.Items.Add(item.ToString());
            }
            configfoldercheck();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            IntPtr thisWindow = FindWindow(null, textBox3.Text);
            UnregisterHotKey(thisWindow, idusedfirst);
            UnregisterHotKey(thisWindow, idusedsecond);
            UnregisterHotKey(thisWindow, 16);
            UnregisterHotKey(thisWindow, 17);
        }
        private void configfoldercheck()
        {
            if (!Directory.Exists("Configs"))
            {
                Directory.CreateDirectory("Configs");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text == "KeyPress")
            {
                textBox2.AppendText("key_press " + comboBox1.Text + "\r\n");
            }
            if (comboBox4.Text == "KeyDown")
            {
                textBox2.AppendText("key_down " + comboBox1.Text + "\r\n");
            }
            if (comboBox4.Text == "KeyUp")
            {
                textBox2.AppendText("key_up " + comboBox1.Text + "\r\n");
            }

        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.AppendText(comboBox2.Text + ":" + numericUpDown2.Value + ":" + numericUpDown3.Value + "\r\n");
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.AppendText("wait:" + numericUpDown4.Value.ToString() + "\r\n");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button5.Enabled = true;
            button7.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            var dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                const Int32 BufferSize = 128;
                using (var fileStream = File.OpenRead(dlg.FileName))
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
                {
                    String line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        textBox2.AppendText(line + "\r\n");
                    }
                    streamReader.Close();
                    streamReader.Dispose();
                }
            }
            MessageBox.Show("Config Loaded.");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (newcheck1 == false)
            {
                button4.Enabled = true;
                button5.Enabled = true;
                button7.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                textBox2.Clear();
                newcheck1 = true;
            }
            else
            {
                textBox2.Clear();
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = ".cfg Files (*.cfg)|*.cfg";
            sfd.InitialDirectory = Application.StartupPath + @"\Configs";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, textBox2.Text);
            }
            MessageBox.Show("Config Saved.");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            IntPtr thisWindow = FindWindow(null, textBox3.Text);
            remembermebind1 = textBox2.Text;
            if (comboBox3.Text == "None")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.None);
            }
            if (comboBox3.Text == "LButton")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.LButton);
            }
            if (comboBox3.Text == "RButton")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.RButton);
            }
            if (comboBox3.Text == "Cancel")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Cancel);
            }
            if (comboBox3.Text == "MButton")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.MButton);
            }
            if (comboBox3.Text == "XButton1")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.XButton1);
            }
            if (comboBox3.Text == "XButton2")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.XButton2);
            }
            if (comboBox3.Text == "Back")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Back);
            }
            if (comboBox3.Text == "Tab")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Tab);
            }
            if (comboBox3.Text == "LineFeed")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.LineFeed);
            }
            if (comboBox3.Text == "Clear")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Clear);
            }
            if (comboBox3.Text == "Return")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Return);
            }
            if (comboBox3.Text == "ShiftKey")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.ShiftKey);
            }
            if (comboBox3.Text == "ControlKey")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.ControlKey);
            }
            if (comboBox3.Text == "Menu")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Menu);
            }
            if (comboBox3.Text == "Pause")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Pause);
            }
            if (comboBox3.Text == "Capital")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Capital);
            }
            if (comboBox3.Text == "KanaMode")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.KanaMode);
            }
            if (comboBox3.Text == "JunjaMode")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.JunjaMode);
            }
            if (comboBox3.Text == "FinalMode")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.FinalMode);
            }
            if (comboBox3.Text == "HanjaMode")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.HanjaMode);
            }
            if (comboBox3.Text == "Escape")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Escape);
            }
            if (comboBox3.Text == "IMEConvert")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.IMEConvert);
            }
            if (comboBox3.Text == "IMENonconvert")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.IMENonconvert);
            }
            if (comboBox3.Text == "IMEAceept")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.IMEAceept);
            }
            if (comboBox3.Text == "IMEModeChange")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.IMEModeChange);
            }
            if (comboBox3.Text == "Space")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Space);
            }
            if (comboBox3.Text == "PageUp")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.PageUp);
            }
            if (comboBox3.Text == "Next")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Next);
            }
            if (comboBox3.Text == "End")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.End);
            }
            if (comboBox3.Text == "Home")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Home);
            }
            if (comboBox3.Text == "Left")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Left);
            }
            if (comboBox3.Text == "Up")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Up);
            }
            if (comboBox3.Text == "Right")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Right);
            }
            if (comboBox3.Text == "Down")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Down);
            }
            if (comboBox3.Text == "Select")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Select);
            }
            if (comboBox3.Text == "Print")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Print);
            }
            if (comboBox3.Text == "Execute")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Execute);
            }
            if (comboBox3.Text == "PrintScreen")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.PrintScreen);
            }
            if (comboBox3.Text == "Insert")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Insert);
            }
            if (comboBox3.Text == "Delete")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Delete);
            }
            if (comboBox3.Text == "Help")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Help);
            }
            if (comboBox3.Text == "D0")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.D0);
            }
            if (comboBox3.Text == "D1")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.D1);
            }
            if (comboBox3.Text == "D2")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.D2);
            }
            if (comboBox3.Text == "D3")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.D3);
            }
            if (comboBox3.Text == "D4")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.D4);
            }
            if (comboBox3.Text == "D5")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.D5);
            }
            if (comboBox3.Text == "D6")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.D6);
            }
            if (comboBox3.Text == "D7")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.D7);
            }
            if (comboBox3.Text == "D8")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.D8);
            }
            if (comboBox3.Text == "D9")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.D9);
            }
            if (comboBox3.Text == "A")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.A);
            }
            if (comboBox3.Text == "B")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.B);
            }
            if (comboBox3.Text == "C")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.C);
            }
            if (comboBox3.Text == "D")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.D);
            }
            if (comboBox3.Text == "E")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.E);
            }
            if (comboBox3.Text == "F")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.F);
            }
            if (comboBox3.Text == "G")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.G);
            }
            if (comboBox3.Text == "H")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.H);
            }
            if (comboBox3.Text == "I")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.I);
            }
            if (comboBox3.Text == "J")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.J);
            }
            if (comboBox3.Text == "K")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.K);
            }
            if (comboBox3.Text == "L")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.L);
            }
            if (comboBox3.Text == "M")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.M);
            }
            if (comboBox3.Text == "N")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.N);
            }
            if (comboBox3.Text == "O")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.O);
            }
            if (comboBox3.Text == "P")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.P);
            }
            if (comboBox3.Text == "Q")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Q);
            }
            if (comboBox3.Text == "R")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.R);
            }
            if (comboBox3.Text == "S")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.S);
            }
            if (comboBox3.Text == "T")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.T);
            }
            if (comboBox3.Text == "U")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.U);
            }
            if (comboBox3.Text == "V")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.V);
            }
            if (comboBox3.Text == "W")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.W);
            }
            if (comboBox3.Text == "X")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.X);
            }
            if (comboBox3.Text == "Y")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Y);
            }
            if (comboBox3.Text == "Z")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Z);
            }
            if (comboBox3.Text == "LWin")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.LWin);
            }
            if (comboBox3.Text == "RWin")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.RWin);
            }
            if (comboBox3.Text == "Apps")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Apps);
            }
            if (comboBox3.Text == "Sleep")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Sleep);
            }
            if (comboBox3.Text == "NumPad0")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.NumPad0);
            }
            if (comboBox3.Text == "NumPad1")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.NumPad1);
            }
            if (comboBox3.Text == "NumPad2")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.NumPad2);
            }
            if (comboBox3.Text == "NumPad3")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.NumPad3);
            }
            if (comboBox3.Text == "NumPad4")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.NumPad4);
            }
            if (comboBox3.Text == "NumPad5")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.NumPad5);
            }
            if (comboBox3.Text == "NumPad6")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.NumPad6);
            }
            if (comboBox3.Text == "NumPad7")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.NumPad7);
            }
            if (comboBox3.Text == "NumPad8")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.NumPad8);
            }
            if (comboBox3.Text == "NumPad9")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.NumPad9);
            }
            if (comboBox3.Text == "Multiply")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Multiply);
            }
            if (comboBox3.Text == "Add")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Add);
            }
            if (comboBox3.Text == "Separator")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Separator);
            }
            if (comboBox3.Text == "Subtract")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Subtract);
            }
            if (comboBox3.Text == "Decimal")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Decimal);
            }
            if (comboBox3.Text == "Divide")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Divide);
            }
            if (comboBox3.Text == "F1")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.F1);
            }
            if (comboBox3.Text == "Help")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Help);
            }
            if (comboBox3.Text == "F2")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.F2);
            }
            if (comboBox3.Text == "F3")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.F3);
            }
            if (comboBox3.Text == "F4")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.F4);
            }
            if (comboBox3.Text == "F5")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.F5);
            }
            if (comboBox3.Text == "F6")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.F6);
            }
            if (comboBox3.Text == "F7")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.F7);
            }
            if (comboBox3.Text == "F8")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.F8);
            }
            if (comboBox3.Text == "F9")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.F9);
            }
            if (comboBox3.Text == "F10")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.F10);
            }
            if (comboBox3.Text == "F11")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.F11);
            }
            if (comboBox3.Text == "F12")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.F12);
            }
            if (comboBox3.Text == "F13")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.F13);
            }
            if (comboBox3.Text == "F14")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.F14);
            }
            if (comboBox3.Text == "F15")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.F15);
            }
            if (comboBox3.Text == "F16")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.F16);
            }
            if (comboBox3.Text == "F17")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.F17);
            }
            if (comboBox3.Text == "F18")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.F18);
            }
            if (comboBox3.Text == "F19")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.F19);
            }
            if (comboBox3.Text == "F20")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.F20);
            }
            if (comboBox3.Text == "F21")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.F21);
            }
            if (comboBox3.Text == "F22")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.F22);
            }
            if (comboBox3.Text == "F23")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.F23);
            }
            if (comboBox3.Text == "F24")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.F24);
            }
            if (comboBox3.Text == "NumLock")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.NumLock);
            }
            if (comboBox3.Text == "Scroll")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Scroll);
            }
            if (comboBox3.Text == "LShiftKey")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.LShiftKey);
            }
            if (comboBox3.Text == "RShiftKey")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.RShiftKey);
            }
            if (comboBox3.Text == "LControlKey")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.LControlKey);
            }
            if (comboBox3.Text == "RControlKey")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.RControlKey);
            }
            if (comboBox3.Text == "LMenu")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.LMenu);
            }
            if (comboBox3.Text == "RMenu")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.RMenu);
            }
            if (comboBox3.Text == "BrowserBack")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.BrowserBack);
            }
            if (comboBox3.Text == "BrowserForward")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.BrowserForward);
            }
            if (comboBox3.Text == "BrowserRefresh")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.BrowserRefresh);
            }
            if (comboBox3.Text == "BrowserStop")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.BrowserStop);
            }
            if (comboBox3.Text == "BrowserSearch")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.BrowserSearch);
            }
            if (comboBox3.Text == "BrowserFavorites")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.BrowserFavorites);
            }
            if (comboBox3.Text == "BrowserHome")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.BrowserHome);
            }
            if (comboBox3.Text == "VolumeMute")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.VolumeMute);
            }
            if (comboBox3.Text == "VolumeDown")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.VolumeDown);
            }
            if (comboBox3.Text == "VolumeUp")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.VolumeUp);
            }
            if (comboBox3.Text == "MediaNextTrack")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.MediaNextTrack);
            }
            if (comboBox3.Text == "MediaPreviousTrack")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.MediaPreviousTrack);
            }
            if (comboBox3.Text == "MediaStop")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.MediaStop);
            }
            if (comboBox3.Text == "MediaPlayPause")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.MediaPlayPause);
            }
            if (comboBox3.Text == "LaunchMail")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.LaunchMail);
            }
            if (comboBox3.Text == "SelectMedia")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.SelectMedia);
            }
            if (comboBox3.Text == "LaunchApplication1")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.LaunchApplication1);
            }
            if (comboBox3.Text == "LaunchApplication2")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.LaunchApplication2);
            }
            if (comboBox3.Text == "Oem1")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Oem1);
            }
            if (comboBox3.Text == "Oemplus")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Oemplus);
            }
            if (comboBox3.Text == "Oemcomma")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Oemcomma);
            }
            if (comboBox3.Text == "OemMinus")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.OemMinus);
            }
            if (comboBox3.Text == "OemPeriod")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.OemPeriod);
            }
            if (comboBox3.Text == "OemQuestion")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.OemQuestion);
            }
            if (comboBox3.Text == "Oemtilde")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Oemtilde);
            }
            if (comboBox3.Text == "OemOpenBrackets")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.OemOpenBrackets);
            }
            if (comboBox3.Text == "Oem5")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Oem5);
            }
            if (comboBox3.Text == "Oem6")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Oem6);
            }
            if (comboBox3.Text == "Oem7")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Oem7);
            }
            if (comboBox3.Text == "Oem8")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Oem8);
            }
            if (comboBox3.Text == "OemBackslash")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.OemBackslash);
            }
            if (comboBox3.Text == "ProcessKey")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.ProcessKey);
            }
            if (comboBox3.Text == "Packet")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Packet);
            }
            if (comboBox3.Text == "Crsel")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Crsel);
            }
            if (comboBox3.Text == "Exsel")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Exsel);
            }
            if (comboBox3.Text == "EraseEof")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.EraseEof);
            }
            if (comboBox3.Text == "Play")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Play);
            }
            if (comboBox3.Text == "Zoom")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Zoom);
            }
            if (comboBox3.Text == "NoName")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.NoName);
            }
            if (comboBox3.Text == "Pa1")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Pa1);
            }
            if (comboBox3.Text == "OemClear")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.OemClear);
            }
            if (comboBox3.Text == "KeyCode")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.KeyCode);
            }
            if (comboBox3.Text == "Shift")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Shift);
            }
            if (comboBox3.Text == "Control")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Control);
            }
            if (comboBox3.Text == "Alt")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Alt);
            }
            if (comboBox3.Text == "Modifiers")
            {
                RegisterHotKey(thisWindow, 16, 0, (int)Keys.Modifiers);
            }
            MessageBox.Show("Binded config to: " + comboBox3.Text);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (timer2checktoggle == false)
            {
                timer2checktoggle = true;
                timer2.Start();
            }
            else
            {
                timer2checktoggle = false;
                timer2.Stop();
                label13.Text = "Null";
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            label13.Text = "X: " + Cursor.Position.X.ToString() + ", Y: " + Cursor.Position.Y.ToString();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                IntPtr thisWindow1 = FindWindow(null, textBox3.Text);
                UnregisterHotKey(thisWindow1, idusedfirst);
                UnregisterHotKey(thisWindow1, idusedsecond);
                UnregisterHotKey(thisWindow1, 16);
                UnregisterHotKey(thisWindow1, 17);
                MessageBox.Show("Unbound All Previous Binds");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                button4.Enabled = true;
                button5.Enabled = true;
                button7.Enabled = true;
                button9.Enabled = true;
                button10.Enabled = true;
                textBox2.Clear();
                newcheck1 = true;
                listBox1.Items.Clear();
                string[] files = new DirectoryInfo(Application.StartupPath + @"\Configs").GetFiles().Select(o => o.Name).ToArray();
                foreach (string file in files)
                {
                    listBox1.Items.Add(file + "\r\n");
                }
            }
            catch
            {

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath + @"\Configs\" + listBox1.SelectedItem.ToString();
                string FilePath1 = path.TrimEnd('\r', '\n');
                textBox2.Text = File.ReadAllText(FilePath1);
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntPtr thisWindow = FindWindow(null, textBox3.Text);
            remembermebind2 = textBox2.Text;
            if (comboBox5.Text == "None")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.None);
            }
            if (comboBox5.Text == "LButton")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.LButton);
            }
            if (comboBox5.Text == "RButton")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.RButton);
            }
            if (comboBox5.Text == "Cancel")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Cancel);
            }
            if (comboBox5.Text == "MButton")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.MButton);
            }
            if (comboBox5.Text == "XButton1")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.XButton1);
            }
            if (comboBox5.Text == "XButton2")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.XButton2);
            }
            if (comboBox5.Text == "Back")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Back);
            }
            if (comboBox5.Text == "Tab")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Tab);
            }
            if (comboBox5.Text == "LineFeed")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.LineFeed);
            }
            if (comboBox5.Text == "Clear")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Clear);
            }
            if (comboBox5.Text == "Return")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Return);
            }
            if (comboBox5.Text == "ShiftKey")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.ShiftKey);
            }
            if (comboBox5.Text == "ControlKey")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.ControlKey);
            }
            if (comboBox5.Text == "Menu")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Menu);
            }
            if (comboBox5.Text == "Pause")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Pause);
            }
            if (comboBox5.Text == "Capital")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Capital);
            }
            if (comboBox5.Text == "KanaMode")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.KanaMode);
            }
            if (comboBox5.Text == "JunjaMode")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.JunjaMode);
            }
            if (comboBox5.Text == "FinalMode")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.FinalMode);
            }
            if (comboBox5.Text == "HanjaMode")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.HanjaMode);
            }
            if (comboBox5.Text == "Escape")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Escape);
            }
            if (comboBox5.Text == "IMEConvert")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.IMEConvert);
            }
            if (comboBox5.Text == "IMENonconvert")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.IMENonconvert);
            }
            if (comboBox5.Text == "IMEAceept")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.IMEAceept);
            }
            if (comboBox5.Text == "IMEModeChange")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.IMEModeChange);
            }
            if (comboBox5.Text == "Space")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Space);
            }
            if (comboBox5.Text == "PageUp")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.PageUp);
            }
            if (comboBox5.Text == "Next")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Next);
            }
            if (comboBox5.Text == "End")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.End);
            }
            if (comboBox5.Text == "Home")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Home);
            }
            if (comboBox5.Text == "Left")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Left);
            }
            if (comboBox5.Text == "Up")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Up);
            }
            if (comboBox5.Text == "Right")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Right);
            }
            if (comboBox5.Text == "Down")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Down);
            }
            if (comboBox5.Text == "Select")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Select);
            }
            if (comboBox5.Text == "Print")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Print);
            }
            if (comboBox5.Text == "Execute")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Execute);
            }
            if (comboBox5.Text == "PrintScreen")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.PrintScreen);
            }
            if (comboBox5.Text == "Insert")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Insert);
            }
            if (comboBox5.Text == "Delete")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Delete);
            }
            if (comboBox5.Text == "Help")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Help);
            }
            if (comboBox5.Text == "D0")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.D0);
            }
            if (comboBox5.Text == "D1")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.D1);
            }
            if (comboBox5.Text == "D2")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.D2);
            }
            if (comboBox5.Text == "D3")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.D3);
            }
            if (comboBox5.Text == "D4")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.D4);
            }
            if (comboBox5.Text == "D5")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.D5);
            }
            if (comboBox5.Text == "D6")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.D6);
            }
            if (comboBox5.Text == "D7")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.D7);
            }
            if (comboBox5.Text == "D8")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.D8);
            }
            if (comboBox5.Text == "D9")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.D9);
            }
            if (comboBox5.Text == "A")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.A);
            }
            if (comboBox5.Text == "B")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.B);
            }
            if (comboBox5.Text == "C")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.C);
            }
            if (comboBox5.Text == "D")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.D);
            }
            if (comboBox5.Text == "E")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.E);
            }
            if (comboBox5.Text == "F")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.F);
            }
            if (comboBox5.Text == "G")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.G);
            }
            if (comboBox5.Text == "H")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.H);
            }
            if (comboBox5.Text == "I")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.I);
            }
            if (comboBox5.Text == "J")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.J);
            }
            if (comboBox5.Text == "K")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.K);
            }
            if (comboBox5.Text == "L")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.L);
            }
            if (comboBox5.Text == "M")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.M);
            }
            if (comboBox5.Text == "N")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.N);
            }
            if (comboBox5.Text == "O")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.O);
            }
            if (comboBox5.Text == "P")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.P);
            }
            if (comboBox5.Text == "Q")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Q);
            }
            if (comboBox5.Text == "R")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.R);
            }
            if (comboBox5.Text == "S")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.S);
            }
            if (comboBox5.Text == "T")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.T);
            }
            if (comboBox5.Text == "U")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.U);
            }
            if (comboBox5.Text == "V")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.V);
            }
            if (comboBox5.Text == "W")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.W);
            }
            if (comboBox5.Text == "X")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.X);
            }
            if (comboBox5.Text == "Y")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Y);
            }
            if (comboBox5.Text == "Z")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Z);
            }
            if (comboBox5.Text == "LWin")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.LWin);
            }
            if (comboBox5.Text == "RWin")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.RWin);
            }
            if (comboBox5.Text == "Apps")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Apps);
            }
            if (comboBox5.Text == "Sleep")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Sleep);
            }
            if (comboBox5.Text == "NumPad0")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.NumPad0);
            }
            if (comboBox5.Text == "NumPad1")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.NumPad1);
            }
            if (comboBox5.Text == "NumPad2")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.NumPad2);
            }
            if (comboBox5.Text == "NumPad3")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.NumPad3);
            }
            if (comboBox5.Text == "NumPad4")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.NumPad4);
            }
            if (comboBox5.Text == "NumPad5")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.NumPad5);
            }
            if (comboBox5.Text == "NumPad6")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.NumPad6);
            }
            if (comboBox5.Text == "NumPad7")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.NumPad7);
            }
            if (comboBox5.Text == "NumPad8")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.NumPad8);
            }
            if (comboBox5.Text == "NumPad9")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.NumPad9);
            }
            if (comboBox5.Text == "Multiply")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Multiply);
            }
            if (comboBox5.Text == "Add")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Add);
            }
            if (comboBox5.Text == "Separator")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Separator);
            }
            if (comboBox5.Text == "Subtract")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Subtract);
            }
            if (comboBox5.Text == "Decimal")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Decimal);
            }
            if (comboBox5.Text == "Divide")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Divide);
            }
            if (comboBox5.Text == "F1")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.F1);
            }
            if (comboBox5.Text == "Help")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Help);
            }
            if (comboBox5.Text == "F2")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.F2);
            }
            if (comboBox5.Text == "F3")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.F3);
            }
            if (comboBox5.Text == "F4")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.F4);
            }
            if (comboBox5.Text == "F5")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.F5);
            }
            if (comboBox5.Text == "F6")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.F6);
            }
            if (comboBox5.Text == "F7")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.F7);
            }
            if (comboBox5.Text == "F8")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.F8);
            }
            if (comboBox5.Text == "F9")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.F9);
            }
            if (comboBox5.Text == "F10")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.F10);
            }
            if (comboBox5.Text == "F11")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.F11);
            }
            if (comboBox5.Text == "F12")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.F12);
            }
            if (comboBox5.Text == "F13")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.F13);
            }
            if (comboBox5.Text == "F14")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.F14);
            }
            if (comboBox5.Text == "F15")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.F15);
            }
            if (comboBox5.Text == "F17")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.F17);
            }
            if (comboBox5.Text == "F17")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.F17);
            }
            if (comboBox5.Text == "F18")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.F18);
            }
            if (comboBox5.Text == "F19")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.F19);
            }
            if (comboBox5.Text == "F20")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.F20);
            }
            if (comboBox5.Text == "F21")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.F21);
            }
            if (comboBox5.Text == "F22")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.F22);
            }
            if (comboBox5.Text == "F23")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.F23);
            }
            if (comboBox5.Text == "F24")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.F24);
            }
            if (comboBox5.Text == "NumLock")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.NumLock);
            }
            if (comboBox5.Text == "Scroll")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Scroll);
            }
            if (comboBox5.Text == "LShiftKey")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.LShiftKey);
            }
            if (comboBox5.Text == "RShiftKey")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.RShiftKey);
            }
            if (comboBox5.Text == "LControlKey")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.LControlKey);
            }
            if (comboBox5.Text == "RControlKey")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.RControlKey);
            }
            if (comboBox5.Text == "LMenu")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.LMenu);
            }
            if (comboBox5.Text == "RMenu")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.RMenu);
            }
            if (comboBox5.Text == "BrowserBack")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.BrowserBack);
            }
            if (comboBox5.Text == "BrowserForward")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.BrowserForward);
            }
            if (comboBox5.Text == "BrowserRefresh")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.BrowserRefresh);
            }
            if (comboBox5.Text == "BrowserStop")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.BrowserStop);
            }
            if (comboBox5.Text == "BrowserSearch")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.BrowserSearch);
            }
            if (comboBox5.Text == "BrowserFavorites")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.BrowserFavorites);
            }
            if (comboBox5.Text == "BrowserHome")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.BrowserHome);
            }
            if (comboBox5.Text == "VolumeMute")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.VolumeMute);
            }
            if (comboBox5.Text == "VolumeDown")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.VolumeDown);
            }
            if (comboBox5.Text == "VolumeUp")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.VolumeUp);
            }
            if (comboBox5.Text == "MediaNextTrack")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.MediaNextTrack);
            }
            if (comboBox5.Text == "MediaPreviousTrack")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.MediaPreviousTrack);
            }
            if (comboBox5.Text == "MediaStop")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.MediaStop);
            }
            if (comboBox5.Text == "MediaPlayPause")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.MediaPlayPause);
            }
            if (comboBox5.Text == "LaunchMail")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.LaunchMail);
            }
            if (comboBox5.Text == "SelectMedia")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.SelectMedia);
            }
            if (comboBox5.Text == "LaunchApplication1")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.LaunchApplication1);
            }
            if (comboBox5.Text == "LaunchApplication2")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.LaunchApplication2);
            }
            if (comboBox5.Text == "Oem1")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Oem1);
            }
            if (comboBox5.Text == "Oemplus")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Oemplus);
            }
            if (comboBox5.Text == "Oemcomma")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Oemcomma);
            }
            if (comboBox5.Text == "OemMinus")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.OemMinus);
            }
            if (comboBox5.Text == "OemPeriod")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.OemPeriod);
            }
            if (comboBox5.Text == "OemQuestion")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.OemQuestion);
            }
            if (comboBox5.Text == "Oemtilde")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Oemtilde);
            }
            if (comboBox5.Text == "OemOpenBrackets")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.OemOpenBrackets);
            }
            if (comboBox5.Text == "Oem5")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Oem5);
            }
            if (comboBox5.Text == "Oem6")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Oem6);
            }
            if (comboBox5.Text == "Oem7")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Oem7);
            }
            if (comboBox5.Text == "Oem8")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Oem8);
            }
            if (comboBox5.Text == "OemBackslash")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.OemBackslash);
            }
            if (comboBox5.Text == "ProcessKey")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.ProcessKey);
            }
            if (comboBox5.Text == "Packet")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Packet);
            }
            if (comboBox5.Text == "Crsel")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Crsel);
            }
            if (comboBox5.Text == "Exsel")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Exsel);
            }
            if (comboBox5.Text == "EraseEof")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.EraseEof);
            }
            if (comboBox5.Text == "Play")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Play);
            }
            if (comboBox5.Text == "Zoom")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Zoom);
            }
            if (comboBox5.Text == "NoName")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.NoName);
            }
            if (comboBox5.Text == "Pa1")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Pa1);
            }
            if (comboBox5.Text == "OemClear")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.OemClear);
            }
            if (comboBox5.Text == "KeyCode")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.KeyCode);
            }
            if (comboBox5.Text == "Shift")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Shift);
            }
            if (comboBox5.Text == "Control")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Control);
            }
            if (comboBox5.Text == "Alt")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Alt);
            }
            if (comboBox5.Text == "Modifiers")
            {
                RegisterHotKey(thisWindow, 17, 0, (int)Keys.Modifiers);
            }
            MessageBox.Show("Binded config to: " + comboBox5.Text);
        }
    }
}