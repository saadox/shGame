using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace changeByte
{
	public partial class BytesChanger : Form
	{
		public BytesChanger()
		{
			InitializeComponent();
		}

		private void Confirm_Click(object sender, EventArgs e)
		{

			IntPtr AobAddr = (IntPtr)0x13614F8;// our addr !

			// original bytes	: 0x83, 0x80, 0x68, 0x01, 0x00, 0x00, 0x05
			byte[] Original = { 0x83, 0x80, 0x68, 0x01, 0x00, 0x00, 0x05 };
			// Edited Bytes		: 0x90 , 0x90 , 0x90 , 0x90 , 0x90 , 0x90 , 0x90
			byte[] Edited	= { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };

			Process proc = Process.GetProcessesByName("MyTesTer")[0];
			mem.ProcessHandle = mem.OpenProcess(0x001F0FFF,false,proc.Id);


			if (NopCheck.Checked)
			{
				mem.WriteProcessMemory(mem.ProcessHandle,AobAddr,Edited,7,0);
			}
			else if (UnNopCheck.Checked)
			{
				mem.WriteProcessMemory(mem.ProcessHandle, AobAddr, Original, 7, 0);
			}
			else
			{
				MessageBox.Show("Please Check something");
			}
		}
	}
}
