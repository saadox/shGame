using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarioCheat
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            Process[] procs = Process.GetProcessesByName("Leps Craft World");

                if (procs.Length > 0)
                {
                    using (saad.CheatEngine.Memory mem = new saad.CheatEngine.Memory(procs[0]))
                    {
                        IntPtr address = mem.GetAddress("\"Leps Craft World.dll\"+0064B62C+28");
                        mem.WriteInt32(address, Convert.ToInt32(txtTime.Text));
                    }
                }
        }

        private void btnGold_Click(object sender, EventArgs e)
        {
            Process[] procs = Process.GetProcessesByName("Leps Craft World");
            if (procs.Length > 0)
            {
                using (saad.CheatEngine.Memory mem = new saad.CheatEngine.Memory(procs[0]))
                {
                    IntPtr address = mem.GetAddress("\"Leps Craft World.dll\"+0064B604+38");
                    mem.WriteInt32(address, Convert.ToInt32(txtGold.Text));
                }
            }
        }

        private void btnPis_Click(object sender, EventArgs e)
        {
            Process[] procs = Process.GetProcessesByName("Leps Craft World");
            if (procs.Length > 0)
            {
                using (saad.CheatEngine.Memory mem = new saad.CheatEngine.Memory(procs[0]))
                {
                    IntPtr address = mem.GetAddress("\"Leps Craft World.dll\"+0064B604+40");
                    mem.WriteInt32(address, Convert.ToInt32(txtPis.Text));
                }
            }
        }

        private void btnLife_Click(object sender, EventArgs e)
        {
            Process[] procs = Process.GetProcessesByName("Leps Craft World");
            if (procs.Length > 0)
            {
                using (saad.CheatEngine.Memory mem = new saad.CheatEngine.Memory(procs[0]))
                {
                    IntPtr address = mem.GetAddress("\"UnityPlayer.dll\"+0104A714+74C");
                    mem.WriteInt32(address, Convert.ToInt32(txtLife.Text));
                }
            }
        }
    }
}
