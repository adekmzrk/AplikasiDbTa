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
    public partial class Jadwal : Form
    {
        private readonly DbTaEntities _Ta;
        public Jadwal()
        {
            InitializeComponent();
            _Ta = new DbTaEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            int id2 = Convert.ToInt16(id);

            var result = _Ta.tbl_jadwal.FirstOrDefault(q => q.id_ta == id2);

            if (result == null)
            {
                var vDate = dateTimePicker1.Value.Date;
                var vTime = dateTimePicker2.Value.TimeOfDay;
                string vRuang = comboBox1.Text;
                var newJadwal = new tbl_jadwal
                {
                    id_ta = Int32.Parse(id),
                    hari = vDate,
                    waktu = vTime,
                    ruangan = vRuang

                };
                _Ta.tbl_jadwal.Add(newJadwal);
                _Ta.SaveChanges();

                var formjadwal = new Jadwal();
                formjadwal.ShowDialog();
                Close();
            } else
            {
                MessageBox.Show("ID TA Sudah ditambahkan!");
            }
            
        }

        private void Jadwal_Load(object sender, EventArgs e)
        {
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH:mm";

            var dataTa = _Ta.tbl_ta.Select(q => new
            {
                q.id_ta,
                q.npm,
                q.judul_ta
            }).ToList();
            dataGridView1.DataSource = dataTa;

            var dataJadwal = _Ta.tbl_jadwal.Select(q => new
            {
                q.id_ta,
                q.hari,
                q.waktu,
                q.ruangan
            }).ToList();
            dataGridView2.DataSource = dataJadwal;

            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            int id2 = Convert.ToInt16(id);

            var Ditem = _Ta.tbl_jadwal.FirstOrDefault(q => q.id_ta == id2);
            if (Ditem != null)
            {
                _Ta.tbl_jadwal.Remove(Ditem);
                _Ta.SaveChanges();

                var formjadwal = new Jadwal();
                formjadwal.ShowDialog();
                this.Close();
            }


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (dataGridView2.CurrentCell != null && dataGridView2.CurrentCell.Value != null)
                    {
                        var id = (int)dataGridView2.CurrentRow.Cells["id_ta"].Value;
                        string ruang = (string)dataGridView2.CurrentRow.Cells["ruangan"].Value;
                        var hari = dataGridView2.CurrentRow.Cells["hari"].Value;
                        var waktu = dataGridView2.CurrentRow.Cells["waktu"].Value;
                        
                        dateTimePicker1.Value = Convert.ToDateTime(hari.ToString().Substring(0, 9));
                        dateTimePicker2.Value = Convert.ToDateTime(waktu.ToString().Substring(0, 10));
                        comboBox1.Text = ruang.ToString();
                        textBox1.Text = id.ToString();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                    {
                        var id = (int)dataGridView1.CurrentRow.Cells["id_ta"].Value;
                        textBox1.Text = id.ToString();
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
                        var id = (int)dataGridView1.SelectedRows[0].Cells["id_ta"].Value;
                        textBox1.Text = id.ToString();
            
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

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.CurrentRow.Index != -1)
                {
                    if (dataGridView2.CurrentCell != null && dataGridView2.CurrentCell.Value != null)
                    {
                        var id = (int)dataGridView1.SelectedRows[0].Cells["id_ta"].Value;
                        string ruang = (string)dataGridView2.SelectedRows[0].Cells["ruangan"].Value;
                        var hari = dataGridView2.SelectedRows[0].Cells["hari"].Value;
                        var waktu = dataGridView2.SelectedRows[0].Cells["waktu"].Value;


                        dateTimePicker1.Value = Convert.ToDateTime(hari.ToString().Substring(0, 9));
                        dateTimePicker2.Value = Convert.ToDateTime(waktu.ToString().Substring(0, 10));
                        comboBox1.Text = ruang.ToString();
                        textBox1.Text = id.ToString();

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
    }
}

//{
//    /*                PdfDocument doc = new PdfDocument("sample.pdf");
//                    PdfPageBase page = doc.Pages[0];

//                    PdfCertificate cert = new PdfCertificate("Demo.pfx", "e-iceblue");

//                    PdfSignature signature = new PdfSignature(doc, page, cert, "Budiarto");

//                    signature.ContactInfo = "raden.budiarto@poltekssn.ac.id";
//                    signature.Certificated = true;

//                    signature.DocumentPermissions = PdfCertificationFlags.AllowFormFill;

//                    doc.SaveToFile("singed.pdf");*/

//    PdfDocument doc = new PdfDocument();
//    doc.LoadFromFile("sample.pdf");
//    PdfCertificate cert = new PdfCertificate("Demo.pfx", "e-iceblue");

//    PdfSignature signature = new PdfSignature(doc, doc.Pages[doc.Pages.Count - 1], cert, "MySignature");
//    RectangleF rectangleF = new RectangleF(doc.Pages[0].ActualSize.Width - 260 - 54, 218, 218, 88);
//    signature.Bounds = rectangleF;
//    signature.Certificated = true;

//    signature.GraphicsMode = GraphicMode.SignImageOnly;
//    signature.SignImageSource = PdfImage.FromFile("ecerf.png");

//    doc.SaveToFile("VisiableSignature.pdf");
//    doc.Close();
//}