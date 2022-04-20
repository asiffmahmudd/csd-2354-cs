using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmNewItem : Form
    {
        public frmNewItem()
        {
            InitializeComponent();
        }

        private InvItem invItem = null;


        public InvItem GetNewItem()
        {
            LoadComboBox();
            this.ShowDialog();
            return invItem;
        }

        // method for loading data in the combo box
        private void LoadComboBox()
        {
            cboSizeOrManufacturer.Items.Clear();
            if (rdoPlant.Checked)
            {
                cboSizeOrManufacturer.Items.Add("1 gallon");
                cboSizeOrManufacturer.Items.Add("5 gallon");
                cboSizeOrManufacturer.Items.Add("15 gallon");
                cboSizeOrManufacturer.Items.Add("24-inch box");
                cboSizeOrManufacturer.Items.Add("36-inch box");
            }
            else
            {
                cboSizeOrManufacturer.Items.Add("Bayer");
                cboSizeOrManufacturer.Items.Add("Jobe's");
                cboSizeOrManufacturer.Items.Add("Ortho");
                cboSizeOrManufacturer.Items.Add("Roundup");
                cboSizeOrManufacturer.Items.Add("Scotts");
            }
            cboSizeOrManufacturer.SelectedIndex = 0;
        }

        //method for checking validation and creating appropriate object for the invItem variable
        private void ProcessData()
        {
            if(
                Validator.IsPresent(txtItemNo) &&
                Validator.IsInt32(txtItemNo, out int itemNo) &&
                Validator.IsPresent(txtDescription) &&
                Validator.IsPresent(txtPrice) &&
                Validator.IsDecimal(txtPrice, out decimal price)
            )
            {
                if (rdoPlant.Checked)
                {
                    invItem = new Plant(itemNo, txtDescription.Text, price, cboSizeOrManufacturer.Text);
                }
                else
                {
                    invItem = new Supply(itemNo, txtDescription.Text, price, cboSizeOrManufacturer.Text);
                }
                this.Close();
            }
        }

        //event handler for save button
        private void btnSave_Click(object sender, EventArgs e)
        {
            ProcessData();
        }

        //event handler for cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // event handler for changing the checkboxes. it changes the label before the checkboxes
        private void rdoPlant_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPlant.Checked)
            {
                lblSizeOrManufacturer.Text = "Size:";
            }
            else
            {
                lblSizeOrManufacturer.Text = "Manufacturer:";
            }
            LoadComboBox();
        }
    }
}
