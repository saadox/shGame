using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MarioCheat
{
    public class vals
    {
        VAMemory VAM;

        public int rVal
        {
            get;
            set;
        }

        private int rTmp
        {
            get;
            set;
        }

        public void ProcessReadMemory(string ProcName)
        {
            VAM = new VAMemory(ProcName);
            if (VAM.CheckProcess())
            {
                long BaseAddr = 0 ;
                rVal =  VAM.ReadInt32((IntPtr)BaseAddr);
                MessageBox.Show(Convert.ToString(VAM.getBaseAddress));
                MessageBox.Show(Convert.ToString(BaseAddr));

            }
            else
            {
                MessageBox.Show("Please Open the Game first !");
            }
        }

        public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        public void ProcessWriteMemory(string ProcName, IntPtr addr, string value)
        {

            VAM = new VAMemory(ProcName);
            if (VAM.CheckProcess())
            {
                    VAM.WriteInt32(addr, Convert.ToInt32(value));
            }
            else
            {
                MessageBox.Show("Please Open the Game first !");
            }
        }
    }
}