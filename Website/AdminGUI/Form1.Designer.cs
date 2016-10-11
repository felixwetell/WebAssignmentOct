namespace AdminGUI
{
    partial class AdminGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxProperties = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxEditTitle = new System.Windows.Forms.TextBox();
            this.tbxEditDescription = new System.Windows.Forms.TextBox();
            this.tbxAddDescription = new System.Windows.Forms.TextBox();
            this.tbxAddTitle = new System.Windows.Forms.TextBox();
            this.cbxAddChooseProperty = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxEditChooseProperty = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlEdit.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxProperties
            // 
            this.lbxProperties.Font = new System.Drawing.Font("Arial", 14F);
            this.lbxProperties.FormattingEnabled = true;
            this.lbxProperties.ItemHeight = 22;
            this.lbxProperties.Location = new System.Drawing.Point(17, 57);
            this.lbxProperties.Name = "lbxProperties";
            this.lbxProperties.Size = new System.Drawing.Size(380, 400);
            this.lbxProperties.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin Control Panel";
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.cbxEditChooseProperty);
            this.pnlEdit.Controls.Add(this.label5);
            this.pnlEdit.Controls.Add(this.label4);
            this.pnlEdit.Controls.Add(this.tbxEditDescription);
            this.pnlEdit.Controls.Add(this.tbxEditTitle);
            this.pnlEdit.Controls.Add(this.label2);
            this.pnlEdit.Controls.Add(this.btnEdit);
            this.pnlEdit.Controls.Add(this.btnEditCancel);
            this.pnlEdit.Controls.Add(this.btnEditSave);
            this.pnlEdit.Location = new System.Drawing.Point(404, 57);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(281, 238);
            this.pnlEdit.TabIndex = 2;
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.label7);
            this.pnlAdd.Controls.Add(this.label6);
            this.pnlAdd.Controls.Add(this.cbxAddChooseProperty);
            this.pnlAdd.Controls.Add(this.tbxAddDescription);
            this.pnlAdd.Controls.Add(this.label3);
            this.pnlAdd.Controls.Add(this.tbxAddTitle);
            this.pnlAdd.Controls.Add(this.btnAddCancel);
            this.pnlAdd.Controls.Add(this.btnAdd);
            this.pnlAdd.Location = new System.Drawing.Point(715, 57);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(281, 238);
            this.pnlAdd.TabIndex = 3;
            // 
            // btnEditSave
            // 
            this.btnEditSave.Font = new System.Drawing.Font("Arial", 12F);
            this.btnEditSave.Location = new System.Drawing.Point(20, 188);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(77, 36);
            this.btnEditSave.TabIndex = 0;
            this.btnEditSave.Text = "Save";
            this.btnEditSave.UseVisualStyleBackColor = true;
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.Font = new System.Drawing.Font("Arial", 12F);
            this.btnEditCancel.Location = new System.Drawing.Point(186, 188);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(77, 36);
            this.btnEditCancel.TabIndex = 1;
            this.btnEditCancel.Text = "Cancel";
            this.btnEditCancel.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Arial", 12F);
            this.btnEdit.Location = new System.Drawing.Point(103, 188);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(77, 36);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAddCancel.Location = new System.Drawing.Point(189, 188);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(77, 36);
            this.btnAddCancel.TabIndex = 5;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAdd.Location = new System.Drawing.Point(106, 188);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 36);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F);
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Edit info:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F);
            this.label3.Location = new System.Drawing.Point(17, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add property:";
            // 
            // tbxEditTitle
            // 
            this.tbxEditTitle.Font = new System.Drawing.Font("Arial", 10F);
            this.tbxEditTitle.Location = new System.Drawing.Point(119, 109);
            this.tbxEditTitle.Name = "tbxEditTitle";
            this.tbxEditTitle.Size = new System.Drawing.Size(144, 23);
            this.tbxEditTitle.TabIndex = 5;
            // 
            // tbxEditDescription
            // 
            this.tbxEditDescription.Font = new System.Drawing.Font("Arial", 10F);
            this.tbxEditDescription.Location = new System.Drawing.Point(119, 148);
            this.tbxEditDescription.Name = "tbxEditDescription";
            this.tbxEditDescription.Size = new System.Drawing.Size(144, 23);
            this.tbxEditDescription.TabIndex = 6;
            // 
            // tbxAddDescription
            // 
            this.tbxAddDescription.Font = new System.Drawing.Font("Arial", 10F);
            this.tbxAddDescription.Location = new System.Drawing.Point(122, 148);
            this.tbxAddDescription.Name = "tbxAddDescription";
            this.tbxAddDescription.Size = new System.Drawing.Size(144, 23);
            this.tbxAddDescription.TabIndex = 8;
            // 
            // tbxAddTitle
            // 
            this.tbxAddTitle.Font = new System.Drawing.Font("Arial", 10F);
            this.tbxAddTitle.Location = new System.Drawing.Point(122, 109);
            this.tbxAddTitle.Name = "tbxAddTitle";
            this.tbxAddTitle.Size = new System.Drawing.Size(144, 23);
            this.tbxAddTitle.TabIndex = 7;
            // 
            // cbxAddChooseProperty
            // 
            this.cbxAddChooseProperty.FormattingEnabled = true;
            this.cbxAddChooseProperty.Location = new System.Drawing.Point(44, 67);
            this.cbxAddChooseProperty.Name = "cbxAddChooseProperty";
            this.cbxAddChooseProperty.Size = new System.Drawing.Size(144, 21);
            this.cbxAddChooseProperty.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(17, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Title:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.Location = new System.Drawing.Point(17, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description:";
            // 
            // cbxEditChooseProperty
            // 
            this.cbxEditChooseProperty.FormattingEnabled = true;
            this.cbxEditChooseProperty.Location = new System.Drawing.Point(54, 67);
            this.cbxEditChooseProperty.Name = "cbxEditChooseProperty";
            this.cbxEditChooseProperty.Size = new System.Drawing.Size(144, 21);
            this.cbxEditChooseProperty.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.Location = new System.Drawing.Point(13, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F);
            this.label7.Location = new System.Drawing.Point(13, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Title:";
            // 
            // AdminGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 796);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxProperties);
            this.Name = "AdminGUI";
            this.Text = "AdminGUI";
            this.Load += new System.EventHandler(this.AdminGUI_Load);
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxProperties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnEditCancel;
        private System.Windows.Forms.Button btnEditSave;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxEditChooseProperty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxEditDescription;
        private System.Windows.Forms.TextBox tbxEditTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxAddChooseProperty;
        private System.Windows.Forms.TextBox tbxAddDescription;
        private System.Windows.Forms.TextBox tbxAddTitle;
    }
}

