namespace KözvelemenyKutatas
{
    partial class FormStart
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
            this.btnDevKit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDevKit
            // 
            this.btnDevKit.Location = new System.Drawing.Point(12, 12);
            this.btnDevKit.Name = "btnDevKit";
            this.btnDevKit.Size = new System.Drawing.Size(324, 52);
            this.btnDevKit.TabIndex = 0;
            this.btnDevKit.Text = "Fejlesztői eszközök indítása";
            this.btnDevKit.UseVisualStyleBackColor = true;
            this.btnDevKit.Click += new System.EventHandler(this.btnDevKit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 61);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(324, 57);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Alapvető indítás";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 130);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnDevKit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStart";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDevKit;
        private System.Windows.Forms.Button btnStart;
    }
}

