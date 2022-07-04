using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikasiDbTa
{
    public partial class InputData : Form
    {
        private readonly DbTaEntities _Ta;
        public InputData()
        {
            InitializeComponent();
            _Ta = new DbTaEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.InitialDirectory = @"D:\";
            saveFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var client = new WebClient())
                {
                    client.DownloadFile(url, saveFileDialog1.FileName);
                    MessageBox.Show("File berhasil di download!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"D:\";
            openFileDialog1.Title = "Browse CSV Files";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "csv";
            openFileDialog1.Filter = "csv files (*.csv)|*.csv";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                using (var reader = new StreamReader(filename))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    //csv.Context.RegisterClassMap<MhsMap>();
                    var records = csv.GetRecords<tbl_mhs>();

                    _Ta.tbl_mhs.AddRange(records);
                    _Ta.SaveChanges();
                    MessageBox.Show("Berhasil di export!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"D:\";
            openFileDialog1.Title = "Browse CSV Files";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "csv";
            openFileDialog1.Filter = "csv files (*.csv)|*.csv";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                using (var reader = new StreamReader(filename))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    //csv.Context.RegisterClassMap<MhsMap>();
                    var records = csv.GetRecords<tbl_dosen>();

                    _Ta.tbl_dosen.AddRange(records);
                    _Ta.SaveChanges();
                    MessageBox.Show("Berhasil di export!");
                }
            }
        }
    }
    public class MhsMap : ClassMap<tbl_mhs>
    {
        public MhsMap()
        {
            Map(m => m.password).Name("password");
            Map(m => m.email).Name("email");
        }
    }
}
