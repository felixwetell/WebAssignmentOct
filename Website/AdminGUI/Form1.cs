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
            GUI(false, false);
            CheckProperties();
        }

        private void AdminGUI_Load(object sender, EventArgs e)
        {

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
            
        }

        private void btnLbxAdd_Click(object sender, EventArgs e)
        {
            GUI(true, false);
        }

        private void btnLbxClear_Click(object sender, EventArgs e)
        {
            lbxProperties.SelectedIndex = -1;
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

    }
}
