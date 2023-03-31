namespace LoginForm
{
    partial class frmManageUser
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
            this.userID = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.userPassword = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.dataGridViewMUser = new System.Windows.Forms.DataGridView();
            this.radIsActive = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMUser)).BeginInit();
            this.SuspendLayout();
            // 
            // userID
            // 
            this.userID.AutoSize = true;
            this.userID.Location = new System.Drawing.Point(12, 101);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(49, 16);
            this.userID.TabIndex = 0;
            this.userID.Text = "UserID";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(12, 183);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(73, 16);
            this.userName.TabIndex = 1;
            this.userName.Text = "UserName";
            // 
            // userPassword
            // 
            this.userPassword.AutoSize = true;
            this.userPassword.Location = new System.Drawing.Point(12, 271);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(67, 16);
            this.userPassword.TabIndex = 2;
            this.userPassword.Text = "Password";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(116, 98);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(228, 22);
            this.txtID.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 180);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(116, 265);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(228, 22);
            this.txtPass.TabIndex = 5;
            // 
            // dataGridViewMUser
            // 
            this.dataGridViewMUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMUser.Location = new System.Drawing.Point(376, 42);
            this.dataGridViewMUser.Name = "dataGridViewMUser";
            this.dataGridViewMUser.RowHeadersWidth = 51;
            this.dataGridViewMUser.RowTemplate.Height = 24;
            this.dataGridViewMUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMUser.Size = new System.Drawing.Size(740, 338);
            this.dataGridViewMUser.TabIndex = 6;
            this.dataGridViewMUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMUser_CellContentClick);
            // 
            // radIsActive
            // 
            this.radIsActive.AutoSize = true;
            this.radIsActive.Location = new System.Drawing.Point(188, 329);
            this.radIsActive.Name = "radIsActive";
            this.radIsActive.Size = new System.Drawing.Size(75, 20);
            this.radIsActive.TabIndex = 7;
            this.radIsActive.TabStop = true;
            this.radIsActive.Text = "isActive";
            this.radIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(55, 457);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(385, 457);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(712, 457);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1036, 457);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 520);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.radIsActive);
            this.Controls.Add(this.dataGridViewMUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.userID);
            this.Name = "frmManageUser";
            this.Text = "frmManageUser";
            this.Load += new System.EventHandler(this.frmManageUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userID;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label userPassword;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.DataGridView dataGridViewMUser;
        private System.Windows.Forms.RadioButton radIsActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}