using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesWForm.Manager
{
    class FormManager
    {
        private static AddNewGameForm addNewGameForm = null;
        private static UpdateGameForm updateGameForm = null;
        private static DeleteGameForm deleteGameForm = null;
        private static AddNewTypeForm addNewTypeForm = null;
        private static DeleteTypeForm deleteTypeForm = null;
        private static AddNewYearForm addNewYearForm = null;
        private static DeleteYearForm deleteYearForm = null;
        public void ShowAddNewGameForm(Form OyunlarForm)
        {
            if (addNewGameForm == null || addNewGameForm.IsDisposed) 
            {
                addNewGameForm = new AddNewGameForm();
            }
            addNewGameForm.MdiParent = OyunlarForm;
            addNewGameForm.WindowState = FormWindowState.Maximized;
            addNewGameForm.Show();
            addNewGameForm.Focus();
            addNewGameForm.FillGrid();
        }
        public void ShowUpdateGameForm(Form OyunlarForm)
        {
            if (updateGameForm == null || updateGameForm.IsDisposed)
            {
                updateGameForm = new UpdateGameForm();
            }
            updateGameForm.MdiParent = OyunlarForm;
            updateGameForm.WindowState = FormWindowState.Maximized;
            updateGameForm.Show();
            updateGameForm.Focus();
            updateGameForm.FillGrid();
        }
        public void ShowDeleteGameForm(Form OyunlarForm)
        {
            if (deleteGameForm == null || deleteGameForm.IsDisposed)
            {
                deleteGameForm = new DeleteGameForm();
            }
            deleteGameForm.MdiParent = OyunlarForm;
            deleteGameForm.WindowState = FormWindowState.Maximized;
            deleteGameForm.Show();
            deleteGameForm.Focus();
            deleteGameForm.FillGrid();
        }
        public void ShowAddNewTypeForm(Form OyunlarForm)
        {
            if (addNewTypeForm == null || addNewTypeForm.IsDisposed)
            {
                addNewTypeForm = new AddNewTypeForm();
            }
            addNewTypeForm.MdiParent = OyunlarForm;
            addNewTypeForm.WindowState = FormWindowState.Maximized;
            addNewTypeForm.Show();
            addNewTypeForm.Focus();
            addNewTypeForm.FillGrid();
        }
        public void ShowDeleteTypeForm(Form OyunlarForm)
        {
            if (deleteTypeForm == null || deleteTypeForm.IsDisposed)
            {
                deleteTypeForm = new DeleteTypeForm();
            }
            deleteTypeForm.MdiParent = OyunlarForm;
            deleteTypeForm.WindowState = FormWindowState.Maximized;
            deleteTypeForm.Show();
            deleteTypeForm.Focus();
            deleteTypeForm.FillGrid();
        }
        public void ShowAddNewYearForm(Form OyunlarForm)
        {
            if (addNewYearForm == null || addNewYearForm.IsDisposed)
            {
                addNewYearForm = new AddNewYearForm();
            }
            addNewYearForm.MdiParent = OyunlarForm;
            addNewYearForm.WindowState = FormWindowState.Maximized;
            addNewYearForm.Show();
            addNewYearForm.Focus();
            addNewYearForm.FillGrid();
        }
        public void ShowDeleteYearForm(Form OyunlarForm)
        {
            if (deleteYearForm == null || deleteYearForm.IsDisposed)
            {
                deleteYearForm = new DeleteYearForm();
            }
            deleteYearForm.MdiParent = OyunlarForm;
            deleteYearForm.WindowState = FormWindowState.Maximized;
            deleteYearForm.Show();
            deleteYearForm.Focus();
            deleteYearForm.FillGrid();
        }
    }

}
