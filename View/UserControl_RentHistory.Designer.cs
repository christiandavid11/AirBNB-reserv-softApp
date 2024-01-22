namespace AirBNB.View
{
    partial class UserControl_RentHistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_RentHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RentHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_RentHistory
            // 
            this.dataGridView_RentHistory.AllowUserToAddRows = false;
            this.dataGridView_RentHistory.AllowUserToDeleteRows = false;
            this.dataGridView_RentHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.dataGridView_RentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RentHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView_RentHistory.Location = new System.Drawing.Point(3, 0);
            this.dataGridView_RentHistory.Name = "dataGridView_RentHistory";
            this.dataGridView_RentHistory.ReadOnly = true;
            this.dataGridView_RentHistory.Size = new System.Drawing.Size(667, 465);
            this.dataGridView_RentHistory.TabIndex = 0;
            // 
            // UserControl_RentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.Controls.Add(this.dataGridView_RentHistory);
            this.Name = "UserControl_RentHistory";
            this.Size = new System.Drawing.Size(670, 465);
            this.Load += new System.EventHandler(this.UserControl_RentHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RentHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_RentHistory;
    }
}
