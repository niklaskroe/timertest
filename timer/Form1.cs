using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {
        private TimeSpan timeleft
        {
            get;
            set;
        }

        
        public Form1()
        {
            InitializeComponent();
            timeleft = new TimeSpan(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            timeleft = timeleft.Subtract(TimeSpan.FromSeconds(1));
            label1.Text timeleft.ToString(@"hh\:mm\:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeleft = new TimeSpan(0, 0, 10);
            label1.Text timeleft.ToString(@"hh\:mm\:ss");
            timerCountdown.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
