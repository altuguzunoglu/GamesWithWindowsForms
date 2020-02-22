using GamesWForm.Entities;
using GamesWForm.Manager;
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
    public partial class DeleteGameForm : Form
    {
        OyunlarService oyunlarService = new OyunlarService();
        FormManager formManager = new FormManager();
        public DeleteGameForm()
        {
            InitializeComponent();
        }

        private void DeleteGameForm_Load(object sender, EventArgs e)
        {
            
        }
        public void FillGrid()
        {
            dgvList.DataSource = oyunlarService.GetAllList();
            dgvList.ClearSelection();
            SetColumnVisibilities();
        }
        public void SetColumnVisibilities()
        {
            dgvList.Columns["Id"].Visible = false;
            dgvList.Columns["Yil"].Visible = false;
            dgvList.Columns["OyunTurleri"].Visible = false;
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
            {
                string warning ="Oyunu Veritabanından Tamamen Silmek İstiyor Musunuz?";
                string title="Oyun Sil";
                DialogResult result;
                MessageBoxButtons buttons;
                int? id = GetIdFromDataGridView();
                if (id.HasValue)
                {
                    buttons = MessageBoxButtons.OKCancel;
                    result = MessageBox.Show(warning, title, buttons);
                    if (result == DialogResult.OK)
                    {
                        oyunlarService.Delete(id.Value);
                        FillGrid();
                        MessageBox.Show("Oyun Veritabanından Silindi!");
                        formManager.ShowDeleteGameForm(this.MdiParent);
                    }
                }
                else
                {
                    MessageBox.Show("Listeden Bir Oyun Seçin!");
                }
            }
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
