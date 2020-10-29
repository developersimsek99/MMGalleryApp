using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSMA1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArabaDalCls arabaDalcls = new ArabaDalCls();
            arabaDgw.DataSource = arabaDalcls.Listeleme();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ArabaDalCls arabaDalCls = new ArabaDalCls();
            arabaDalCls.Ekle(new ArabaCls {
                Marka = tbxMarka.Text,
                Model = tbxModel.Text,
                Fiyat = Convert.ToDecimal(tbxFiyat.Text),
                Aciklama = tbxAciklama.Text
            });
            arabaDgw.DataSource = arabaDalCls.Listeleme();
            MessageBox.Show("Araç Kaydı Eklendi");
        }
    }
}
