namespace AdminGUI
{
    partial class Form1
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
            this.pnlEditInfo = new System.Windows.Forms.Panel();
            this.pnlAddInfo = new System.Windows.Forms.Panel();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.btnCancelInfo = new System.Windows.Forms.Button();
            this.btnEditInfo = new System.Windows.Forms.Button();
            this.btnCancelAddInfo = new System.Windows.Forms.Button();
            this.btnAddInfo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlEditInfo.SuspendLayout();
            this.pnlAddInfo.SuspendLayout();
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
            // pnlEditInfo
            // 
            this.pnlEditInfo.Controls.Add(this.label2);
            this.pnlEditInfo.Controls.Add(this.btnEditInfo);
            this.pnlEditInfo.Controls.Add(this.btnCancelInfo);
            this.pnlEditInfo.Controls.Add(this.btnSaveInfo);
            this.pnlEditInfo.Location = new System.Drawing.Point(404, 57);
            this.pnlEditInfo.Name = "pnlEditInfo";
            this.pnlEditInfo.Size = new System.Drawing.Size(439, 400);
            this.pnlEditInfo.TabIndex = 2;
            // 
            // pnlAddInfo
            // 
            this.pnlAddInfo.Controls.Add(this.label3);
            this.pnlAddInfo.Controls.Add(this.btnCancelAddInfo);
            this.pnlAddInfo.Controls.Add(this.btnAddInfo);
            this.pnlAddInfo.Location = new System.Drawing.Point(849, 57);
            this.pnlAddInfo.Name = "pnlAddInfo";
            this.pnlAddInfo.Size = new System.Drawing.Size(439, 400);
            this.pnlAddInfo.TabIndex = 3;
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.Font = new System.Drawing.Font("Arial", 12F);
            this.btnSaveInfo.Location = new System.Drawing.Point(175, 345);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(77, 36);
            this.btnSaveInfo.TabIndex = 0;
            this.btnSaveInfo.Text = "Save";
            this.btnSaveInfo.UseVisualStyleBackColor = true;
            // 
            // btnCancelInfo
            // 
            this.btnCancelInfo.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCancelInfo.Location = new System.Drawing.Point(341, 345);
            this.btnCancelInfo.Name = "btnCancelInfo";
            this.btnCancelInfo.Size = new System.Drawing.Size(77, 36);
            this.btnCancelInfo.TabIndex = 1;
            this.btnCancelInfo.Text = "Cancel";
            this.btnCancelInfo.UseVisualStyleBackColor = true;
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.Font = new System.Drawing.Font("Arial", 12F);
            this.btnEditInfo.Location = new System.Drawing.Point(258, 345);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.Size = new System.Drawing.Size(77, 36);
            this.btnEditInfo.TabIndex = 2;
            this.btnEditInfo.Text = "Edit";
            this.btnEditInfo.UseVisualStyleBackColor = true;
            // 
            // btnCancelAddInfo
            // 
            this.btnCancelAddInfo.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCancelAddInfo.Location = new System.Drawing.Point(333, 345);
            this.btnCancelAddInfo.Name = "btnCancelAddInfo";
            this.btnCancelAddInfo.Size = new System.Drawing.Size(77, 36);
            this.btnCancelAddInfo.TabIndex = 5;
            this.btnCancelAddInfo.Text = "Cancel";
            this.btnCancelAddInfo.UseVisualStyleBackColor = true;
            // 
            // btnAddInfo
            // 
            this.btnAddInfo.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAddInfo.Location = new System.Drawing.Point(250, 345);
            this.btnAddInfo.Name = "btnAddInfo";
            this.btnAddInfo.Size = new System.Drawing.Size(77, 36);
            this.btnAddInfo.TabIndex = 3;
            this.btnAddInfo.Text = "Add";
            this.btnAddInfo.UseVisualStyleBackColor = true;
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
            this.label3.Location = new System.Drawing.Point(16, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add property:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 796);
            this.Controls.Add(this.pnlAddInfo);
            this.Controls.Add(this.pnlEditInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxProperties);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlEditInfo.ResumeLayout(false);
            this.pnlEditInfo.PerformLayout();
            this.pnlAddInfo.ResumeLayout(false);
            this.pnlAddInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxProperties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlEditInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditInfo;
        private System.Windows.Forms.Button btnCancelInfo;
        private System.Windows.Forms.Button btnSaveInfo;
        private System.Windows.Forms.Panel pnlAddInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelAddInfo;
        private System.Windows.Forms.Button btnAddInfo;
    }
}

