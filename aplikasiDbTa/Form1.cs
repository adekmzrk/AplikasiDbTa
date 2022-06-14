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
    public partial class Form1 : Form
    {
        private readonly DbTaEntities _Ta;
        public Form1()
        {
            InitializeComponent();
            _Ta = new DbTaEntities();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string vUser = textBox1.Text.Trim().ToLower();
            string vPass = textBox2.Text.Trim();

            var resultMhs = _Ta.tbl_mhs.FirstOrDefault(q => q.email.ToLower() == vUser);
            if (resultMhs == null)
            {
                var resultDosen = _Ta.tbl_dosen.FirstOrDefault(q => q.email.ToLower() == vUser);
                if (resultDosen == null)
                {
                    MessageBox.Show("Username/Password salah!");
                }
                else if (resultDosen.password.Trim() == vPass)
                {
                    MessageBox.Show("Selamat Datang " + vUser);
                    var formDashboard = new Dashboard(vUser, "dosen");
                    formDashboard.ShowDialog();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Username/Password salah! ");
                }
            }
            else
            {
                if (resultMhs.password.Trim() == vPass)
                {
                    MessageBox.Show("Selamat Datang " + vUser);
                    var formDashboard = new Dashboard(vUser, "mhs");
                    formDashboard.ShowDialog();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Username/Password salah! ");
                }
            }
        }
    
    }
}
