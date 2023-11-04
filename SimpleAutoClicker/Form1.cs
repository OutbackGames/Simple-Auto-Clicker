using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleAutoClicker
{
    public partial class Form1 : Form
    {
        private KeyHandler ghk;

        private bool _clickerEnabled = false;
        private Clicker _clicker = new Clicker();
        private Thread clickerThread;
        public Form1()
        {
            InitializeComponent();
            ghk = new KeyHandler(Keys.Home, this);
            ghk.Register();
        }
        
        private void HandleHotkey()
        {
            ToggleClicker();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
                HandleHotkey();
            base.WndProc(ref m);
        }
        
        private void startClickerBtn_Click(object sender, EventArgs e)
        {
            ToggleClicker();
        }

        void ToggleClicker()
        {
            if (_clickerEnabled)
            {
                _clicker.Stop(clickerThread);
                _clickerEnabled = false;
            }
            else
            {
                clickerThread = new Thread(new ThreadStart(_clicker.Start));
                clickerThread?.Start();
                _clickerEnabled = true;
            }
            lblClickerState.Text = _clickerEnabled ? "Clicker State: Enabled" : "Clicker State: Disabled";
        }

        private void stopClickerBtn_Click(object sender, EventArgs e)
        {
            _clicker.Stop(clickerThread);
            _clickerEnabled = false;
            lblClickerState.Text = _clickerEnabled ? "Clicker State: Enabled" : "Clicker State: Disabled";
        }
        private void setTimeRangeBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tboxMaxSeconds.Text) || String.IsNullOrWhiteSpace(tboxMaxSeconds.Text) ||
                String.IsNullOrEmpty(tboxMinSeconds.Text) || String.IsNullOrWhiteSpace(tboxMinSeconds.Text))
            {
                MessageBox.Show("Number Entries Cannot Be Empty!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            try
            {
                var min = Double.Parse(tboxMinSeconds.Text);
                var max = Double.Parse(tboxMaxSeconds.Text);
                if (min > max)
                {
                    MessageBox.Show("Minimum Must Be Less Than Than Maximum","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    _clicker.SetHighLimit(max);
                    _clicker.SetLowLimit(min);
                }
            }
            catch (FormatException ex)
            {
                var err = ex.ToString();
                MessageBox.Show("Must Be A Number.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void resetTimeRangeBtn_Click(object sender, EventArgs e)
        {
            _clicker.ResetLimits();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _clicker.Stop(clickerThread);
            _clickerEnabled = false;
            lblClickerState.Text = _clickerEnabled ? "Clicker State: Enabled" : "Clicker State: Disabled";
        }
    }
}