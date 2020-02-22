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
    public partial class AddNewGameForm : Form
    {
        OyunlarService oyunlarService = new OyunlarService();       
        YillarService yillarService = new YillarService();
        TurService turService = new TurService();
        public AddNewGameForm()
        {
            InitializeComponent();
        }
        private void AddNewGameForm_Load(object sender, EventArgs e)
        {          
            FillYillar();
            FillTurler();
        }
        public void FillGrid()
        {
            dgvAddGame.DataSource = oyunlarService.GetAllList();
            dgvAddGame.ClearSelection();
            SetColumnVisibilities();
        }

        private void bList_Click(object sender, EventArgs e)
        {
            FillGrid();
        }
        public void SetColumnVisibilities() {
            dgvAddGame.Columns["Id"].Visible = false;          
            dgvAddGame.Columns["Yil"].Visible = false;
            dgvAddGame.Columns["OyunTurleri"].Visible = false;
        }
        public void FillYillar()
        {
            cbYil.ValueMember = "Id";
            cbYil.DisplayMember = "Degeri";
            List<Yil> yillar = yillarService.GetAllList();
            yillar.Insert(0, new Yil()
            {
                Id = 0,
                Degeri = "--Seçiniz--"
            });
            cbYil.DataSource = yillar;
        }
        public void FillTurler()
        {
            clbTur.DataSource = turService.GetAllList().ToList();
            clbTur.ValueMember = "Id";
            clbTur.DisplayMember = "Adi";        
        }       
        private void bAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(tbName.Text) || String.IsNullOrWhiteSpace(tbMaaliyet.Text) ||
                    cbYil.SelectedIndex == 0 || clbTur.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Boş Alan Bırakılamaz!");
                    return;
                }
                Oyun oyun = new Oyun();
                oyun.Id = 0;
                oyun.Adi = tbName.Text.Trim();
                oyun.Maliyeti = Convert.ToInt32(tbMaaliyet.Text);
                oyun.Kazanci = Convert.ToDouble(tbKazanc.Text.Trim());               
                oyun.OyunTurleri = new List<OyunTur>();
                oyun.YilId = Convert.ToInt32(cbYil.SelectedValue);
                OyunTur oyunTur;
                Tur tur;
                foreach (var a in clbTur.CheckedItems)
                {
                    tur = a as Tur;
                    oyunTur = new OyunTur()
                    {
                        OyunId = oyun.Id,
                        TurId = tur.Id
                    };
                    oyun.OyunTurleri.Add(oyunTur);
                }
                oyunlarService.Add(oyun);
                MessageBox.Show("Oyun Veritabanına Eklendi!");                
                FillGrid();
            }
            catch (FormatException exc)
            {
                MessageBox.Show("Yanlış Veri Girişi!");
            }        
        }
        }
    } 


