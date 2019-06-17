namespace KözvelemenyKutatas
{
    partial class FormNorm
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
            this.components = new System.ComponentModel.Container();
            this.labelGreetings = new System.Windows.Forms.Label();
            this.labelListMain = new System.Windows.Forms.Label();
            this.cmbList = new System.Windows.Forms.ComboBox();
            this.buttonKitoltes = new System.Windows.Forms.Button();
            this.listBoxMain = new System.Windows.Forms.ListBox();
            this.labelListCmb = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.timerKutatasDisplay = new System.Windows.Forms.Timer(this.components);
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGreetings
            // 
            this.labelGreetings.AutoSize = true;
            this.labelGreetings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGreetings.Location = new System.Drawing.Point(12, 9);
            this.labelGreetings.Name = "labelGreetings";
            this.labelGreetings.Size = new System.Drawing.Size(190, 24);
            this.labelGreetings.TabIndex = 0;
            this.labelGreetings.Text = "Üdvözöljük <EMAIL>!";
            // 
            // labelListMain
            // 
            this.labelListMain.AutoSize = true;
            this.labelListMain.Location = new System.Drawing.Point(13, 33);
            this.labelListMain.Name = "labelListMain";
            this.labelListMain.Size = new System.Drawing.Size(216, 13);
            this.labelListMain.TabIndex = 1;
            this.labelListMain.Text = "Ön által még nem kitöltött / Aktív kutatások:";
            // 
            // cmbList
            // 
            this.cmbList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbList.FormattingEnabled = true;
            this.cmbList.Location = new System.Drawing.Point(16, 365);
            this.cmbList.Name = "cmbList";
            this.cmbList.Size = new System.Drawing.Size(522, 21);
            this.cmbList.TabIndex = 2;
            // 
            // buttonKitoltes
            // 
            this.buttonKitoltes.Location = new System.Drawing.Point(544, 363);
            this.buttonKitoltes.Name = "buttonKitoltes";
            this.buttonKitoltes.Size = new System.Drawing.Size(75, 23);
            this.buttonKitoltes.TabIndex = 3;
            this.buttonKitoltes.Text = "Kitöltés!";
            this.buttonKitoltes.UseVisualStyleBackColor = true;
            this.buttonKitoltes.Click += new System.EventHandler(this.buttonKitoltes_Click);
            // 
            // listBoxMain
            // 
            this.listBoxMain.FormattingEnabled = true;
            this.listBoxMain.Location = new System.Drawing.Point(16, 49);
            this.listBoxMain.Name = "listBoxMain";
            this.listBoxMain.Size = new System.Drawing.Size(603, 290);
            this.listBoxMain.TabIndex = 4;
            // 
            // labelListCmb
            // 
            this.labelListCmb.AutoSize = true;
            this.labelListCmb.Location = new System.Drawing.Point(13, 344);
            this.labelListCmb.Name = "labelListCmb";
            this.labelListCmb.Size = new System.Drawing.Size(130, 13);
            this.labelListCmb.TabIndex = 5;
            this.labelListCmb.Text = "Válaszzon ki egy kutatást!";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(510, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(56, 13);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "LabelDate";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timerKutatasDisplay
            // 
            this.timerKutatasDisplay.Interval = 5000;
            this.timerKutatasDisplay.Tick += new System.EventHandler(this.timerKutatasDisplay_Tick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRefresh.Location = new System.Drawing.Point(588, 312);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(31, 27);
            this.buttonRefresh.TabIndex = 8;
            this.buttonRefresh.Text = "↻";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // FormNorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(631, 398);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelListCmb);
            this.Controls.Add(this.listBoxMain);
            this.Controls.Add(this.buttonKitoltes);
            this.Controls.Add(this.cmbList);
            this.Controls.Add(this.labelListMain);
            this.Controls.Add(this.labelGreetings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormNorm";
            this.Text = "Közvélemény kutatás";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNorm_FormClosed);
            this.Load += new System.EventHandler(this.FormNorm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGreetings;
        private System.Windows.Forms.Label labelListMain;
        private System.Windows.Forms.ComboBox cmbList;
        private System.Windows.Forms.Button buttonKitoltes;
        private System.Windows.Forms.ListBox listBoxMain;
        private System.Windows.Forms.Label labelListCmb;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timerKutatasDisplay;
        private System.Windows.Forms.Button buttonRefresh;
    }
}