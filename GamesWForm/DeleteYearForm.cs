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
    public partial class DeleteYearForm : Form
    {
        YillarService yillarService = new YillarService();
        public DeleteYearForm()
        {
            InitializeComponent();
        }

        private void DeleteYearForm_Load(object sender, EventArgs e)
        {

        }
        public void FillGrid()
        {
            dgvList.DataSource = yillarService.GetAllList();
            dgvList.ClearSelection();
            SetColumnVisibilities();
        }
        public void SetColumnVisibilities()
        {
            dgvList.Columns["Id"].Visible = false;
            dgvList.Columns["Oyunlar"].Visible = false;
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
        private void bDelete_Click(object sender, EventArgs e)
        {
            int? id = GetIdFromDataGridView();
            if (id.HasValue)
            {
                var yil = yillarService.GetById(id.Value);
                yillarService.Delete(yil);
                FillGrid();               
            }
            else
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz");
            }          
            FillGrid();
        }
    }
}
