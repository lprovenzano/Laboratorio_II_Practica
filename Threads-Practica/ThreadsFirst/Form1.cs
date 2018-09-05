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

namespace ThreadsFirst
{
    public partial class Form1 : Form
    {
        Thread t;

        public Form1()
        {
            InitializeComponent();
        }

        public void AsignarHora()
        {
            while (true)
            {
                
                if (lblHora.InvokeRequired)
                {
                    this.lblHora.BeginInvoke((MethodInvoker)delegate()
                    {
                        this.lblHora.Text = DateTime.Now.ToString();
                    }
                    );
                }
                Thread.Sleep(1000);
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t = new Thread(AsignarHora);
            t.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            t.Abort();
            MessageBox.Show("Gracias por usar esto");
        }
    }
}
