using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HWND = System.IntPtr;

namespace WindowsFormsApp1
{
    static class WinAppServices
    {
        static class KeyScanCodes
        {
            public static readonly IntPtr KEYDOWN_ENTER = (IntPtr)0x011C0001;
            public static readonly IntPtr KEYUP_ENTER = (IntPtr)0xC11C0001;
        }
        const int WM_SETTEXT = 0x000C;
        const int WM_KEYDOWN = 0x0100;
        const int WM_KEYUP = 0x0101;
        readonly static IntPtr VK_ENTER_PTR = (IntPtr)13;

        /// <summary>
        /// filter function
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        public delegate bool EnumDelegate(IntPtr hWnd, int lParam);

        /// <summary>
        /// check if windows visible
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindowVisible(IntPtr hWnd);

        /// <summary>
        /// return windows text
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="lpWindowText"></param>
        /// <param name="nMaxCount"></param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "GetWindowText", ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpWindowText, int nMaxCount);

        /// <summary>
        /// enumarator on all desktop windows
        /// </summary>
        /// <param name="hDesktop"></param>
        /// <param name="lpEnumCallbackFunction"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "EnumDesktopWindows", ExactSpelling = false, CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool EnumDesktopWindows(IntPtr hDesktop, EnumDelegate lpEnumCallbackFunction, IntPtr lParam);

        [DllImport("user32", CharSet = CharSet.Auto, SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        static extern int PostMessage(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern uint MapVirtualKey(uint uCode, uint uMapType);
        
        public static void sendKey(IntPtr hwnd, VKeys keyCode, bool extended)
        {
            uint scanCode = MapVirtualKey((uint)keyCode, 0);
            uint lParam;

            //KEY DOWN
            lParam = (0x00000001 | (scanCode << 16));
            if (extended)
            {
                lParam |= 0x01000000;
            }
            PostMessage(hwnd, WM_KEYDOWN, (IntPtr)keyCode, (IntPtr)lParam);
            //PostMessage(hwnd, WM_KEYDOWN, (IntPtr)keyCode, IntPtr.Zero);
            Thread.Sleep(50);

            //KEY UP
            //lParam |= 0xC0000000;  // set previous key and transition states (bits 30 and 31)
            PostMessage(hwnd, WM_KEYUP, (IntPtr)keyCode, (IntPtr)lParam);
        }

        
        public class ApplicationInfo
        {
            public string Name { get; set; }
            public IntPtr Handle { get; set; }
            public bool Alived { get; set; }
        }

        public static ObservableCollection<ApplicationInfo> GetHts()
        {
            ObservableCollection<ApplicationInfo> openedApplications = new ObservableCollection<ApplicationInfo>();
            Dictionary<HWND, string> windows = new Dictionary<HWND, string>();

            EnumDelegate filter = delegate (IntPtr hWnd, int lParam)
            {
                StringBuilder strbTitle = new StringBuilder(255);
                int nLength = GetWindowText(hWnd, strbTitle, strbTitle.Capacity + 1);
                string strTitle = strbTitle.ToString();

                if (IsWindowVisible(hWnd) && string.IsNullOrEmpty(strTitle) == false)
                {
                    windows.Add(hWnd, strTitle);
                }
                return true;
            };

            if (EnumDesktopWindows(IntPtr.Zero, filter, IntPtr.Zero))
            {
                foreach (var item in windows)
                {
                    openedApplications.Add(new ApplicationInfo() { 
                        Alived = true,
                        Name = item.Value,
                        Handle = item.Key
                    });
                }
            }

            return openedApplications;
        }

        public static void SendKey(string keys, IntPtr hWnd)
        {
            //PostMessage(hWnd, WM_KEYDOWN, VK_F9 , KeyScanCodes.KEYDOWN_ENTER);
            //PostMessage(hWnd, WM_KEYUP, VK_ENTER_PTR, KeyScanCodes.KEYUP_ENTER);
        }
    }
}
