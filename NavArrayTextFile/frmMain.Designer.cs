namespace NavArrayTextFile
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRelease1 = new System.Windows.Forms.Button();
            this.btnRelease2 = new System.Windows.Forms.Button();
            this.btnRelease3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRelease1
            // 
            this.btnRelease1.Location = new System.Drawing.Point(313, 190);
            this.btnRelease1.Name = "btnRelease1";
            this.btnRelease1.Size = new System.Drawing.Size(150, 46);
            this.btnRelease1.TabIndex = 0;
            this.btnRelease1.Text = "Release 1";
            this.btnRelease1.UseVisualStyleBackColor = true;
            this.btnRelease1.Click += new System.EventHandler(this.btnRelease1_Click_1);
            // 
            // btnRelease2
            // 
            this.btnRelease2.Location = new System.Drawing.Point(313, 256);
            this.btnRelease2.Name = "btnRelease2";
            this.btnRelease2.Size = new System.Drawing.Size(150, 46);
            this.btnRelease2.TabIndex = 1;
            this.btnRelease2.Text = "Release 2";
            this.btnRelease2.UseVisualStyleBackColor = true;
            this.btnRelease2.Click += new System.EventHandler(this.btnRelease2_Click);
            // 
            // btnRelease3
            // 
            this.btnRelease3.Location = new System.Drawing.Point(313, 326);
            this.btnRelease3.Name = "btnRelease3";
            this.btnRelease3.Size = new System.Drawing.Size(150, 46);
            this.btnRelease3.TabIndex = 2;
            this.btnRelease3.Text = "Release 3";
            this.btnRelease3.UseVisualStyleBackColor = true;
            this.btnRelease3.Click += new System.EventHandler(this.btnRelease3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(260, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Flight Release";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRelease3);
            this.Controls.Add(this.btnRelease2);
            this.Controls.Add(this.btnRelease1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Air Wisconsin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRelease1;
        private Button btnRelease2;
        private Button btnRelease3;
        private Label label1;
    }
}