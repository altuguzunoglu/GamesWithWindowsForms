using GamesWForm.Entities;
using GamesWForm.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesWForm
{
    public partial class AddNewYearForm : Form
    {
        YillarService yillarService = new YillarService();
        public AddNewYearForm()
        {
            InitializeComponent();
        }

        private void AddNewYearForm_Load(object sender, EventArgs e)
        {

        }
        public void SetColumnVisibilities()
        {
            dgvList.Columns["Id"].Visible = false;
            dgvList.Columns["Oyunlar"].Visible = false;
        }
        public void FillGrid()
        {
            dgvList.DataSource = yillarService.GetAllList();
            dgvList.ClearSelection();
            SetColumnVisibilities();
        }

        private void bEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int result;
                if (!String.IsNullOrWhiteSpace(tbYil.Text) && Int32.TryParse(tbYil.Text, out result)) {
                    Yil yil = new Yil();
                    {
                        yil.Degeri = tbYil.Text;
                        yillarService.AddYil(yil);
                        FillGrid();
                        MessageBox.Show("Yıl Veritabanına Eklendi!");
                    }
                }
                else
                {
                    MessageBox.Show("Yanlış Yıl Girişi!");
                }         
            }
            catch (Exception)
            {
                MessageBox.Show("Yanlış Yıl Girişi!");
            }
          
        }
    }
}
