using ASquare.WindowsTaskScheduler.Models;
using ASquare.WindowsTaskScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Clean_Recycle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
/*            Check_Key_Random();
            AutoClosingMessageBox.Show("Nhấn các phím màu xanh dương để kiểm tra bàn phím", "Lưu ý", 1000);
            CloseWindow();*/

        }

        private async void CloseWindow()
        {
            await ClosingTasks();
        }

        private async Task ClosingTasks()
        {
            await Task.Delay(15000);
            int countKey = 0;
            for (int i = 0; i < selected.Count; i++)
            {
                if (selected[i].ViewModel.PreviouslyPressed == false) countKey++;
            }
            if (countKey == selected.Count)
            {
                AutoClosingMessageBox.Show("Bàn phím hoạt động bình thường", "Kết quả", 1000);
            }
            else
            {
                AutoClosingMessageBox.Show("Kiểm tra các phím không nhập được", "Kết quả", 1000);
            }
            this.Close();
        }


        public class AutoClosingMessageBox
        {
            System.Threading.Timer _timeoutTimer;
            string _caption;
            AutoClosingMessageBox(string text, string caption, int timeout)
            {
                _caption = caption;
                _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                    null, timeout, System.Threading.Timeout.Infinite);
                using (_timeoutTimer)
                    MessageBox.Show(text, caption);
            }
            public static void Show(string text, string caption, int timeout)
            {
                new AutoClosingMessageBox(text, caption, timeout);
            }
            void OnTimerElapsed(object state)
            {
                IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
                if (mbWnd != IntPtr.Zero)
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                _timeoutTimer.Dispose();
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        }

        private void LeftAlt_KeyDown(object sender, KeyEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void MainWindow_OnKeyDown(object sender, KeyEventArgs e)
        {
            var keyControl = GetKeyControl(e);
            if (keyControl == null)
                return;
/*            if (!selected.Contains(keyControl))
                return;*/
            keyControl.ViewModel.Pressed = true;
            keyControl.ViewModel.PreviouslyPressed = true;

            if (keyControl == Return)
            {
                ReturnLower.ViewModel.Pressed = true;
                ReturnLower.ViewModel.PreviouslyPressed = true;
            }

            e.Handled = true;
        }

        private void MainWindow_OnKeyUp(object sender, KeyEventArgs e)
        {
            var keyControl = GetKeyControl(e);
            if (keyControl == null)
                return;
/*            if (!selected.Contains(keyControl))
                return;
            int countKey = 0;
            for (int i = 0; i < selected.Count; i++)
            {
                if (selected[i].ViewModel.PreviouslyPressed == false) countKey++;
            }
            if (countKey == selected.Count)
            {
                AutoClosingMessageBox.Show("Bàn phím hoạt động bình thường", "Kết quả", 100);
            }*/

            keyControl.ViewModel.Pressed = false;

            if (keyControl == Return)
                ReturnLower.ViewModel.Pressed = false;

            if (keyControl == Snapshot)
                Snapshot.ViewModel.PreviouslyPressed = true;

            e.Handled = true;
        }

        public List<KeyboardKey> selected = new List<KeyboardKey>();

        private void Check_Key_Random()
        {
            List<KeyboardKey> AllKeyBoard = new List<KeyboardKey>() {Escape, F1, F2, F3, F4, F5, F6, F7, F8, F9, F10, F11, F12,
                                                                     Oem3, D1, D2, D3, D4, D5, D6, D7, D8,D9, D0, OemMinus, OemPlus, Back,
                                                                     Tab, Q, W, E, R, T, Y, U, I, O, P, OemOpenBrackets, OemCloseBrackets, Return,
                                                                     Capital, A, S, D, F, G, H, J, K, L, OemSemicolon, OemQuotes,
                                                                     LeftShift, OemPipe, Z, X, C, V, B, N, M, OemComma, OemPeriod, OemQuestion, RightShift,
                                                                     LeftCtrl, LWin, LeftAlt, Space, Space, RWin, Apps, RightCtrl,
                                                                     Left, Down, Right, Up, Insert, Home, PageUp, Delete, End, Next, Snapshot, Scroll, Pause,
                                                                     NumLock, Divide, Multiply, Subtract, NumPad7, NumPad8, NumPad9, Add, NumPad4, NumPad5, NumPad6,
                                                                     NumPad1, NumPad2, NumPad3, NumPadEnter, NumPad0, Decimal};
            int k = 10; // items to select
            double needed = k;
            double available = AllKeyBoard.Count;
            var rand = new Random();
            while (selected.Count < k)
            {
                if (rand.NextDouble() < needed / available)
                {
                    selected.Add(AllKeyBoard[(int)available - 1]);
                    needed--;
                }
                available--;
            }
            for (int i = 0; i < k; i++)
            {
                selected[i].ViewModel.PreviouslyPressed = true;
            }
        }

        private KeyboardKey GetKeyControl(KeyEventArgs keyEvent)
        {
            if (keyEvent.Key == Key.LeftCtrl && IsModifier(ModifierKeys.Control) && IsNotModifier(ModifierKeys.Alt))
            {
                if (keyEvent.IsRepeat)
                    return null;
                return LeftCtrl;
            }

            if (keyEvent.Key == Key.Enter)
            {
                if (ReadIsExteneded(keyEvent))
                    return NumPadEnter;
                return Return;
            }

            if (keyEvent.Key == Key.System)
            {
                /*                if (IsModifier(ModifierKeys.Alt))
                                    return LeftAlt;*/
                if (keyEvent.SystemKey == Key.F10)
                    return F10;
                if (keyEvent.SystemKey == Key.F11)
                    return F11;
                if (keyEvent.SystemKey == Key.F12)
                    return F12;
                if (ReadRealKey(keyEvent) == Key.LeftAlt)
                    return LeftAlt;
                if (ReadRealKey(keyEvent) == Key.RightAlt)
                    return RightAlt;
            }

            var keyControl = GetKeyControlNonStandard(keyEvent);

            if (keyControl == null)
                keyControl = FindName(keyEvent.Key.ToString()) as KeyboardKey;

            return keyControl;
        }

        private static bool ReadIsExteneded(KeyEventArgs keyEvent)
        {
            return (bool)typeof(KeyEventArgs).InvokeMember("IsExtendedKey", BindingFlags.GetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, keyEvent, null);
        }

        private static Key ReadRealKey(KeyEventArgs keyEvent)
        {
            return (Key)typeof(KeyEventArgs).InvokeMember("RealKey", BindingFlags.GetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, keyEvent, null);
        }

        private static bool IsModifier(ModifierKeys key)
        {
            return (Keyboard.Modifiers & key) == key;
        }

        private static bool IsNotModifier(ModifierKeys key)
        {
            return (Keyboard.Modifiers & key) != key;
        }

        private KeyboardKey GetKeyControlNonStandard(KeyEventArgs keyEvent)
        {
            switch (keyEvent.Key)
            {
                case Key.Oem1:
                    return OemSemicolon;
                case Key.Oem4:
                    return OemOpenBrackets;
                case Key.Oem5:
                    return OemPipe;
                case Key.Oem6:
                    return OemCloseBrackets;
                case Key.Oem7:
                    return OemQuotes;
                default:
                    return null;
            }
        }
    }
}
