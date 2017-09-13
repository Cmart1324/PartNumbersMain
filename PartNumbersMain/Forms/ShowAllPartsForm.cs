using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PartLogic;
using PartLogic.List_Classes;

namespace PartNumbersMain.Forms
{
    public partial class ShowAllPartsForm : Form
    { 
        #region class level variables

        private List<Parts> _tempParts;

        public ILogic Logic { get; set; }
        public List<Parts> TempParts { get => _tempParts; set => _tempParts = value; }

        #endregion


        public ShowAllPartsForm(ILogic logic)
        {
            Logic = logic;  
            InitializeComponent();

           SetListBox ();
        
        }

        private void BtnDeleteProducts_Click(object sender, EventArgs e)
        {
            string selectedItem = "";
            int index = lsShowAll.SelectedIndex;
            int count = 0;
            foreach (var item in _tempParts)
            {

                if (count == index)   
                    selectedItem = item.PartNumber;
                
                count++;
            }

            Logic.DeletePart(selectedItem);
            _tempParts = Logic.NonOrginalList;
            SetListBox();
        }
        // sets the list 
        private void SetListBox ()
        {
            lsShowAll.Items.Clear();
            string outPut = "";
            // gets the list from logic
            _tempParts = Logic.NonOrginalList;
            foreach (var index in _tempParts)
            {
                outPut = index.PartNumber + "     " + index.PartPrice + "     " + index.PartDesciption + "\n";
                lsShowAll.Items.Add(outPut);
            }

            outPut = "\n            Number of list in:" + _tempParts.Count.ToString();
            lsShowAll.Items.Add(outPut);
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            AddPartsForm addPart = new AddPartsForm(Logic);
            addPart.Show();
            Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to save this to the database?", "Save?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(!Logic.ChangeDataBase()
                    ? "Your changes was not successful! Please contact Helpdesk!"
                    : "Your changes was successful! Have a great day!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Have a great day!");
            }
        }
    }

}
