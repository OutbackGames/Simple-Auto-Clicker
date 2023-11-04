//Solution by "Przemysław Kalita": https://stackoverflow.com/questions/18291448/how-do-i-detect-keypress-while-not-focused#:~:text=HandleHotkey%20is%20your%20button%20press%20handler.%20You%20can,reacts%20for%20buton%20input%20even%20if%20not%20focused.
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace SimpleAutoClicker
{
    public class KeyHandler
    {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private int key;
        private IntPtr hWnd;
        private int id;

        public KeyHandler(Keys key, Form form)
        {
            this.key = (int)key;
            this.hWnd = form.Handle;
            id = this.GetHashCode();
        }

        public override int GetHashCode()
        {
            return key ^ hWnd.ToInt32();
        }

        public bool Register()
        {
            return RegisterHotKey(hWnd, id, 0, key);
        }

        public bool Unregiser()
        {
            return UnregisterHotKey(hWnd, id);
        }
    }
}