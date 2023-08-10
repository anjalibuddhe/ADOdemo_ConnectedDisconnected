namespace ADOdemo
{
    partial class Form2
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
            this.Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EId = new System.Windows.Forms.TextBox();
            this.Ename = new System.Windows.Forms.TextBox();
            this.Esalary = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.CmbDept = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(43, 45);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(16, 13);
            this.Name.TabIndex = 0;
            this.Name.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department";
            // 
            // EId
            // 
            this.EId.Location = new System.Drawing.Point(121, 42);
            this.EId.Name = "EId";
            this.EId.Size = new System.Drawing.Size(100, 20);
            this.EId.TabIndex = 6;
            // 
            // Ename
            // 
            this.Ename.Location = new System.Drawing.Point(121, 92);
            this.Ename.Name = "Ename";
            this.Ename.Size = new System.Drawing.Size(100, 20);
            this.Ename.TabIndex = 7;
            // 
            // Esalary
            // 
            this.Esalary.Location = new System.Drawing.Point(121, 147);
            this.Esalary.Name = "Esalary";
            this.Esalary.Size = new System.Drawing.Size(100, 20);
            this.Esalary.TabIndex = 9;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(46, 270);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(156, 270);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 11;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(280, 270);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 12;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(395, 270);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 13;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // CmbDept
            // 
            this.CmbDept.FormattingEnabled = true;
            this.CmbDept.Location = new System.Drawing.Point(121, 197);
            this.CmbDept.Name = "CmbDept";
            this.CmbDept.Size = new System.Drawing.Size(100, 21);
            this.CmbDept.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmbDept);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.Esalary);
            this.Controls.Add(this.Ename);
            this.Controls.Add(this.EId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Name);
            this.Name.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EId;
        private System.Windows.Forms.TextBox Ename;
        private System.Windows.Forms.TextBox Esalary;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.ComboBox CmbDept;
    }
}