using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaoPauloWindowsForms
{
    public partial class AdminMenuForm : Form
    {
        public AdminMenuForm()
        {
            InitializeComponent();
        }

        DateTime datetime = new DateTime(2018, 09, 05);

        private void AdminMenuForm_Load(object sender, EventArgs e)
        {
            Size = new Size(720, 480);
            StartPosition = FormStartPosition.CenterScreen;

            //for countdown
            Timer t = new Timer();
            t.Interval = 500;
            t.Tick += new EventHandler(t_Tick);
            TimeSpan ts = datetime.Subtract(DateTime.Now);
            lblTime.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
            t.Start();
        }
        public void t_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = datetime.Subtract(DateTime.Now);
            lblTime.Text = ts.ToString("d' Days 'h' Hours 'm' Minutes 's' Seconds'");
        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            Form1 mainmenu = new Form1();
            this.Hide();
            mainmenu.Show();
        }
    }
}
