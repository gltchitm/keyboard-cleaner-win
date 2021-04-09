using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace KeyboardCleaner {
    public partial class KeyboardCleaner : Form {
        private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);
        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        private long rightMouseDown;

        internal enum HookType : int {
            WH_KEYBOARD = 2,
            WH_MOUSE = 7,
            WH_KEYBOARD_LL = 13,
            WH_MOUSE_LL = 14
        }
        internal enum MouseInputNotification : int {
            WM_RBUTTONDOWN = 516,
            WM_RBUTTONUP = 517
        }

        public KeyboardCleaner() {
            InitializeComponent();
            Cursor.Hide();
            SetWindowsHookEx((int)HookType.WH_MOUSE, Hook, LoadLibrary("user32"), 0);
            SetWindowsHookEx((int)HookType.WH_MOUSE_LL, Hook, LoadLibrary("user32"), 0);
            SetWindowsHookEx((int)HookType.WH_KEYBOARD, Hook, LoadLibrary("user32"), 0);
            SetWindowsHookEx((int)HookType.WH_KEYBOARD_LL, Hook, LoadLibrary("user32"), 0);
        }
        IntPtr Hook(int nCode, IntPtr wParam, IntPtr lParam) {
            if (nCode < 0) {
                return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
            }
            if (wParam == (IntPtr)MouseInputNotification.WM_RBUTTONDOWN) {
                rightMouseDown = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            } else if (wParam == (IntPtr)MouseInputNotification.WM_RBUTTONUP) {
                if (DateTimeOffset.Now.ToUnixTimeMilliseconds() - rightMouseDown >= 1_000) {
                    Application.Exit();
                }
            }
            return (IntPtr)1;
        }
    }
}