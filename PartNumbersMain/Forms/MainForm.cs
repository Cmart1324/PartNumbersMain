using System;
using System.Windows.Forms;
using PartLogic;

namespace PartNumbersMain.Forms
{
    public partial class MainForm : Form
    {
        #region class level variables
        private ILogic logic;
        private ILogic Logic => logic ?? (logic = new Logic());

        #endregion


        public MainForm()
        {
            InitializeComponent();          
        }

        private void btnShowParts_Click(object sender, EventArgs e)
        {
            ShowAllPartsForm showAllParts = new ShowAllPartsForm(Logic);
            showAllParts.Show();
            Hide();
        }

        private void BtnAddParts_Click(object sender, EventArgs e)
        {
            AddPartsForm addparts = new AddPartsForm(Logic);
            addparts.Show();
            Hide();
        }
    }
}
