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
    public partial class AddNewTypeForm : Form
    {
        TurService turService = new TurService();
        public AddNewTypeForm()
        {
            InitializeComponent();
            FillGrid();
        }

        private void AddNewTypeForm_Load(object sender, EventArgs e)
        { 
            ClearForm();
            FillGrid();
        }
        public void FillGrid()
        {
            dgvList.DataSource = turService.GetAllList();
            dgvList.ClearSelection();
            SetColumnVisibilities();
        }
        public void SetColumnVisibilities()
        {
            dgvList.Columns["Id"].Visible = false;
            dgvList.Columns["OyunTurleri"].Visible = false;
        }
        private void ClearForm()
        {
            tbTur.Text = "";
            dgvList.ClearSelection();
            bAdd.Text = "Ekle";
        }
        int? GetIdFromDataGridView()
        {
            int? result = null;
            if (dgvList.SelectedRows.Count == 1)
            {
                result = Convert.ToInt32(dgvList.SelectedRows[0].Cells[0].Value);
            }
            return result;
        }
        static bool sayiMi(string deger)
        {
            try
            {
                int.Parse(deger);

                return true;
            }
            catch (Exception)
            { 
                return false;
            }
        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int? result = GetIdFromDataGridView();
                bool a = sayiMi(tbTur.Text);
                if ((String.IsNullOrWhiteSpace(tbTur.Text)) && !(result.HasValue) || a == true)
                {
                    
                    MessageBox.Show("Boş Alan Bırakılamaz!");
                    return;
                }
                Tur tur = new Tur();
                tur.Adi = tbTur.Text.Trim();
                turService.Add(tur);
                MessageBox.Show("Tür Veritabanına Eklendi!");
                ClearForm();
                FillGrid();
            }
            catch (Exception exception)
            {

                MessageBox.Show("Hata: " + exception.Message);
            }
        }
    }
}
