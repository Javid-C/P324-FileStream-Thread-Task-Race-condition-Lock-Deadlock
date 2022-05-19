using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    Thread.Sleep(100);
                    progressBar1.Value = i;
                }
            });
            thread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    Thread.Sleep(100);

                    progressBar2.Value = i;
                }
            });
            thread.Start();
        }
    }
}
