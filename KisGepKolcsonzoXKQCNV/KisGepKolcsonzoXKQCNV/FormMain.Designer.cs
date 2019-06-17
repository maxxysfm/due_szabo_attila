namespace KisGepKolcsonzoXKQCNV
{
    partial class FormMain
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
            this.listBoxMain = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelKedvezmeny = new System.Windows.Forms.Label();
            this.labelKedvezmenyNelkul = new System.Windows.Forms.Label();
            this.labelKedvezmennyel = new System.Windows.Forms.Label();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownFilter = new System.Windows.Forms.NumericUpDown();
            this.listBoxSecondary = new System.Windows.Forms.ListBox();
            this.buttonSaveXML = new System.Windows.Forms.Button();
            this.comboBoxUgyfelek = new System.Windows.Forms.ComboBox();
            this.buttonChart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxMain
            // 
            this.listBoxMain.Enabled = false;
            this.listBoxMain.FormattingEnabled = true;
            this.listBoxMain.Location = new System.Drawing.Point(12, 38);
            this.listBoxMain.Name = "listBoxMain";
            this.listBoxMain.Size = new System.Drawing.Size(502, 316);
            this.listBoxMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kölcsönzés teljes ára kedvezmény nélkül(FT):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kölcsönzés teljes ára kedvezményel(FT):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "A kedvezmény mértéke(FT):";
            // 
            // labelKedvezmeny
            // 
            this.labelKedvezmeny.AutoSize = true;
            this.labelKedvezmeny.Location = new System.Drawing.Point(245, 449);
            this.labelKedvezmeny.Name = "labelKedvezmeny";
            this.labelKedvezmeny.Size = new System.Drawing.Size(13, 13);
            this.labelKedvezmeny.TabIndex = 6;
            this.labelKedvezmeny.Text = "0";
            // 
            // labelKedvezmenyNelkul
            // 
            this.labelKedvezmenyNelkul.AutoSize = true;
            this.labelKedvezmenyNelkul.Location = new System.Drawing.Point(245, 369);
            this.labelKedvezmenyNelkul.Name = "labelKedvezmenyNelkul";
            this.labelKedvezmenyNelkul.Size = new System.Drawing.Size(13, 13);
            this.labelKedvezmenyNelkul.TabIndex = 7;
            this.labelKedvezmenyNelkul.Text = "0";
            // 
            // labelKedvezmennyel
            // 
            this.labelKedvezmennyel.AutoSize = true;
            this.labelKedvezmennyel.Location = new System.Drawing.Point(245, 409);
            this.labelKedvezmennyel.Name = "labelKedvezmennyel";
            this.labelKedvezmennyel.Size = new System.Drawing.Size(13, 13);
            this.labelKedvezmennyel.TabIndex = 8;
            this.labelKedvezmennyel.Text = "0";
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(755, 398);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 9;
            this.buttonFilter.Text = "Szűrés";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(590, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Kedvezmény minimum:";
            // 
            // numericUpDownFilter
            // 
            this.numericUpDownFilter.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownFilter.Location = new System.Drawing.Point(710, 369);
            this.numericUpDownFilter.Name = "numericUpDownFilter";
            this.numericUpDownFilter.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownFilter.TabIndex = 11;
            // 
            // listBoxSecondary
            // 
            this.listBoxSecondary.FormattingEnabled = true;
            this.listBoxSecondary.Location = new System.Drawing.Point(520, 12);
            this.listBoxSecondary.Name = "listBoxSecondary";
            this.listBoxSecondary.Size = new System.Drawing.Size(310, 342);
            this.listBoxSecondary.TabIndex = 12;
            // 
            // buttonSaveXML
            // 
            this.buttonSaveXML.Location = new System.Drawing.Point(755, 427);
            this.buttonSaveXML.Name = "buttonSaveXML";
            this.buttonSaveXML.Size = new System.Drawing.Size(75, 36);
            this.buttonSaveXML.TabIndex = 13;
            this.buttonSaveXML.Text = "Mentés XML-be";
            this.buttonSaveXML.UseVisualStyleBackColor = true;
            this.buttonSaveXML.Click += new System.EventHandler(this.buttonSaveXML_Click);
            // 
            // comboBoxUgyfelek
            // 
            this.comboBoxUgyfelek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUgyfelek.FormattingEnabled = true;
            this.comboBoxUgyfelek.Location = new System.Drawing.Point(12, 11);
            this.comboBoxUgyfelek.Name = "comboBoxUgyfelek";
            this.comboBoxUgyfelek.Size = new System.Drawing.Size(502, 21);
            this.comboBoxUgyfelek.TabIndex = 14;
            this.comboBoxUgyfelek.SelectedIndexChanged += new System.EventHandler(this.comboBoxUgyfelek_SelectedIndexChanged);
            // 
            // buttonChart
            // 
            this.buttonChart.Location = new System.Drawing.Point(439, 361);
            this.buttonChart.Name = "buttonChart";
            this.buttonChart.Size = new System.Drawing.Size(75, 60);
            this.buttonChart.TabIndex = 15;
            this.buttonChart.Text = "Diagram";
            this.buttonChart.UseVisualStyleBackColor = true;
            this.buttonChart.Click += new System.EventHandler(this.buttonChart_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 475);
            this.Controls.Add(this.buttonChart);
            this.Controls.Add(this.comboBoxUgyfelek);
            this.Controls.Add(this.buttonSaveXML);
            this.Controls.Add(this.listBoxSecondary);
            this.Controls.Add(this.numericUpDownFilter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.labelKedvezmennyel);
            this.Controls.Add(this.labelKedvezmenyNelkul);
            this.Controls.Add(this.labelKedvezmeny);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormMain";
            this.Text = "Kölcsönző";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelKedvezmeny;
        private System.Windows.Forms.Label labelKedvezmenyNelkul;
        private System.Windows.Forms.Label labelKedvezmennyel;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownFilter;
        private System.Windows.Forms.ListBox listBoxSecondary;
        private System.Windows.Forms.Button buttonSaveXML;
        private System.Windows.Forms.ComboBox comboBoxUgyfelek;
        private System.Windows.Forms.Button buttonChart;
    }
}

