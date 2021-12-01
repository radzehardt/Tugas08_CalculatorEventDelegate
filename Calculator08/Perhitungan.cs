using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator08
{
    public partial class Perhitungan : Form
    {
        public delegate void KalkulasiEventHandler(Kalkulator kalkulasi);
        public event KalkulasiEventHandler OnCalculated;

        private Kalkulator kalkulasi;
        public Perhitungan()
        {
            InitializeComponent();
        }

        public Perhitungan(string judul) : this()
        {
            this.Text = judul;
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            kalkulasi = new Kalkulator();
            int a = int.Parse(txtNilaiA.Text);
            int b = int.Parse(txtNilaiB.Text);

            switch (cmbOP.Text)
            {
                case "Penjumlahan":
                    kalkulasi.HasilPerhitungan = string.Format("Hasil Penjumlahan {0} + {1} = {2}", a, b, a + b);
                    break;
                case "Pengurangan":
                    kalkulasi.HasilPerhitungan = string.Format("Hasil Pengurangan {0} - {1} = {2}", a, b, a - b);
                    break;
                case "Perkalian":
                    kalkulasi.HasilPerhitungan = string.Format("Hasil Perkalian {0} x {1} = {2}", a, b, a * b);
                    break;
                case "Pembagian":
                    kalkulasi.HasilPerhitungan = string.Format("Hasil Pembagian {0} / {1} = {2}", a, b, a / b);
                    break;
                default:
                    break;
            }



            OnCalculated(kalkulasi);
            txtNilaiA.Clear();
            txtNilaiB.Clear();
            txtNilaiA.Focus();
        }


    }
}
