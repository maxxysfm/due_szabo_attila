namespace KözvelemenyKutatas
{
    partial class FormAdmin
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
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.comboBoxReActivate = new System.Windows.Forms.ComboBox();
            this.labelSecondary = new System.Windows.Forms.Label();
            this.labelReactivate = new System.Windows.Forms.Label();
            this.buttonReActivate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDeleteKutatas = new System.Windows.Forms.ComboBox();
            this.buttonDeleteSellectedKutatas = new System.Windows.Forms.Button();
            this.labelDeleteSellect = new System.Windows.Forms.Label();
            this.labelModifySellect = new System.Windows.Forms.Label();
            this.comboBoxModify = new System.Windows.Forms.ComboBox();
            this.buttonBoxModify = new System.Windows.Forms.Button();
            this.buttonDeleteDataFromSellectedKutatas = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxInspect = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAnwsersSellected = new System.Windows.Forms.Button();
            this.buttonDiagrammSellected = new System.Windows.Forms.Button();
            this.labelHead = new System.Windows.Forms.Label();
            this.labelFilter = new System.Windows.Forms.Label();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.labelDate = new System.Windows.Forms.Label();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.labelUserHead = new System.Windows.Forms.Label();
            this.buttonDeleteAllUser = new System.Windows.Forms.Button();
            this.labelSellectedUser = new System.Windows.Forms.Label();
            this.comboBoxDeleteUser = new System.Windows.Forms.ComboBox();
            this.labelUserSecondary = new System.Windows.Forms.Label();
            this.buttonDeleteSellectedUser = new System.Windows.Forms.Button();
            this.timerKutatasDisplay = new System.Windows.Forms.Timer(this.components);
            this.buttonDeleteAllKutatas = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(789, 71);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(372, 31);
            this.buttonAddNew.TabIndex = 0;
            this.buttonAddNew.Text = "Új kutatás létrehozása";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDeleteAll.Location = new System.Drawing.Point(794, 539);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(367, 34);
            this.buttonDeleteAll.TabIndex = 2;
            this.buttonDeleteAll.Text = "Adatbázis törlése";
            this.buttonDeleteAll.UseVisualStyleBackColor = false;
            this.buttonDeleteAll.Click += new System.EventHandler(this.buttonDeleteAll_Click);
            // 
            // comboBoxReActivate
            // 
            this.comboBoxReActivate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReActivate.FormattingEnabled = true;
            this.comboBoxReActivate.Location = new System.Drawing.Point(791, 139);
            this.comboBoxReActivate.Name = "comboBoxReActivate";
            this.comboBoxReActivate.Size = new System.Drawing.Size(273, 21);
            this.comboBoxReActivate.TabIndex = 3;
            // 
            // labelSecondary
            // 
            this.labelSecondary.AutoSize = true;
            this.labelSecondary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSecondary.Location = new System.Drawing.Point(791, 105);
            this.labelSecondary.Name = "labelSecondary";
            this.labelSecondary.Size = new System.Drawing.Size(219, 18);
            this.labelSecondary.TabIndex = 4;
            this.labelSecondary.Text = "Meglévő kutatások módosítása:";
            // 
            // labelReactivate
            // 
            this.labelReactivate.AutoSize = true;
            this.labelReactivate.Location = new System.Drawing.Point(791, 123);
            this.labelReactivate.Name = "labelReactivate";
            this.labelReactivate.Size = new System.Drawing.Size(114, 13);
            this.labelReactivate.TabIndex = 5;
            this.labelReactivate.Text = "Kutatás újraaktiválása:";
            // 
            // buttonReActivate
            // 
            this.buttonReActivate.Location = new System.Drawing.Point(1070, 137);
            this.buttonReActivate.Name = "buttonReActivate";
            this.buttonReActivate.Size = new System.Drawing.Size(91, 23);
            this.buttonReActivate.TabIndex = 6;
            this.buttonReActivate.Text = "Újraaktiválás";
            this.buttonReActivate.UseVisualStyleBackColor = true;
            this.buttonReActivate.Click += new System.EventHandler(this.buttonReActivate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Admin felület: Kutatások listázása:";
            // 
            // comboBoxDeleteKutatas
            // 
            this.comboBoxDeleteKutatas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeleteKutatas.FormattingEnabled = true;
            this.comboBoxDeleteKutatas.Location = new System.Drawing.Point(791, 219);
            this.comboBoxDeleteKutatas.Name = "comboBoxDeleteKutatas";
            this.comboBoxDeleteKutatas.Size = new System.Drawing.Size(370, 21);
            this.comboBoxDeleteKutatas.TabIndex = 8;
            // 
            // buttonDeleteSellectedKutatas
            // 
            this.buttonDeleteSellectedKutatas.Location = new System.Drawing.Point(791, 246);
            this.buttonDeleteSellectedKutatas.Name = "buttonDeleteSellectedKutatas";
            this.buttonDeleteSellectedKutatas.Size = new System.Drawing.Size(172, 23);
            this.buttonDeleteSellectedKutatas.TabIndex = 9;
            this.buttonDeleteSellectedKutatas.Text = "Kutatás törlése";
            this.buttonDeleteSellectedKutatas.UseVisualStyleBackColor = true;
            this.buttonDeleteSellectedKutatas.Click += new System.EventHandler(this.buttonDeleteSellectedKutatas_Click);
            // 
            // labelDeleteSellect
            // 
            this.labelDeleteSellect.AutoSize = true;
            this.labelDeleteSellect.Location = new System.Drawing.Point(791, 203);
            this.labelDeleteSellect.Name = "labelDeleteSellect";
            this.labelDeleteSellect.Size = new System.Drawing.Size(80, 13);
            this.labelDeleteSellect.TabIndex = 10;
            this.labelDeleteSellect.Text = "Kutatás törlése:";
            // 
            // labelModifySellect
            // 
            this.labelModifySellect.AutoSize = true;
            this.labelModifySellect.Location = new System.Drawing.Point(791, 163);
            this.labelModifySellect.Name = "labelModifySellect";
            this.labelModifySellect.Size = new System.Drawing.Size(213, 13);
            this.labelModifySellect.TabIndex = 11;
            this.labelModifySellect.Text = "Kutatás módosítása (Nem aktív kutatások):";
            // 
            // comboBoxModify
            // 
            this.comboBoxModify.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModify.FormattingEnabled = true;
            this.comboBoxModify.Location = new System.Drawing.Point(791, 179);
            this.comboBoxModify.Name = "comboBoxModify";
            this.comboBoxModify.Size = new System.Drawing.Size(273, 21);
            this.comboBoxModify.TabIndex = 12;
            // 
            // buttonBoxModify
            // 
            this.buttonBoxModify.Location = new System.Drawing.Point(1070, 178);
            this.buttonBoxModify.Name = "buttonBoxModify";
            this.buttonBoxModify.Size = new System.Drawing.Size(91, 23);
            this.buttonBoxModify.TabIndex = 13;
            this.buttonBoxModify.Text = "Módosítás";
            this.buttonBoxModify.UseVisualStyleBackColor = true;
            this.buttonBoxModify.Click += new System.EventHandler(this.buttonBoxModify_Click);
            // 
            // buttonDeleteDataFromSellectedKutatas
            // 
            this.buttonDeleteDataFromSellectedKutatas.Location = new System.Drawing.Point(962, 246);
            this.buttonDeleteDataFromSellectedKutatas.Name = "buttonDeleteDataFromSellectedKutatas";
            this.buttonDeleteDataFromSellectedKutatas.Size = new System.Drawing.Size(199, 23);
            this.buttonDeleteDataFromSellectedKutatas.TabIndex = 14;
            this.buttonDeleteDataFromSellectedKutatas.Text = "Kutatási adatok törlése";
            this.buttonDeleteDataFromSellectedKutatas.UseVisualStyleBackColor = true;
            this.buttonDeleteDataFromSellectedKutatas.Click += new System.EventHandler(this.buttonDeleteDataFromSellectedKutatas_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(791, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Kutatások részletes elemzése:";
            // 
            // comboBoxInspect
            // 
            this.comboBoxInspect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInspect.FormattingEnabled = true;
            this.comboBoxInspect.Location = new System.Drawing.Point(791, 339);
            this.comboBoxInspect.Name = "comboBoxInspect";
            this.comboBoxInspect.Size = new System.Drawing.Size(370, 21);
            this.comboBoxInspect.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(791, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kijelölt kutatás:";
            // 
            // buttonAnwsersSellected
            // 
            this.buttonAnwsersSellected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonAnwsersSellected.Location = new System.Drawing.Point(791, 366);
            this.buttonAnwsersSellected.Name = "buttonAnwsersSellected";
            this.buttonAnwsersSellected.Size = new System.Drawing.Size(370, 23);
            this.buttonAnwsersSellected.TabIndex = 18;
            this.buttonAnwsersSellected.Text = "Beérkező válaszok megtekintése";
            this.buttonAnwsersSellected.UseVisualStyleBackColor = false;
            this.buttonAnwsersSellected.Click += new System.EventHandler(this.buttonAnwsersSellected_Click);
            // 
            // buttonDiagrammSellected
            // 
            this.buttonDiagrammSellected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonDiagrammSellected.Location = new System.Drawing.Point(791, 387);
            this.buttonDiagrammSellected.Name = "buttonDiagrammSellected";
            this.buttonDiagrammSellected.Size = new System.Drawing.Size(370, 23);
            this.buttonDiagrammSellected.TabIndex = 19;
            this.buttonDiagrammSellected.Text = "Diagramm";
            this.buttonDiagrammSellected.UseVisualStyleBackColor = false;
            this.buttonDiagrammSellected.Click += new System.EventHandler(this.buttonDiagrammSellected_Click);
            // 
            // labelHead
            // 
            this.labelHead.AutoSize = true;
            this.labelHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHead.Location = new System.Drawing.Point(791, 46);
            this.labelHead.Name = "labelHead";
            this.labelHead.Size = new System.Drawing.Size(200, 18);
            this.labelHead.TabIndex = 20;
            this.labelHead.Text = "Kutatásokkal való műveletek:";
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(12, 44);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(99, 13);
            this.labelFilter.TabIndex = 22;
            this.labelFilter.Text = "Szűrési beállítások:";
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(117, 41);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(292, 21);
            this.comboBoxFilter.TabIndex = 23;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(15, 71);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.Size = new System.Drawing.Size(768, 339);
            this.dataGridViewMain.TabIndex = 24;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(583, 44);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(56, 13);
            this.labelDate.TabIndex = 25;
            this.labelDate.Text = "DateLabel";
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(15, 434);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.Size = new System.Drawing.Size(768, 131);
            this.dataGridViewUsers.TabIndex = 26;
            // 
            // labelUserHead
            // 
            this.labelUserHead.AutoSize = true;
            this.labelUserHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserHead.Location = new System.Drawing.Point(12, 413);
            this.labelUserHead.Name = "labelUserHead";
            this.labelUserHead.Size = new System.Drawing.Size(253, 18);
            this.labelUserHead.TabIndex = 27;
            this.labelUserHead.Text = "Admin felület: Felhasználók listázása:";
            // 
            // buttonDeleteAllUser
            // 
            this.buttonDeleteAllUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDeleteAllUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteAllUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDeleteAllUser.Location = new System.Drawing.Point(794, 511);
            this.buttonDeleteAllUser.Name = "buttonDeleteAllUser";
            this.buttonDeleteAllUser.Size = new System.Drawing.Size(367, 34);
            this.buttonDeleteAllUser.TabIndex = 28;
            this.buttonDeleteAllUser.Text = "Összes felhasználó törlése";
            this.buttonDeleteAllUser.UseVisualStyleBackColor = false;
            this.buttonDeleteAllUser.Click += new System.EventHandler(this.buttonDeleteAllUser_Click);
            // 
            // labelSellectedUser
            // 
            this.labelSellectedUser.AutoSize = true;
            this.labelSellectedUser.Location = new System.Drawing.Point(794, 454);
            this.labelSellectedUser.Name = "labelSellectedUser";
            this.labelSellectedUser.Size = new System.Drawing.Size(96, 13);
            this.labelSellectedUser.TabIndex = 31;
            this.labelSellectedUser.Text = "Kijelölt felhasználó:";
            // 
            // comboBoxDeleteUser
            // 
            this.comboBoxDeleteUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeleteUser.FormattingEnabled = true;
            this.comboBoxDeleteUser.Location = new System.Drawing.Point(794, 470);
            this.comboBoxDeleteUser.Name = "comboBoxDeleteUser";
            this.comboBoxDeleteUser.Size = new System.Drawing.Size(367, 21);
            this.comboBoxDeleteUser.TabIndex = 30;
            // 
            // labelUserSecondary
            // 
            this.labelUserSecondary.AutoSize = true;
            this.labelUserSecondary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserSecondary.Location = new System.Drawing.Point(794, 435);
            this.labelUserSecondary.Name = "labelUserSecondary";
            this.labelUserSecondary.Size = new System.Drawing.Size(221, 18);
            this.labelUserSecondary.TabIndex = 29;
            this.labelUserSecondary.Text = "Felhasználókkal való műveletek:";
            // 
            // buttonDeleteSellectedUser
            // 
            this.buttonDeleteSellectedUser.Location = new System.Drawing.Point(794, 491);
            this.buttonDeleteSellectedUser.Name = "buttonDeleteSellectedUser";
            this.buttonDeleteSellectedUser.Size = new System.Drawing.Size(367, 23);
            this.buttonDeleteSellectedUser.TabIndex = 32;
            this.buttonDeleteSellectedUser.Text = "Felhasználó törlése";
            this.buttonDeleteSellectedUser.UseVisualStyleBackColor = true;
            this.buttonDeleteSellectedUser.Click += new System.EventHandler(this.buttonDeleteSellectedUser_Click);
            // 
            // timerKutatasDisplay
            // 
            this.timerKutatasDisplay.Interval = 5000;
            this.timerKutatasDisplay.Tick += new System.EventHandler(this.timerKutatasDisplay_Tick);
            // 
            // buttonDeleteAllKutatas
            // 
            this.buttonDeleteAllKutatas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDeleteAllKutatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteAllKutatas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDeleteAllKutatas.Location = new System.Drawing.Point(791, 267);
            this.buttonDeleteAllKutatas.Name = "buttonDeleteAllKutatas";
            this.buttonDeleteAllKutatas.Size = new System.Drawing.Size(370, 34);
            this.buttonDeleteAllKutatas.TabIndex = 33;
            this.buttonDeleteAllKutatas.Text = "Összes kutatás törlése";
            this.buttonDeleteAllKutatas.UseVisualStyleBackColor = false;
            this.buttonDeleteAllKutatas.Click += new System.EventHandler(this.buttonDeleteAllKutatas_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRefresh.Location = new System.Drawing.Point(752, 383);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(31, 27);
            this.buttonRefresh.TabIndex = 34;
            this.buttonRefresh.Text = "↻";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1173, 574);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDeleteAllKutatas);
            this.Controls.Add(this.buttonDeleteSellectedUser);
            this.Controls.Add(this.labelSellectedUser);
            this.Controls.Add(this.comboBoxDeleteUser);
            this.Controls.Add(this.labelUserSecondary);
            this.Controls.Add(this.buttonDeleteAllUser);
            this.Controls.Add(this.labelUserHead);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.labelHead);
            this.Controls.Add(this.buttonDiagrammSellected);
            this.Controls.Add(this.buttonAnwsersSellected);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxInspect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonDeleteDataFromSellectedKutatas);
            this.Controls.Add(this.buttonBoxModify);
            this.Controls.Add(this.comboBoxModify);
            this.Controls.Add(this.labelModifySellect);
            this.Controls.Add(this.labelDeleteSellect);
            this.Controls.Add(this.buttonDeleteSellectedKutatas);
            this.Controls.Add(this.comboBoxDeleteKutatas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonReActivate);
            this.Controls.Add(this.labelReactivate);
            this.Controls.Add(this.labelSecondary);
            this.Controls.Add(this.comboBoxReActivate);
            this.Controls.Add(this.buttonDeleteAll);
            this.Controls.Add(this.buttonAddNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormAdmin";
            this.Text = "Felhasználói felület: Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.ComboBox comboBoxReActivate;
        private System.Windows.Forms.Label labelSecondary;
        private System.Windows.Forms.Label labelReactivate;
        private System.Windows.Forms.Button buttonReActivate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDeleteKutatas;
        private System.Windows.Forms.Button buttonDeleteSellectedKutatas;
        private System.Windows.Forms.Label labelDeleteSellect;
        private System.Windows.Forms.Label labelModifySellect;
        private System.Windows.Forms.ComboBox comboBoxModify;
        private System.Windows.Forms.Button buttonBoxModify;
        private System.Windows.Forms.Button buttonDeleteDataFromSellectedKutatas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxInspect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAnwsersSellected;
        private System.Windows.Forms.Button buttonDiagrammSellected;
        private System.Windows.Forms.Label labelHead;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Label labelUserHead;
        private System.Windows.Forms.Button buttonDeleteAllUser;
        private System.Windows.Forms.Label labelSellectedUser;
        private System.Windows.Forms.ComboBox comboBoxDeleteUser;
        private System.Windows.Forms.Label labelUserSecondary;
        private System.Windows.Forms.Button buttonDeleteSellectedUser;
        private System.Windows.Forms.Timer timerKutatasDisplay;
        private System.Windows.Forms.Button buttonDeleteAllKutatas;
        private System.Windows.Forms.Button buttonRefresh;
    }
}