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
    public partial class HasilHitung : Form
    {
        private List<Kalkulator> listDariHasil = new List<Kalkulator>();
        public HasilHitung()
        {
            InitializeComponent();
            initialisasilv();
        }

        private void initialisasilv()
        {
            lvHasil.View = View.Details;

            lvHasil.Columns.Add("", 5, HorizontalAlignment.Left);
            lvHasil.Columns.Add("", 192, HorizontalAlignment.Left);


        }
        private void FrmKalkulator_OnCalculated(Kalkulator kalkulasi)
        {
            listDariHasil.Add(kalkulasi);

            ListViewItem daftar = new ListViewItem();
            daftar.SubItems.Add(kalkulasi.HasilPerhitungan);

            lvHasil.Items.Add(daftar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Perhitungan perhitungan = new Perhitungan("Calculator");
            perhitungan.OnCalculated += FrmKalkulator_OnCalculated;
            perhitungan.ShowDialog();
        }
    }
}
