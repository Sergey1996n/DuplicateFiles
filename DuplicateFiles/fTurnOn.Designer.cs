
namespace DuplicateFiles
{
    partial class fTurnOn
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
            this.tbReview = new System.Windows.Forms.TextBox();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbReview
            // 
            this.tbReview.Location = new System.Drawing.Point(22, 25);
            this.tbReview.Name = "tbReview";
            this.tbReview.Size = new System.Drawing.Size(250, 20);
            this.tbReview.TabIndex = 1;
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(305, 23);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(75, 23);
            this.btnReview.TabIndex = 2;
            this.btnReview.Text = "Обзор";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(224, 75);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(325, 75);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fTurnOn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 116);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbReview);
            this.Controls.Add(this.btnReview);
            this.Name = "fTurnOn";
            this.Text = "Включить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox tbReview;
    }
}