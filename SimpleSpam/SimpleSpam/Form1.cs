using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SimpleSpam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }



        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string mes = Encoding.Unicode.GetString(Encoding.Unicode.GetBytes(textBox1.Text));
            SendKeys.Send(textBox1.Text);
            SendKeys.Send("{ENTER}");
            
        }

        private void firefoxCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (firefoxCheckBox1.Checked)
            {
                textBox3.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text == null || textBox1.Text == null)
            {
                MessageBox.Show("You forgot something!");
            }
            else
            {
                if (firefoxCheckBox1.Checked)
                {
                    timer1.Interval = int.Parse(textBox3.Text);

                }
                else
                {
                    if (textBox2.Text == "1")
                        timer1.Interval = 1500;
                    if (textBox2.Text == "2")
                        timer1.Interval = 500;
                    if (textBox2.Text == "3")
                        timer1.Interval = 100;

                }
                System.Threading.Thread.Sleep(3000);
                SetHook();
                timer1.Start();
            }    
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UnHook();
            timer1.Stop();
        }

        // ... { Keylogger}
        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        const int WH_KEYBOARD_LL = 13; 
        const int WM_KEYDOWN = 0x100; 

        private LowLevelKeyboardProc _proc = hookProc;

        private static IntPtr hhook = IntPtr.Zero;

        public void SetHook()
        {
            IntPtr hInstance = LoadLibrary("User32");
            hhook = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, hInstance, 0);
        }

        public static void UnHook()
        {
            UnhookWindowsHookEx(hhook);
        }

        public static IntPtr hookProc(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                if (vkCode.ToString() == "81")
                {
                    MessageBox.Show("You pressed 'Q' exiting!");
                    Thread.Sleep(200);
                    Environment.Exit(0);
                }
                return (IntPtr)1;
            }
            else
                return CallNextHookEx(hhook, code, (int)wParam, lParam);
        }
    }
}
