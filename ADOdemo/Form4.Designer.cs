namespace ADOdemo
{
    partial class Form4
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
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.Cmdcategory = new System.Windows.Forms.ComboBox();
            this.Sgender = new System.Windows.Forms.TextBox();
            this.PName = new System.Windows.Forms.TextBox();
            this.PId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Sage = new System.Windows.Forms.TextBox();
            this.BtnShow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(495, 334);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(88, 40);
            this.BtnDelete.TabIndex = 25;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(368, 334);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(88, 40);
            this.BtnSearch.TabIndex = 24;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(225, 334);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(88, 40);
            this.BtnUpdate.TabIndex = 23;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(96, 334);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(88, 40);
            this.BtnSave.TabIndex = 22;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // Cmdcategory
            // 
            this.Cmdcategory.FormattingEnabled = true;
            this.Cmdcategory.Location = new System.Drawing.Point(211, 261);
            this.Cmdcategory.Name = "Cmdcategory";
            this.Cmdcategory.Size = new System.Drawing.Size(121, 21);
            this.Cmdcategory.TabIndex = 21;
            // 
            // Sgender
            // 
            this.Sgender.Location = new System.Drawing.Point(211, 142);
            this.Sgender.Multiline = true;
            this.Sgender.Name = "Sgender";
            this.Sgender.Size = new System.Drawing.Size(121, 33);
            this.Sgender.TabIndex = 20;
            // 
            // PName
            // 
            this.PName.Location = new System.Drawing.Point(211, 82);
            this.PName.Multiline = true;
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(121, 33);
            this.PName.TabIndex = 19;
            // 
            // PId
            // 
            this.PId.Location = new System.Drawing.Point(211, 27);
            this.PId.Multiline = true;
            this.PId.Name = "PId";
            this.PId.Size = new System.Drawing.Size(121, 33);
            this.PId.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Branch :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Gender :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Roll No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Age :";
            // 
            // Sage
            // 
            this.Sage.Location = new System.Drawing.Point(211, 202);
            this.Sage.Multiline = true;
            this.Sage.Name = "Sage";
            this.Sage.Size = new System.Drawing.Size(121, 33);
            this.Sage.TabIndex = 28;
            // 
            // BtnShow
            // 
            this.BtnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShow.Location = new System.Drawing.Point(638, 334);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(88, 40);
            this.BtnShow.TabIndex = 26;
            this.BtnShow.Text = "Show All";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(495, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(293, 284);
            this.dataGridView1.TabIndex = 29;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Sage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.Cmdcategory);
            this.Controls.Add(this.Sgender);
            this.Controls.Add(this.PName);
            this.Controls.Add(this.PId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Student Form";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox Cmdcategory;
        private System.Windows.Forms.TextBox Sgender;
        private System.Windows.Forms.TextBox PName;
        private System.Windows.Forms.TextBox PId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Sage;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}