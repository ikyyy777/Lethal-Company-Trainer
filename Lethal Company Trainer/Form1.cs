using Swed64;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Lethal_Company_Trainer
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        private Swed memory;  // Declare Swed as a member variable

        public static int currMoney;

        // Offsets
        public static IntPtr pHealth;
        public static IntPtr pStamina;
        public static IntPtr pMoney;
        public static IntPtr pSpeed;
        public static IntPtr pJumpHeight;
        public static IntPtr pClimbSpeed;
        public static IntPtr pGrabDistance;
        public static IntPtr pWeight;

        public Form1()
        {
            InitializeComponent();

        }

        public void UpdateCurrentMoneyLabel(int money)
        {
            if (label_currentMoney.InvokeRequired)
            {
                label_currentMoney.Invoke(new Action(() => label_currentMoney.Text = money.ToString()));
            }
            else
            {
                label_currentMoney.Text = money.ToString();
            }
        }

        public async void readMemory()
        {
            while (true)
            {
                // Money
                int _currMoney = memory.ReadInt(pMoney);
                currMoney = _currMoney;

                // Update the UI from the UI thread
                UpdateCurrentMoneyLabel(currMoney);

                await Task.Delay(1000);
            }
        }

        // Write money memory
        public void setMoney()
        {
            memory.WriteInt(pMoney, int.Parse(textBox1.Text));
        }

        // Write stamina memory
        public async void infiniteStamina()
        {
            while (checkBox_Stamina.Checked)
            {
                memory.WriteFloat(pStamina, 1);
                await Task.Delay(100);
            }
        }

        // Write player's health memory aka God Mode
        public async void godMode()
        {
            while (checkBox_GodMode.Checked)
            {
                memory.WriteFloat(pHealth, 140);
                await Task.Delay(100);
            }
        }

        // Write player's speed
        public async void speedHack()
        {
            while (true)
            {
                if (checkBox_SpeedHack.Checked)
                {
                    memory.WriteFloat(pSpeed, 10);
                    await Task.Delay(100);
                }
                else
                {
                    memory.WriteFloat(pSpeed, 4.599999905f);
                    await Task.Delay(100);
                    return;
                }
            }
        }

        // Write player's jump height
        public async void highJump()
        {
            while (true)
            {
                if (checkBox_HighJump.Checked)
                {
                    memory.WriteFloat(pJumpHeight, 26);
                    await Task.Delay(100);
                }
                else
                {
                    memory.WriteFloat(pJumpHeight, 13);
                    await Task.Delay(100);
                    return;
                }
            }
        }

        // Write player's climbing speed
        public async void fastClimb()
        {
            while (true)
            {
                if (checkBox_FastClimb.Checked)
                {
                    memory.WriteFloat(pClimbSpeed, 6);
                    await Task.Delay(100);
                }
                else
                {
                    memory.WriteFloat(pClimbSpeed, 3);
                    await Task.Delay(100);
                }
            }
        }

        // Write player's Grab Distance
        public async void longGrab()
        {
            while (true)
            {
                if (checkBox_LongGrab.Checked)
                {
                    memory.WriteFloat(pGrabDistance, 100);
                    await Task.Delay(100);
                }
                else
                {
                    memory.WriteFloat(pGrabDistance, 3);
                    await Task.Delay(100);
                }
            }
        }

        // Write player's weight value
        public async void noWeight()
        {
            while (true)
            {
                if (checkBox_NoWeight.Checked)
                {
                    memory.WriteFloat(pWeight, 1f);
                    await Task.Delay(100);
                }
                else
                    return;
            }
        }

        // Check is process running
        static bool IsProcessRunning(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);
            return processes.Length > 0;
        }

        /// <summary>
        /// Front-End Section
        /// </summary>

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Check is game running?
            string processName = "Lethal Company";

            if (!IsProcessRunning(processName))
            {
                MessageBox.Show($"{processName} is not running. Please enter the game before starting the Trainer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Environment.Exit(0);
            }

            memory = new Swed(processName);  // Initialize memory as a member variable

            while (true)
            {
                await Task.Run(async () =>
                {
                    while (true)
                    {
                        // Get module base
                        IntPtr moduleBase = memory.GetModuleBase("UnityPlayer.dll");

                        // Initialize the offsets
                        pMoney = memory.ReadPointer(moduleBase, 0x1BE91C0, 0xC0, 0x18, 0xC0, 0x1C8, 0x1B0, 0xB0) + 0x1F0;
                        pStamina = memory.ReadPointer(moduleBase, 0x1BE92C0, 0xC0, 0xC0, 0x7E0, 0x218, 0x60, 0x88) + 0x420;
                        pHealth = memory.ReadPointer(moduleBase, 0x1BE92C0, 0xC0, 0xC0, 0x7E0, 0x218, 0x60, 0x88) + 0x56C;
                        pSpeed = memory.ReadPointer(moduleBase, 0x1CCC2D8, 0xD0, 0x8, 0x68, 0x10, 0xF8) + 0x3F8;
                        pJumpHeight = memory.ReadPointer(moduleBase, 0x1CCC2D8, 0xD0, 0x8, 0x68, 0x10, 0xF8) + 0x42C;
                        pClimbSpeed = memory.ReadPointer(moduleBase, 0x1CCC2D8, 0xD0, 0x8, 0x68, 0x10, 0xF8) + 0x63C;
                        pGrabDistance = memory.ReadPointer(moduleBase, 0x1CCC2D8, 0xD0, 0x8, 0x68, 0x10, 0xF8) + 0x5AC;
                        pWeight = memory.ReadPointer(moduleBase, 0x1CCC2D8, 0xD0, 0x8, 0x68, 0x10, 0xF8) + 0x5B8;

                        // Read memory value
                        readMemory();

                        // Write memory values (loops)
                        godMode();
                        infiniteStamina();
                        speedHack();
                        highJump();
                        fastClimb();
                        longGrab();
                        noWeight();

                        await Task.Delay(1000);
                    }
                });
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void button_SetMoney_Click(object sender, EventArgs e)
        {
            setMoney();
        }
    }
}
