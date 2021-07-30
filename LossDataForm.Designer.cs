
namespace CrawfordInsuranceClaims
{
    partial class LossDataForm
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
            this.LossTypesGrid = new System.Windows.Forms.DataGridView();
            this.UsersDisplayName = new System.Windows.Forms.Label();
            this.LossTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LossTypeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LossTypeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.LossTypesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.LossTypesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LossTypesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LossTypeID,
            this.LossTypeCode,
            this.LossTypeDescription});
            this.LossTypesGrid.Location = new System.Drawing.Point(12, 77);
            this.LossTypesGrid.Name = "dataGridView1";
            this.LossTypesGrid.RowTemplate.Height = 25;
            this.LossTypesGrid.Size = new System.Drawing.Size(744, 316);
            this.LossTypesGrid.TabIndex = 0;
            // 
            // UsersDisplayName
            // 
            this.UsersDisplayName.AutoSize = true;
            this.UsersDisplayName.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsersDisplayName.Location = new System.Drawing.Point(12, 21);
            this.UsersDisplayName.Name = "UsersDisplayName";
            this.UsersDisplayName.Size = new System.Drawing.Size(162, 32);
            this.UsersDisplayName.TabIndex = 1;
            this.UsersDisplayName.Text = "Hello there";
            // 
            // LossTypeID
            // 
            this.LossTypeID.HeaderText = "Loss ID";
            this.LossTypeID.Name = "LossTypeID";
            this.LossTypeID.ReadOnly = true;
            // 
            // LossTypeCode
            // 
            this.LossTypeCode.HeaderText = "Loss Code";
            this.LossTypeCode.Name = "LossTypeCode";
            this.LossTypeCode.ReadOnly = true;
            // 
            // LossTypeDescription
            // 
            this.LossTypeDescription.HeaderText = "Loss Description";
            this.LossTypeDescription.Name = "LossTypeDescription";
            this.LossTypeDescription.ReadOnly = true;
            this.LossTypeDescription.Width = 500;
            // 
            // LossDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 405);
            this.Controls.Add(this.UsersDisplayName);
            this.Controls.Add(this.LossTypesGrid);
            this.Name = "LossDataForm";
            this.Text = "Loss Data - View";
            ((System.ComponentModel.ISupportInitialize)(this.LossTypesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LossTypesGrid;
        private System.Windows.Forms.Label UsersDisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LossTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LossTypeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn LossTypeDescription;
    }
}