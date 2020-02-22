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
    public partial class DeleteTypeForm : Form
    {
        TurService turService = new TurService();
        public DeleteTypeForm()
        {
            InitializeComponent();
        }

        private void DeleteTypeForm_Load(object sender, EventArgs e)
        {
           
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
                var tur = turService.GetById(id.Value);
               
                    turService.Delete(id.Value);
                    MessageBox.Show("Tür Veritabanından Silindi!");
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

