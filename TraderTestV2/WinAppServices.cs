using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HWND = System.IntPtr;

namespace TraderTestV2
{
    static class WinAppServices
    {
        public class ApplicationInfo
        {
            public string Name { get; set; }
            public IntPtr Handle { get; set; }
            public bool Alived { get; set; }
        }

        public static ObservableCollection<ApplicationInfo> GetHts(string filter)
        {
            ObservableCollection<ApplicationInfo> openedApplications = new ObservableCollection<ApplicationInfo>();
            Dictionary<IntPtr, string> windows = new Dictionary<IntPtr, string>();

            // Get the desktopwindow handle
            IntPtr nDeshWndHandle = NativeWin32.GetDesktopWindow();
            // Get the first child window
            IntPtr nChildHandle = NativeWin32.GetWindow(nDeshWndHandle, NativeWin32.GW_CHILD);

            while (nChildHandle != IntPtr.Zero)
            {
                // Get only visible windows
                if (NativeWin32.IsWindowVisible(nChildHandle))
                {
                    StringBuilder sbTitle = new StringBuilder(1024);
                    // Read the Title bar text on the windows to put in combobox
                    NativeWin32.GetWindowText(nChildHandle, sbTitle, sbTitle.Capacity);
                    String sWinTitle = sbTitle.ToString();
                    {
                        if (sWinTitle.Length > 0 && sWinTitle.Contains(filter))
                        {
                            openedApplications.Add(new ApplicationInfo()
                            {
                                Alived = true,
                                Name = sWinTitle,
                                Handle = nChildHandle
                            });
                        }
                    }
                }
                // Look for the next child.
                nChildHandle = NativeWin32.GetWindow(nChildHandle, NativeWin32.GW_HWNDNEXT);
            }

            return openedApplications;
        }


        public static void SendOrder(VKeys keys, IntPtr orderHwnd, IntPtr countHwnd, int count)
        {
            NativeWin32.SetForegroundWindow(orderHwnd);
            Thread.Sleep(50);

            NativeWin32.SendMessage(countHwnd, NativeWin32.WM_SETTEXT, 0, count.ToString());
            Thread.Sleep(50);

            string keystring = "";

            switch (keys)
            {
                case VKeys.KEY_F6:
                    keystring = "{F6}";
                    break;
                case VKeys.KEY_F9:
                    keystring = "{F9}";
                    break;
                case VKeys.KEY_F11:
                    keystring = "{F11}";
                    break;
                case VKeys.KEY_F12:
                    keystring = "{F12}";
                    break;
            }

            System.Windows.Forms.SendKeys.Send(keystring);
        }

        
        public static string GetWindowInfo(IntPtr hWnd)
        {
            StringBuilder strbTitle = new StringBuilder(255);
            NativeWin32.GetWindowText(hWnd, strbTitle, strbTitle.Capacity + 1);
            string strTitle = strbTitle.ToString();

            StringBuilder sClass = new StringBuilder(100);
            NativeWin32.GetClassName(hWnd, sClass, 100);
            string strClass = sClass.ToString();

            return $"{sClass}{strbTitle}";
        }

        public static string GetHandleText(IntPtr hWnd)
        {
            StringBuilder strbTitle = new StringBuilder(255);
            NativeWin32.GetWindowText(hWnd, strbTitle, strbTitle.Capacity + 1);
            return strbTitle.ToString();
        }

        public static long FindSubHandle(IntPtr hWnd, HtsControls control)
        {
            var allChildWindows = new WindowHandleInfo(hWnd).GetAllChildHandles();

            foreach (var handle in allChildWindows)
            {
                string windowInfo = GetWindowInfo(handle);

                switch (control)
                {
                    case HtsControls.EDITBOX:
                        if (windowInfo == "Edit" && NativeWin32.IsWindowVisible(handle))
                        {
                            IntPtr phw = NativeWin32.GetParent(handle);
                            string pInfo = GetWindowInfo(phw);

                            IntPtr nhw = NativeWin32.GetWindow(phw, NativeWin32.GW_HWNDNEXT);
                            string nInfo = GetWindowInfo(nhw);

                            if (pInfo == "AfxWnd1101" && nInfo == "Button계약")
                            {
                                return handle.ToInt64();
                            }
                        }
                        break;

                    case HtsControls.LBL_POS:
                        if (windowInfo == "Button매도가능" && NativeWin32.IsWindowVisible(handle))
                        {
                            IntPtr phw = handle;
                            for (int i = 1; i <= 2; i++)
                            {
                                phw = NativeWin32.GetWindow(phw, NativeWin32.GW_HWNDPREV);
                            }
                            return phw.ToInt64();
                        }
                        break;

                    case HtsControls.LBL_CONT:
                        if (windowInfo == "Button매도가능" && NativeWin32.IsWindowVisible(handle))
                        {
                            IntPtr phw = handle;
                            for (int i = 1; i <= 3; i++)
                            {
                                phw = NativeWin32.GetWindow(phw, NativeWin32.GW_HWNDPREV);
                            }
                            return phw.ToInt64();
                        }
                        break;

                    case HtsControls.LBL_PRICE:
                        if (windowInfo == "Button매도가능" && NativeWin32.IsWindowVisible(handle))
                        {
                            IntPtr phw = handle;
                            for (int i = 1; i <= 4; i++)
                            {
                                phw = NativeWin32.GetWindow(phw, NativeWin32.GW_HWNDPREV);
                            }
                            return phw.ToInt64();
                        }
                        break;

                    case HtsControls.LBL_PGSI:
                        if (windowInfo == "Button매도가능" && NativeWin32.IsWindowVisible(handle))
                        {
                            IntPtr phw = handle;
                            for (int i = 1; i <= 5; i++)
                            {
                                phw = NativeWin32.GetWindow(phw, NativeWin32.GW_HWNDPREV);
                            }
                            return phw.ToInt64();
                        }
                        break;

                    case HtsControls.수치조회창:
                        if (windowInfo == "#32770수치조회창 - 실시간" && NativeWin32.IsWindowVisible(handle))
                        {
                            IntPtr phw = handle;
                            phw = NativeWin32.GetWindow(phw, NativeWin32.GW_CHILD);
                            return phw.ToInt64();
                        }
                        break;
                }

            }

            return 0;
        }
    }
}
