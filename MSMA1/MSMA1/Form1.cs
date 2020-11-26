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
        private void btnRemove_Click(object sender, EventArgs e)
        {
            ArabaDalCls arabaDalCls = new ArabaDalCls();
            int id = Convert.ToInt32(arabaDgw.CurrentRow.Cells[0].Value);
            arabaDalCls.Delete(id);
            arabaDgw.DataSource = arabaDalCls.Listeleme();
            MessageBox.Show("Araç Kaydı Silindi");
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
            
            if (String.IsNullOrEmpty(tbxMarka.Text) || String.IsNullOrEmpty(tbxModel.Text) || String.IsNullOrEmpty(tbxFiyat.Text) || String.IsNullOrEmpty(tbxAciklama.Text))
            {
                MessageBox.Show("Eksik veri girdiniz! Alanların tümünü doldurmak zorunludur!");
            }
            
            else
            {
                arabaDgw.DataSource = arabaDalCls.Listeleme();
                MessageBox.Show("Araç Kaydı Eklendi");
                tbxMarka.Clear();
                tbxModel.Clear();
                tbxFiyat.Clear();
                tbxAciklama.Clear();
            }          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ArabaDalCls arabaDalCls = new ArabaDalCls();
            ArabaCls arabaCls = new ArabaCls {
                Id=Convert.ToInt32(arabaDgw.CurrentRow.Cells[0].Value),
                Marka = tbxMarkaUpdate.Text,
                Model = tbxModelUpdate.Text,
                Fiyat = Convert.ToDecimal(tbxFiyatUpdate.Text),
                Aciklama = tbxAciklamaUpdate.Text
            };
            arabaDalCls.Update(arabaCls);
            arabaDgw.DataSource = arabaDalCls.Listeleme();
            MessageBox.Show("Araç Kaydı Güncellendi.");
            tbxIdUpdate.Clear();
            tbxMarkaUpdate.Clear();
            tbxModelUpdate.Clear();
            tbxFiyatUpdate.Clear();
            tbxAciklamaUpdate.Clear();
        }

        private void arabaDgw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblUnlem.Visible = true;
            tbxIdUpdate.Text = arabaDgw.CurrentRow.Cells[0].Value.ToString();
            tbxMarkaUpdate.Text = arabaDgw.CurrentRow.Cells[1].Value.ToString();
            tbxModelUpdate.Text = arabaDgw.CurrentRow.Cells[2].Value.ToString();
            tbxFiyatUpdate.Text = arabaDgw.CurrentRow.Cells[3].Value.ToString();
            tbxAciklamaUpdate.Text = arabaDgw.CurrentRow.Cells[4].Value.ToString();
        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            tbxIdUpdate.Clear();
            tbxMarkaUpdate.Clear();
            tbxModelUpdate.Clear();
            tbxFiyatUpdate.Clear();
            tbxAciklamaUpdate.Clear();
            tbxMarka.Clear();
            tbxModel.Clear();
            tbxFiyat.Clear();
            tbxAciklama.Clear();
            lblUnlem.Visible = false;
        }
    }
}
