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
    public partial class FormTa : Form
    {
        private readonly DbTaEntities _Ta;
        public FormTa()
        {
            InitializeComponent();
            _Ta = new DbTaEntities();
        }

        private void FormTa_Load(object sender, EventArgs e)
        {
            string keyword = textBox4.Text;
            var dataMhs = _Ta.tbl_mhs.Select(q => new
            {
                q.NPM,
                q.Nama,
                q.Prodi
            }).ToList();
            dataGridView1.DataSource = dataMhs;
            
            var namaDosen = _Ta.tbl_dosen.ToList();
            var namaDosen2 = _Ta.tbl_dosen.ToList();
            var namaDosen3 = _Ta.tbl_dosen.ToList();

            comboBox1.DataSource = namaDosen;
            comboBox1.DisplayMember = "Nama";
            comboBox1.ValueMember = "Nama";
            comboBox1.Text = "--Select--";

            comboBox2.DataSource = namaDosen2;
            comboBox2.DisplayMember = "Nama";
            comboBox2.ValueMember = "Nama";
            comboBox2.Text = "--Select--";

            comboBox3.DataSource = namaDosen3;
            comboBox3.DisplayMember = "Nama";
            comboBox3.ValueMember = "Nama";
            comboBox3.Text = "--Select--";

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox4.Text;
            var dataMhs = _Ta.tbl_mhs.Select(q => new
            {
                q.NPM,
                q.Nama,
                q.Prodi
            }).ToList();

            var result = dataMhs.Where(q => q.Nama.Contains(keyword)).ToList();


            if (result != null)
            {
                dataGridView1.DataSource = result;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                    {
                        var npm = (string)dataGridView1.CurrentRow.Cells["NPM"].Value;
                        var nama = (string)dataGridView1.CurrentRow.Cells["Nama"].Value;
                        var prodi = (string)dataGridView1.CurrentRow.Cells["Prodi"].Value;
                        textBox1.Text = npm;
                        textBox2.Text = nama;
                        textBox3.Text = prodi;
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Kesalahan: " + ex);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                    {
                        var npm = (string)dataGridView1.SelectedRows[0].Cells["NPM"].Value;
                        var nama = (string)dataGridView1.SelectedRows[0].Cells["Nama"].Value;
                        var prodi = (string)dataGridView1.SelectedRows[0].Cells["Prodi"].Value;
                        textBox1.Text = npm;
                        textBox2.Text = nama;
                        textBox3.Text = prodi;
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Kesalahan: " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vNpm = textBox1.Text;
            string vJudul = textBox5.Text;
            string NipPembimbing = _Ta.tbl_dosen.First(q => q.nama == comboBox1.Text).nip;
            string NipPenguji1 = _Ta.tbl_dosen.First(q => q.nama == comboBox2.Text).nip;
            string NipPenguji2 = _Ta.tbl_dosen.First(q => q.nama == comboBox3.Text).nip;

            var ExistingNpm = _Ta.tbl_ta.Select(q => q.npm).ToList();
            if (ExistingNpm.Contains(vNpm))
            {
                MessageBox.Show("NPM duplikat!");
            }

            var newTa = new tbl_ta
            {
                npm = vNpm,
                pembimbing = NipPembimbing,
                penguji1 = NipPenguji1,
                penguji2 = NipPenguji2,
                judul_ta = vJudul
            };
            _Ta.tbl_ta.Add(newTa);
            _Ta.SaveChanges();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var namaDosen = _Ta.tbl_dosen.Select(q => q.nama).ToList();
            string[] authors = { comboBox1.Text, comboBox3.Text };
            var namaDosen2 = namaDosen.Except(authors).ToList();
            comboBox2.DataSource = namaDosen2;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var namaDosen = _Ta.tbl_dosen.Select(q => q.nama).ToList();
            string[] authors = { comboBox1.Text, comboBox2.Text };
            var namaDosen3 = namaDosen.Except(authors).ToList();
            comboBox3.DataSource = namaDosen3;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string vNpm = textBox1.Text;
            string vJudul = textBox5.Text;
            string NipPembimbing = _Ta.tbl_dosen.First(q => q.nama == comboBox1.Text).nip;
            string NipPenguji1 = _Ta.tbl_dosen.First(q => q.nama == comboBox2.Text).nip;
            string NipPenguji2 = _Ta.tbl_dosen.First(q => q.nama == comboBox3.Text).nip;
            _Ta.tbl_ta.First(q => q.npm == vNpm).judul_ta = vJudul;
            _Ta.tbl_ta.First(q => q.npm == vNpm).pembimbing = NipPembimbing;
            _Ta.tbl_ta.First(q => q.npm == vNpm).penguji1 = NipPenguji1;
            _Ta.tbl_ta.First(q => q.npm == vNpm).penguji2 = NipPenguji2;
            _Ta.SaveChanges();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string vNpm = textBox1.Text;
            var Ditem = _Ta.tbl_ta.FirstOrDefault(q => q.npm == vNpm);
            if (Ditem != null)
            {
                _Ta.tbl_ta.Remove(Ditem);
                _Ta.SaveChanges();
            }
        }
    }
}
