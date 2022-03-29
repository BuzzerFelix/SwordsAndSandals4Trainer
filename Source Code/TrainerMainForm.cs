using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace SwordsAndSandals4Trainer
{
    public partial class TrainerMainForm : Form
    {
        public Mem mem = new Mem();
        int skillpoints = 6000*8; //Don't Forget Convert to String, otherwise this Trainer don't work :D
        int money = 9999999*8; //mem.ReadInt(address via Cheat Engine)
        //mem.WriteMemory(found address via Cheat Engine, "int", money.ToString())
        public TrainerMainForm()
        {
            Directory.CreateDirectory(@"C:\Temp");
            InitializeComponent();
            OpenProcess();
            mem.getModules();
            if (mem.isAdmin() == true)
            {
                MessageBox.Show("Runned as Admin!!!");
            }
            else
            {
                Trace.WriteLine("Please run this Trainer as Admin");
                Environment.Exit(1234);
            }
        }

        public void OpenProcess()
        {
            Process[] process = Process.GetProcessesByName("ss4_downloadable");
            foreach(Process proc in process)
            {
                MessageBox.Show(mem.getProcIDFromName("ss4_downloadable").ToString(), "Swords and Sandals 4 Trainer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(process.Length == 1)
            {
                InjectTrainer();
            }
            else
            {
                MessageBox.Show("Please Launch ss4_downloadable and try again run this trainer", "SS4 Trainer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(213);
            }
        }
        public void InjectTrainer()
        {
            ProcessID.Text = $"Pid: {mem.OpenProcess(mem.getProcIDFromName("ss4_downloadable")).ToString()}"; //Game is Launched
            mem.DumpMemory(1);
        }

        private void sas4_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true) //infinite loop
            {
                mem.DumpMemory(2);
            }
        }

        private void inf_skillpoints_Click(object sender, EventArgs e)
        {
            mem.OpenProcess(mem.getProcIDFromName("ss4_downloadable.exe")); //Get Proc ID from This Game :D
            mem.writeMemory("0x04214130", "int", skillpoints.ToString()); //Write Memory to this Game, in this game, the addresses changing when the game is restarted and with a new level it happens exactly the same
            mem.readInt("0x04214130");
            MessageBox.Show($"{mem.getMinAddress().ToString()}"); //Minimum Address from this Game :D
            mem.getModules();
            MessageBox.Show($"{mem.modules.ToString()}"); //Modules from This Trainer and This Game :D
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mem.closeProcess();
            Environment.Exit(21);
        }
    }
}

