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

namespace AccessControlProject
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();

        }
        public void StartForm()
        {
            Application.Run(new frmSplash());
            /*SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
            frm.AppName = "User Control";
            Application.Run(frm);*/
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Close();
        }

        ////////////
    }
}
