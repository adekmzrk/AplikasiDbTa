using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikasiDbTa
{
    public partial class Dashboard : Form
    {

        private string vUser;
        private string vRole;

        public Dashboard(string vUser, string vRole)
        {
            InitializeComponent();
            this.vUser = vUser;
            this.vRole = vRole;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProfile = new Profile(vUser, vRole);
            formProfile.ShowDialog();
            Hide();
        }
    }
}
