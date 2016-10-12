using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminGUI
{
    public partial class AdminGUI : Form
    {
        WebsiteDB DataBase = new WebsiteDB();
        
        public AdminGUI()
        {
            InitializeComponent();

            cbxEditChooseProperty.Items.Add(new ComboBoxItem() { Text = "Choose a type:", Value = 0 });
            cbxEditChooseProperty.Items.Add(new ComboBoxItem() { Text = "Jobs", Value = 1 });
            cbxEditChooseProperty.Items.Add(new ComboBoxItem() { Text = "Education", Value = 2 });
            cbxEditChooseProperty.Items.Add(new ComboBoxItem() { Text = "Skills", Value = 3 });
            cbxEditChooseProperty.Items.Add(new ComboBoxItem() { Text = "Experiences", Value = 4 });

            cbxAddChooseProperty.Items.Add(new ComboBoxItem() { Text = "Choose a type:", Value = 0 });
            cbxAddChooseProperty.Items.Add(new ComboBoxItem() { Text = "Jobs", Value = 1 });
            cbxAddChooseProperty.Items.Add(new ComboBoxItem() { Text = "Education", Value = 2 });
            cbxAddChooseProperty.Items.Add(new ComboBoxItem() { Text = "Skills", Value = 3 });
            cbxAddChooseProperty.Items.Add(new ComboBoxItem() { Text = "Experiences", Value = 4 });

            //Hides panles
            GUI(false, false);
            //Displays all properties
            CheckProperties();
        }

        void GUI(bool add, bool edit)
        {
            pnlAdd.Visible = add;
            pnlEdit.Visible = edit;
        }

        void CheckProperties()
        {
            lbxProperties.Items.Clear();
            foreach (var item in DataBase.Properties)
            {
                lbxProperties.Items.Add(item);
            }
            lbxProperties.DisplayMember = "Title";
        }

        private void lbxProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            GUI(false, true);
        }

        private void btnLbxAdd_Click(object sender, EventArgs e)
        {
            GUI(true, false);
            CheckProperties();
        }

        private void btnLbxClear_Click(object sender, EventArgs e)
        {
            lbxProperties.SelectedIndex = -1;
            GUI(false, false);
        }

        //Start of "Edit" panel
        private void cbxEditChooseProperty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void tbxEditTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxEditDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {

        }
        //End of "Edit" panel

        //Start of "Add" panel
        private void cbxAddChooseProperty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxAddTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxAddDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {

        }
        //End of "Add" panel
    }
}
