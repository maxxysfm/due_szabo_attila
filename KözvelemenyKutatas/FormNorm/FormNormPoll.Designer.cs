namespace KözvelemenyKutatas
{
    partial class FormNormPoll
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
            this.buttonFinish = new System.Windows.Forms.Button();
            this.comboBoxValasz = new System.Windows.Forms.ComboBox();
            this.comboBoxKerdesek = new System.Windows.Forms.ComboBox();
            this.buttonSaveAnwser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(413, 65);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(160, 32);
            this.buttonFinish.TabIndex = 0;
            this.buttonFinish.Text = "Kutatás leadása";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // comboBoxValasz
            // 
            this.comboBoxValasz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxValasz.FormattingEnabled = true;
            this.comboBoxValasz.Location = new System.Drawing.Point(12, 38);
            this.comboBoxValasz.Name = "comboBoxValasz";
            this.comboBoxValasz.Size = new System.Drawing.Size(561, 21);
            this.comboBoxValasz.TabIndex = 3;
            // 
            // comboBoxKerdesek
            // 
            this.comboBoxKerdesek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKerdesek.FormattingEnabled = true;
            this.comboBoxKerdesek.Location = new System.Drawing.Point(12, 12);
            this.comboBoxKerdesek.Name = "comboBoxKerdesek";
            this.comboBoxKerdesek.Size = new System.Drawing.Size(561, 21);
            this.comboBoxKerdesek.TabIndex = 8;
            this.comboBoxKerdesek.SelectedIndexChanged += new System.EventHandler(this.comboBoxKerdesek_SelectedIndexChanged);
            // 
            // buttonSaveAnwser
            // 
            this.buttonSaveAnwser.Location = new System.Drawing.Point(12, 65);
            this.buttonSaveAnwser.Name = "buttonSaveAnwser";
            this.buttonSaveAnwser.Size = new System.Drawing.Size(110, 23);
            this.buttonSaveAnwser.TabIndex = 9;
            this.buttonSaveAnwser.Text = "Válasz mentése";
            this.buttonSaveAnwser.UseVisualStyleBackColor = true;
            this.buttonSaveAnwser.Click += new System.EventHandler(this.buttonSaveAnwser_Click);
            // 
            // FormNormPoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(585, 104);
            this.Controls.Add(this.buttonSaveAnwser);
            this.Controls.Add(this.comboBoxKerdesek);
            this.Controls.Add(this.comboBoxValasz);
            this.Controls.Add(this.buttonFinish);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNormPoll";
            this.Text = "Kutatás kitöltése";
            this.Load += new System.EventHandler(this.FormNormPoll_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.ComboBox comboBoxValasz;
        private System.Windows.Forms.ComboBox comboBoxKerdesek;
        private System.Windows.Forms.Button buttonSaveAnwser;
    }
}