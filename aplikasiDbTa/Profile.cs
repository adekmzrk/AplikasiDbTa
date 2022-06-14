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
    public partial class Profile : Form
    {
        private readonly DbTaEntities _Ta;
        private string vUser;
        private string vRole;
        public Profile(string vUser, string vRole)
        {
            this.vUser = vUser;
            this.vRole = vRole;
            InitializeComponent();
            _Ta = new DbTaEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vPassLama = textBox1.Text.Trim();
            string vPassBaru = textBox2.Text.Trim();
            string vPassConfirm = textBox3.Text.Trim();

            if (vRole == "mhs")
            {
                var result = _Ta.tbl_mhs.FirstOrDefault(q => q.email.ToLower() == vUser);
                if (vPassLama != result.password.Trim())
                {
                    MessageBox.Show("Pasword lama tidak sesuai!");
                }
                else if (vPassBaru != vPassConfirm)
                {
                    MessageBox.Show("Konfirmasi password tidak sesuai!");
                } 
                else
                {
                    result.password = vPassBaru;
                    _Ta.SaveChanges();
                    MessageBox.Show("Password berhasil disimpan!");
                    this.Close();
                }
            } 
            else
            {
                var result = _Ta.tbl_dosen.FirstOrDefault(q => q.email.ToLower() == vUser);
                if (vPassLama != result.password.Trim())
                {
                    MessageBox.Show("Pasword lama tidak sesuai!");
                }
                else if (vPassBaru != vPassConfirm)
                {
                    MessageBox.Show("Konfirmasi password tidak sesuai!");
                }
                else
                {
                    result.password = vPassBaru;
                    _Ta.SaveChanges();
                    MessageBox.Show("Password berhasil disimpan!");
                    this.Close();
                }
            } 
        }

    }
}

