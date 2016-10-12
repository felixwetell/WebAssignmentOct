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

            //ComboBoxItems
            cbxEditChooseProperty.Items.Add(new ComboBoxItem() { Text = "<Select option>", Value = 0 });
            cbxEditChooseProperty.Items.Add(new ComboBoxItem() { Text = "Jobs", Value = 1 });
            cbxEditChooseProperty.Items.Add(new ComboBoxItem() { Text = "Education", Value = 2 });
            cbxEditChooseProperty.Items.Add(new ComboBoxItem() { Text = "Skills", Value = 3 });
            cbxEditChooseProperty.Items.Add(new ComboBoxItem() { Text = "Experiences", Value = 4 });

            cbxAddChooseProperty.Items.Add(new ComboBoxItem() { Text = "<Select option>", Value = 0 });
            cbxAddChooseProperty.Items.Add(new ComboBoxItem() { Text = "Jobs", Value = 1 });
            cbxAddChooseProperty.Items.Add(new ComboBoxItem() { Text = "Education", Value = 2 });
            cbxAddChooseProperty.Items.Add(new ComboBoxItem() { Text = "Skills", Value = 3 });
            cbxAddChooseProperty.Items.Add(new ComboBoxItem() { Text = "Experiences", Value = 4 });

            //Shows "default" text
            cbxAddChooseProperty.SelectedIndex = 0;
            cbxEditChooseProperty.SelectedIndex = 0;

            //Hides panles
            GUI(false, false);
            EditEnable(false);
            ListEnable(false);

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

        void ReadOnly(bool toogle)
        {
            tbxEditTitle.ReadOnly = toogle;
            tbxEditDescription.ReadOnly = toogle;
        }

        void EditEnable(bool toogle)
        {
            btnEdit.Enabled = !toogle;
            btnEditCancel.Enabled = toogle;
            btnEditSave.Enabled = toogle;
            cbxEditChooseProperty.Enabled = toogle;
        }

        void ListEnable(bool toogle)
        {
            btnLbxRemove.Enabled = toogle;
            btnLbxUnselect.Enabled = toogle;
        }

        void ClearTextBoxes()
        {
            tbxAddTitle.Clear();
            tbxAddDescription.Clear();
            tbxEditTitle.Clear();
            tbxEditDescription.Clear();
        }

        private void lbxProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            Property prop = (Property)lbxProperties.SelectedItem;

            if (lbxProperties.SelectedIndex == -1)
            {
                return;
            }

            GUI(false, true);
            ReadOnly(true);
            EditEnable(false);
            ListEnable(true);
            tbxEditTitle.Text = prop.title;
            tbxEditDescription.Text = prop.description;
        }

        private void btnLbxAdd_Click(object sender, EventArgs e)
        {
            lbxProperties.ClearSelected();
            GUI(true, false);
        }

        private void btnLbxRemove_Click(object sender, EventArgs e)
        {
            Property prop = (Property)lbxProperties.SelectedItem;

            DataBase.Properties.Remove(prop);
            DataBase.SaveChanges();
            CheckProperties();
            GUI(false, false);
            ListEnable(false);
        }

        private void btnLbxUnselect_Click(object sender, EventArgs e)
        {
            lbxProperties.ClearSelected();
            GUI(false, false);
            ListEnable(false);
        }

        //Start of "Edit" panel
        private void btnEditSave_Click(object sender, EventArgs e)
        {
            Property prop = (Property)lbxProperties.SelectedItem;

            prop.title = tbxEditTitle.Text;
            prop.type = cbxEditChooseProperty.Text;
            prop.description = tbxEditDescription.Text;

            DataBase.SaveChanges();
            ClearTextBoxes();
            ReadOnly(true);
            GUI(false, false);
            CheckProperties();
            EditEnable(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ReadOnly(false);
            EditEnable(true);
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            EditEnable(false);
        }
        //End of "Edit" panel

        //Start of "Add" panel
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxAddChooseProperty.SelectedIndex == 0 || tbxAddTitle.Text == string.Empty || tbxAddDescription.Text == string.Empty)
            {
                MessageBox.Show("At least on of the fields are empty. Please fill them in.", "Alert");
            }

            Property newProp = new Property() { title = tbxAddTitle.Text, type = cbxAddChooseProperty.Text, description = tbxAddDescription.Text };
            DataBase.Properties.Add(newProp);
            DataBase.SaveChanges();
            ClearTextBoxes();
            CheckProperties();
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            GUI(false, false);
        }
        //End of "Add" panel
    }
}
