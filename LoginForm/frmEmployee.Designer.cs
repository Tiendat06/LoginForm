namespace LoginForm
{
    partial class frmEmployee
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
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.selectDepartment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbDepartment
            // 
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(194, 43);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(232, 24);
            this.cbDepartment.TabIndex = 0;
            // 
            // selectDepartment
            // 
            this.selectDepartment.AutoSize = true;
            this.selectDepartment.Location = new System.Drawing.Point(36, 46);
            this.selectDepartment.Name = "selectDepartment";
            this.selectDepartment.Size = new System.Drawing.Size(118, 16);
            this.selectDepartment.TabIndex = 1;
            this.selectDepartment.Text = "Select Department";
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectDepartment);
            this.Controls.Add(this.cbDepartment);
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label selectDepartment;
    }
}