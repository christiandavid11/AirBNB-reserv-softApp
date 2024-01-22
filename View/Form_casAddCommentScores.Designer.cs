namespace AirBNB.View
{
    partial class Form_casAddCommentScores
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
            this.panel_Border = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_casAddScore = new System.Windows.Forms.ComboBox();
            this.richTextBox_casAddComment = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Border.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Border
            // 
            this.panel_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(141)))));
            this.panel_Border.Controls.Add(this.label12);
            this.panel_Border.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Border.Location = new System.Drawing.Point(0, 0);
            this.panel_Border.Name = "panel_Border";
            this.panel_Border.Size = new System.Drawing.Size(389, 33);
            this.panel_Border.TabIndex = 5;
            this.panel_Border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Border_MouseDown);
            this.panel_Border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Border_MouseMove);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-1, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(366, 25);
            this.label12.TabIndex = 32;
            this.label12.Text = "Airbnb, OVBS - Add Comments/Scores";
            this.label12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label12_MouseDown);
            this.label12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label12_MouseMove);
            // 
            // comboBox_casAddScore
            // 
            this.comboBox_casAddScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.comboBox_casAddScore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_casAddScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_casAddScore.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_casAddScore.FormattingEnabled = true;
            this.comboBox_casAddScore.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_casAddScore.Location = new System.Drawing.Point(73, 271);
            this.comboBox_casAddScore.Name = "comboBox_casAddScore";
            this.comboBox_casAddScore.Size = new System.Drawing.Size(74, 28);
            this.comboBox_casAddScore.TabIndex = 83;
            // 
            // richTextBox_casAddComment
            // 
            this.richTextBox_casAddComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.richTextBox_casAddComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_casAddComment.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox_casAddComment.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_casAddComment.Location = new System.Drawing.Point(0, 33);
            this.richTextBox_casAddComment.Name = "richTextBox_casAddComment";
            this.richTextBox_casAddComment.Size = new System.Drawing.Size(389, 226);
            this.richTextBox_casAddComment.TabIndex = 82;
            this.richTextBox_casAddComment.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(75, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 52);
            this.button1.TabIndex = 80;
            this.button1.Text = "CANCEL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(177)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(193, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 52);
            this.button2.TabIndex = 81;
            this.button2.Text = "SUBMIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 84;
            this.label1.Text = "Score:";
            // 
            // Form_casAddCommentScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(389, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_casAddScore);
            this.Controls.Add(this.richTextBox_casAddComment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel_Border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_casAddCommentScores";
            this.Text = "Form_casAddCommentScores";
            this.Load += new System.EventHandler(this.Form_casAddCommentScores_Load);
            this.panel_Border.ResumeLayout(false);
            this.panel_Border.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Border;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox_casAddScore;
        private System.Windows.Forms.RichTextBox richTextBox_casAddComment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}