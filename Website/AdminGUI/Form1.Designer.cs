﻿namespace AdminGUI
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
            this.label10 = new System.Windows.Forms.Label();
            this.cbxEditChooseProperty = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxEditDescription = new System.Windows.Forms.TextBox();
            this.tbxEditTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnEditCancel = new System.Windows.Forms.Button();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxAddChooseProperty = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxAddDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxAddTitle = new System.Windows.Forms.TextBox();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLbxUnselect = new System.Windows.Forms.Button();
            this.btnLbxAdd = new System.Windows.Forms.Button();
            this.btnLbxRemove = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
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
            this.lbxProperties.SelectedIndexChanged += new System.EventHandler(this.lbxProperties_SelectedIndexChanged);
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
            this.pnlEdit.Controls.Add(this.label10);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F);
            this.label10.Location = new System.Drawing.Point(19, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Type:";
            // 
            // cbxEditChooseProperty
            // 
            this.cbxEditChooseProperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEditChooseProperty.Font = new System.Drawing.Font("Arial", 10F);
            this.cbxEditChooseProperty.FormattingEnabled = true;
            this.cbxEditChooseProperty.Location = new System.Drawing.Point(119, 66);
            this.cbxEditChooseProperty.Name = "cbxEditChooseProperty";
            this.cbxEditChooseProperty.Size = new System.Drawing.Size(142, 24);
            this.cbxEditChooseProperty.TabIndex = 16;
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
            // tbxEditDescription
            // 
            this.tbxEditDescription.Font = new System.Drawing.Font("Arial", 10F);
            this.tbxEditDescription.Location = new System.Drawing.Point(119, 148);
            this.tbxEditDescription.Name = "tbxEditDescription";
            this.tbxEditDescription.Size = new System.Drawing.Size(144, 23);
            this.tbxEditDescription.TabIndex = 6;
            // 
            // tbxEditTitle
            // 
            this.tbxEditTitle.Font = new System.Drawing.Font("Arial", 10F);
            this.tbxEditTitle.Location = new System.Drawing.Point(119, 109);
            this.tbxEditTitle.Name = "tbxEditTitle";
            this.tbxEditTitle.Size = new System.Drawing.Size(144, 23);
            this.tbxEditTitle.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F);
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Property:";
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
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
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
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.label9);
            this.pnlAdd.Controls.Add(this.cbxAddChooseProperty);
            this.pnlAdd.Controls.Add(this.label7);
            this.pnlAdd.Controls.Add(this.label6);
            this.pnlAdd.Controls.Add(this.tbxAddDescription);
            this.pnlAdd.Controls.Add(this.label3);
            this.pnlAdd.Controls.Add(this.tbxAddTitle);
            this.pnlAdd.Controls.Add(this.btnAddCancel);
            this.pnlAdd.Controls.Add(this.btnAdd);
            this.pnlAdd.Location = new System.Drawing.Point(404, 57);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(281, 238);
            this.pnlAdd.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F);
            this.label9.Location = new System.Drawing.Point(16, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Type:";
            // 
            // cbxAddChooseProperty
            // 
            this.cbxAddChooseProperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAddChooseProperty.Font = new System.Drawing.Font("Arial", 10F);
            this.cbxAddChooseProperty.FormattingEnabled = true;
            this.cbxAddChooseProperty.Location = new System.Drawing.Point(124, 65);
            this.cbxAddChooseProperty.Name = "cbxAddChooseProperty";
            this.cbxAddChooseProperty.Size = new System.Drawing.Size(142, 24);
            this.cbxAddChooseProperty.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F);
            this.label7.Location = new System.Drawing.Point(17, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Title:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.Location = new System.Drawing.Point(16, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Description:";
            // 
            // tbxAddDescription
            // 
            this.tbxAddDescription.Font = new System.Drawing.Font("Arial", 10F);
            this.tbxAddDescription.Location = new System.Drawing.Point(124, 146);
            this.tbxAddDescription.Name = "tbxAddDescription";
            this.tbxAddDescription.Size = new System.Drawing.Size(142, 23);
            this.tbxAddDescription.TabIndex = 8;
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
            // tbxAddTitle
            // 
            this.tbxAddTitle.Font = new System.Drawing.Font("Arial", 10F);
            this.tbxAddTitle.Location = new System.Drawing.Point(124, 106);
            this.tbxAddTitle.Name = "tbxAddTitle";
            this.tbxAddTitle.Size = new System.Drawing.Size(142, 23);
            this.tbxAddTitle.TabIndex = 7;
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
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLbxUnselect
            // 
            this.btnLbxUnselect.Font = new System.Drawing.Font("Arial", 12F);
            this.btnLbxUnselect.Location = new System.Drawing.Point(320, 463);
            this.btnLbxUnselect.Name = "btnLbxUnselect";
            this.btnLbxUnselect.Size = new System.Drawing.Size(77, 36);
            this.btnLbxUnselect.TabIndex = 13;
            this.btnLbxUnselect.Text = "Unselect";
            this.btnLbxUnselect.UseVisualStyleBackColor = true;
            this.btnLbxUnselect.Click += new System.EventHandler(this.btnLbxUnselect_Click);
            // 
            // btnLbxAdd
            // 
            this.btnLbxAdd.Font = new System.Drawing.Font("Arial", 12F);
            this.btnLbxAdd.Location = new System.Drawing.Point(153, 463);
            this.btnLbxAdd.Name = "btnLbxAdd";
            this.btnLbxAdd.Size = new System.Drawing.Size(77, 36);
            this.btnLbxAdd.TabIndex = 12;
            this.btnLbxAdd.Text = "Add";
            this.btnLbxAdd.UseVisualStyleBackColor = true;
            this.btnLbxAdd.Click += new System.EventHandler(this.btnLbxAdd_Click);
            // 
            // btnLbxRemove
            // 
            this.btnLbxRemove.Font = new System.Drawing.Font("Arial", 12F);
            this.btnLbxRemove.Location = new System.Drawing.Point(236, 463);
            this.btnLbxRemove.Name = "btnLbxRemove";
            this.btnLbxRemove.Size = new System.Drawing.Size(77, 36);
            this.btnLbxRemove.TabIndex = 14;
            this.btnLbxRemove.Text = "Remove";
            this.btnLbxRemove.UseVisualStyleBackColor = true;
            this.btnLbxRemove.Click += new System.EventHandler(this.btnLbxRemove_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F);
            this.label8.Location = new System.Drawing.Point(14, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Property list:";
            // 
            // AdminGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 511);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLbxRemove);
            this.Controls.Add(this.btnLbxUnselect);
            this.Controls.Add(this.btnLbxAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxProperties);
            this.Name = "AdminGUI";
            this.Text = "AdminGUI";
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxEditDescription;
        private System.Windows.Forms.TextBox tbxEditTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxAddDescription;
        private System.Windows.Forms.TextBox tbxAddTitle;
        private System.Windows.Forms.Button btnLbxUnselect;
        private System.Windows.Forms.Button btnLbxAdd;
        private System.Windows.Forms.Button btnLbxRemove;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxEditChooseProperty;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxAddChooseProperty;
    }
}

