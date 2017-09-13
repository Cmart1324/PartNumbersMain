using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PartLogic;
using PartLogic.List_Classes;
using PartNumbersMain.Forms;

//cody martin
namespace PartNumbersMain
{
    public partial class AddPartsForm : Form
    {
        #region class level variables
        ILogic Logic;
        private List<Parts> tempParts;

        public List<Parts> TempParts { get => tempParts; set => tempParts = value; }

        #endregion

        public AddPartsForm(ILogic logic)
        {
            Logic = logic;
            InitializeComponent();
          
        }
        public AddPartsForm()
        {
            InitializeComponent();
      
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string failValidate = "Please Make sure ";
            string addPartNumber = "";
            string addPartPrice = "";
            string addDecscrition = "";
            addPartNumber = textBoxPartNumber.Text;
            addPartPrice = textBoxPartPrice.Text;
            addDecscrition = textBoxPartDesc.Text;
          
            //sees if all things are valid, passes each item to the logic interfance which goes to logic and checks the if it is right
            if (Logic.IsValid(addDecscrition) && Logic.IsNumber(addPartPrice) && Logic.IsNineLetter(addPartNumber) && Logic.IsPartNumberAlreadyInTheList(addPartNumber))
            {
                Logic.AddtoGetPart(addPartNumber, double.Parse(addPartPrice), addDecscrition);
                TempParts = Logic.NonOrginalList;
                textBoxPartNumber.Text = "";
                textBoxPartPrice.Text = "";
                textBoxPartDesc.Text = "";

                DialogResult dialogResult = MessageBox.Show("Item was added, Do you want to add another", "Successful", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    ShowAllPartsForm showAllProducts = new ShowAllPartsForm(Logic);
                    showAllProducts.Show();
                    Hide();
                }
            }
            else
            {
                if (!Logic.IsValid(addDecscrition))
                {
                    textBoxPartDesc.BackColor = System.Drawing.Color.Red;
                    failValidate += "there is something in description." + "\n";
                }
                else
                {
                    textBoxPartDesc.BackColor = System.Drawing.Color.White;
                }
                if (!Logic.IsNumber(addPartPrice))
                {
                    textBoxPartPrice.BackColor = System.Drawing.Color.Red;
                    failValidate += "you have entered a number." + "\n";

                }
                else
                {
                    textBoxPartPrice.BackColor = System.Drawing.Color.White;
                }
                if (!Logic.IsNineLetter(addPartNumber))
                {
                    textBoxPartNumber.BackColor = System.Drawing.Color.Red;
                    failValidate += "Part Numbers are 9 digits long." + "\n";
                }
                else
                {
                    textBoxPartNumber.BackColor = System.Drawing.Color.White;
                }
                if (!Logic.IsPartNumberAlreadyInTheList(addPartNumber))
                {
                    textBoxPartNumber.BackColor = System.Drawing.Color.Red;
                    failValidate += "Part Numbers are not matching other items." + "\n";
                }
                else
                {
                    textBoxPartNumber.BackColor = System.Drawing.Color.White;
                }
                MessageBox.Show(failValidate);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxPartNumber.Text = "";
            textBoxPartPrice.Text = "";
            textBoxPartDesc.Text = "";
        }

    }
}
