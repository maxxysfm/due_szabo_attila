namespace Beadando
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
            this.comboBoxPlayerSelect = new System.Windows.Forms.ComboBox();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.buttonSaveXML = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMostGames = new System.Windows.Forms.Button();
            this.buttonPlayerStatistics = new System.Windows.Forms.Button();
            this.buttonMMRAverage = new System.Windows.Forms.Button();
            this.buttonChart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxPlayerSelect
            // 
            this.comboBoxPlayerSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlayerSelect.FormattingEnabled = true;
            this.comboBoxPlayerSelect.Location = new System.Drawing.Point(80, 12);
            this.comboBoxPlayerSelect.Name = "comboBoxPlayerSelect";
            this.comboBoxPlayerSelect.Size = new System.Drawing.Size(651, 21);
            this.comboBoxPlayerSelect.TabIndex = 0;
            this.comboBoxPlayerSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlayerSelect_SelectedIndexChanged);
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.Location = new System.Drawing.Point(12, 39);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(719, 225);
            this.listBoxDisplay.TabIndex = 1;
            // 
            // buttonSaveXML
            // 
            this.buttonSaveXML.Location = new System.Drawing.Point(602, 270);
            this.buttonSaveXML.Name = "buttonSaveXML";
            this.buttonSaveXML.Size = new System.Drawing.Size(129, 39);
            this.buttonSaveXML.TabIndex = 2;
            this.buttonSaveXML.Text = "Mentés XML-be";
            this.buttonSaveXML.UseVisualStyleBackColor = true;
            this.buttonSaveXML.Click += new System.EventHandler(this.buttonSaveXML_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Karakterek:";
            // 
            // buttonMostGames
            // 
            this.buttonMostGames.Location = new System.Drawing.Point(12, 270);
            this.buttonMostGames.Name = "buttonMostGames";
            this.buttonMostGames.Size = new System.Drawing.Size(137, 39);
            this.buttonMostGames.TabIndex = 4;
            this.buttonMostGames.Text = "Legtöbb játék melyik pályán zajlott?";
            this.buttonMostGames.UseVisualStyleBackColor = true;
            this.buttonMostGames.Click += new System.EventHandler(this.buttonMostGames_Click);
            // 
            // buttonPlayerStatistics
            // 
            this.buttonPlayerStatistics.Location = new System.Drawing.Point(12, 315);
            this.buttonPlayerStatistics.Name = "buttonPlayerStatistics";
            this.buttonPlayerStatistics.Size = new System.Drawing.Size(137, 48);
            this.buttonPlayerStatistics.TabIndex = 5;
            this.buttonPlayerStatistics.Text = "Meccsek adatai";
            this.buttonPlayerStatistics.UseVisualStyleBackColor = true;
            this.buttonPlayerStatistics.Click += new System.EventHandler(this.buttonPlayerStatistics_Click);
            // 
            // buttonMMRAverage
            // 
            this.buttonMMRAverage.Location = new System.Drawing.Point(12, 369);
            this.buttonMMRAverage.Name = "buttonMMRAverage";
            this.buttonMMRAverage.Size = new System.Drawing.Size(137, 48);
            this.buttonMMRAverage.TabIndex = 6;
            this.buttonMMRAverage.Text = "\"irl wipe\" csapat átlagos skill ratingje";
            this.buttonMMRAverage.UseVisualStyleBackColor = true;
            this.buttonMMRAverage.Click += new System.EventHandler(this.buttonMMRAverage_Click);
            // 
            // buttonChart
            // 
            this.buttonChart.Location = new System.Drawing.Point(602, 380);
            this.buttonChart.Name = "buttonChart";
            this.buttonChart.Size = new System.Drawing.Size(129, 52);
            this.buttonChart.TabIndex = 7;
            this.buttonChart.Text = "Chart";
            this.buttonChart.UseVisualStyleBackColor = true;
            this.buttonChart.Click += new System.EventHandler(this.buttonChart_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 444);
            this.Controls.Add(this.buttonChart);
            this.Controls.Add(this.buttonMMRAverage);
            this.Controls.Add(this.buttonPlayerStatistics);
            this.Controls.Add(this.buttonMostGames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveXML);
            this.Controls.Add(this.listBoxDisplay);
            this.Controls.Add(this.comboBoxPlayerSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormMain";
            this.Text = "Overwatch játékosok statisztikái";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPlayerSelect;
        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.Button buttonSaveXML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMostGames;
        private System.Windows.Forms.Button buttonPlayerStatistics;
        private System.Windows.Forms.Button buttonMMRAverage;
        private System.Windows.Forms.Button buttonChart;
    }
}

