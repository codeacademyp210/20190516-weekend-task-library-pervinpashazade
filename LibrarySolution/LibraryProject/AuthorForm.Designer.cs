namespace LibraryProject
{
    partial class AuthorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorForm));
            this.txtBoxNameAuthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxSurnameAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveAuthorsForm = new System.Windows.Forms.Button();
            this.btnDeleteAuthorsForm = new System.Windows.Forms.Button();
            this.btnResetAuthorsForm = new System.Windows.Forms.Button();
            this.dgvAuthorsForm = new System.Windows.Forms.DataGridView();
            this.AuthorsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthorsForm)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxNameAuthor
            // 
            this.txtBoxNameAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxNameAuthor.Location = new System.Drawing.Point(32, 52);
            this.txtBoxNameAuthor.Name = "txtBoxNameAuthor";
            this.txtBoxNameAuthor.Size = new System.Drawing.Size(282, 23);
            this.txtBoxNameAuthor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // txtBoxSurnameAuthor
            // 
            this.txtBoxSurnameAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxSurnameAuthor.Location = new System.Drawing.Point(32, 123);
            this.txtBoxSurnameAuthor.Name = "txtBoxSurnameAuthor";
            this.txtBoxSurnameAuthor.Size = new System.Drawing.Size(282, 23);
            this.txtBoxSurnameAuthor.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Surname";
            // 
            // btnSaveAuthorsForm
            // 
            this.btnSaveAuthorsForm.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSaveAuthorsForm.Location = new System.Drawing.Point(32, 189);
            this.btnSaveAuthorsForm.Name = "btnSaveAuthorsForm";
            this.btnSaveAuthorsForm.Size = new System.Drawing.Size(282, 35);
            this.btnSaveAuthorsForm.TabIndex = 8;
            this.btnSaveAuthorsForm.Text = "Save";
            this.btnSaveAuthorsForm.UseVisualStyleBackColor = true;
            this.btnSaveAuthorsForm.Click += new System.EventHandler(this.BtnSaveAuthorsForm_Click);
            // 
            // btnDeleteAuthorsForm
            // 
            this.btnDeleteAuthorsForm.Enabled = false;
            this.btnDeleteAuthorsForm.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnDeleteAuthorsForm.Location = new System.Drawing.Point(32, 230);
            this.btnDeleteAuthorsForm.Name = "btnDeleteAuthorsForm";
            this.btnDeleteAuthorsForm.Size = new System.Drawing.Size(138, 35);
            this.btnDeleteAuthorsForm.TabIndex = 9;
            this.btnDeleteAuthorsForm.Text = "Delete";
            this.btnDeleteAuthorsForm.UseVisualStyleBackColor = true;
            this.btnDeleteAuthorsForm.Click += new System.EventHandler(this.BtnDeleteAuthorsForm_Click);
            // 
            // btnResetAuthorsForm
            // 
            this.btnResetAuthorsForm.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnResetAuthorsForm.Location = new System.Drawing.Point(176, 230);
            this.btnResetAuthorsForm.Name = "btnResetAuthorsForm";
            this.btnResetAuthorsForm.Size = new System.Drawing.Size(138, 35);
            this.btnResetAuthorsForm.TabIndex = 10;
            this.btnResetAuthorsForm.Text = "Reset";
            this.btnResetAuthorsForm.UseVisualStyleBackColor = true;
            this.btnResetAuthorsForm.Click += new System.EventHandler(this.BtnResetAuthorsForm_Click);
            // 
            // dgvAuthorsForm
            // 
            this.dgvAuthorsForm.AllowUserToAddRows = false;
            this.dgvAuthorsForm.AllowUserToDeleteRows = false;
            this.dgvAuthorsForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuthorsForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthorsForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AuthorsID,
            this.AuthorName,
            this.AuthorSurname});
            this.dgvAuthorsForm.Location = new System.Drawing.Point(348, 52);
            this.dgvAuthorsForm.Name = "dgvAuthorsForm";
            this.dgvAuthorsForm.ReadOnly = true;
            this.dgvAuthorsForm.Size = new System.Drawing.Size(385, 213);
            this.dgvAuthorsForm.TabIndex = 11;
            this.dgvAuthorsForm.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvAuthorsForm_RowHeaderMouseDoubleClick);
            // 
            // AuthorsID
            // 
            this.AuthorsID.HeaderText = "ID";
            this.AuthorsID.Name = "AuthorsID";
            this.AuthorsID.ReadOnly = true;
            this.AuthorsID.Visible = false;
            // 
            // AuthorName
            // 
            this.AuthorName.HeaderText = "Name";
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.ReadOnly = true;
            // 
            // AuthorSurname
            // 
            this.AuthorSurname.HeaderText = "Surname";
            this.AuthorSurname.Name = "AuthorSurname";
            this.AuthorSurname.ReadOnly = true;
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 296);
            this.Controls.Add(this.dgvAuthorsForm);
            this.Controls.Add(this.btnResetAuthorsForm);
            this.Controls.Add(this.btnDeleteAuthorsForm);
            this.Controls.Add(this.btnSaveAuthorsForm);
            this.Controls.Add(this.txtBoxSurnameAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxNameAuthor);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authors";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthorsForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNameAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxSurnameAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveAuthorsForm;
        private System.Windows.Forms.Button btnDeleteAuthorsForm;
        private System.Windows.Forms.Button btnResetAuthorsForm;
        private System.Windows.Forms.DataGridView dgvAuthorsForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorSurname;
    }
}