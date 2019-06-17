namespace KözvelemenyKutatas
{
    partial class FormAdminViewGraph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxVegzettseg = new System.Windows.Forms.ComboBox();
            this.comboBoxNem = new System.Windows.Forms.ComboBox();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numericUpDownAgeMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAgeMax = new System.Windows.Forms.NumericUpDown();
            this.labelBetweenAge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgeMax)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(16, 152);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(121, 23);
            this.buttonFilter.TabIndex = 0;
            this.buttonFilter.Text = "Szűrés";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diagramm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Életkor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Iskolai végzettség:";
            // 
            // comboBoxVegzettseg
            // 
            this.comboBoxVegzettseg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVegzettseg.FormattingEnabled = true;
            this.comboBoxVegzettseg.Location = new System.Drawing.Point(16, 125);
            this.comboBoxVegzettseg.Name = "comboBoxVegzettseg";
            this.comboBoxVegzettseg.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVegzettseg.TabIndex = 5;
            // 
            // comboBoxNem
            // 
            this.comboBoxNem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNem.FormattingEnabled = true;
            this.comboBoxNem.Location = new System.Drawing.Point(16, 45);
            this.comboBoxNem.Name = "comboBoxNem";
            this.comboBoxNem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNem.TabIndex = 7;
            // 
            // chartMain
            // 
            this.chartMain.BorderlineColor = System.Drawing.Color.Black;
            this.chartMain.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMain.Legends.Add(legend1);
            this.chartMain.Location = new System.Drawing.Point(143, 12);
            this.chartMain.Name = "chartMain";
            this.chartMain.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.chartMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.LabelBorderWidth = 2;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "SeriesKerdesek";
            this.chartMain.Series.Add(series1);
            this.chartMain.Size = new System.Drawing.Size(582, 529);
            this.chartMain.TabIndex = 9;
            this.chartMain.Text = "chartKerdes";
            // 
            // numericUpDownAgeMin
            // 
            this.numericUpDownAgeMin.Location = new System.Drawing.Point(16, 86);
            this.numericUpDownAgeMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAgeMin.Name = "numericUpDownAgeMin";
            this.numericUpDownAgeMin.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownAgeMin.TabIndex = 10;
            this.numericUpDownAgeMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownAgeMax
            // 
            this.numericUpDownAgeMax.Location = new System.Drawing.Point(69, 86);
            this.numericUpDownAgeMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAgeMax.Name = "numericUpDownAgeMax";
            this.numericUpDownAgeMax.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownAgeMax.TabIndex = 11;
            this.numericUpDownAgeMax.Value = new decimal(new int[] {
            99,
            0,
            0,
            0});
            // 
            // labelBetweenAge
            // 
            this.labelBetweenAge.AutoSize = true;
            this.labelBetweenAge.Location = new System.Drawing.Point(55, 89);
            this.labelBetweenAge.Name = "labelBetweenAge";
            this.labelBetweenAge.Size = new System.Drawing.Size(10, 13);
            this.labelBetweenAge.TabIndex = 12;
            this.labelBetweenAge.Text = "-";
            // 
            // FormAdminViewGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 553);
            this.Controls.Add(this.labelBetweenAge);
            this.Controls.Add(this.numericUpDownAgeMax);
            this.Controls.Add(this.numericUpDownAgeMin);
            this.Controls.Add(this.chartMain);
            this.Controls.Add(this.comboBoxNem);
            this.Controls.Add(this.comboBoxVegzettseg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormAdminViewGraph";
            this.Text = "Diagramm nézet";
            this.Load += new System.EventHandler(this.FormAdminViewGraph_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgeMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxVegzettseg;
        private System.Windows.Forms.ComboBox comboBoxNem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.NumericUpDown numericUpDownAgeMin;
        private System.Windows.Forms.NumericUpDown numericUpDownAgeMax;
        private System.Windows.Forms.Label labelBetweenAge;
    }
}