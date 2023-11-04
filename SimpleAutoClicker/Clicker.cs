using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace SimpleAutoClicker
{
    public class Clicker
    {
        [DllImport("user32.dll")]
        public static extern int SetCursorPos(int x, int y);
        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        
        protected bool _isCanceled = false;
        private int highI = 4000;
        private int lowI = 2000;

        public void SetHighLimit(double value)
        {
            highI = (int)Math.Ceiling(value * 1000.0);
        }
        
        public void SetLowLimit(double value)
        {
            lowI = (int)Math.Ceiling(value * 1000.0);
        }

        public void ResetLimits()
        {
            highI = 4000;
            lowI = 2000;
        }
        
        public void Start()
        {
            if (_isCanceled)
            {
                _isCanceled = false;
            }
            
            while (_isCanceled == false)
            {
                Random randomValue = new Random();
                Thread.Sleep(randomValue.Next(lowI, highI));
                Click();
            }
        }

        public void Stop(Thread t)
        {
            this._isCanceled = true;
            t?.Abort();
        }

        void Click()
        {
            Random offsetCursor = new Random();
            int x = Cursor.Position.X + offsetCursor.Next(-2, 2);
            int y = Cursor.Position.Y + offsetCursor.Next(-2, 2);
            SetCursorPos(x, y);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (int)x, (int)y, 0, 0);
        }
    }
}