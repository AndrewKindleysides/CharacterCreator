namespace Client
{
    partial class MainWindow
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
            this.staminaBox = new System.Windows.Forms.TextBox();
            this.defenceBox = new System.Windows.Forms.TextBox();
            this.hitBox = new System.Windows.Forms.TextBox();
            this.critBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.staminaLabel = new System.Windows.Forms.Label();
            this.defenceLabel = new System.Windows.Forms.Label();
            this.hitLabel = new System.Windows.Forms.Label();
            this.critLabel = new System.Windows.Forms.Label();
            this.classListBox = new System.Windows.Forms.ComboBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.raceListBox = new System.Windows.Forms.ComboBox();
            this.raceLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.currentCharactersGrid = new System.Windows.Forms.DataGridView();
            this.classIcon = new System.Windows.Forms.PictureBox();
            this.raceIcon = new System.Windows.Forms.PictureBox();
            this.CharacterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharacterRace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharacterClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.currentCharactersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // staminaBox
            // 
            this.staminaBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.staminaBox.Location = new System.Drawing.Point(82, 94);
            this.staminaBox.Name = "staminaBox";
            this.staminaBox.Size = new System.Drawing.Size(64, 20);
            this.staminaBox.TabIndex = 4;
            this.staminaBox.Text = "1";
            // 
            // defenceBox
            // 
            this.defenceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.defenceBox.Location = new System.Drawing.Point(82, 120);
            this.defenceBox.Name = "defenceBox";
            this.defenceBox.Size = new System.Drawing.Size(64, 20);
            this.defenceBox.TabIndex = 5;
            this.defenceBox.Text = "1";
            // 
            // hitBox
            // 
            this.hitBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hitBox.Location = new System.Drawing.Point(82, 146);
            this.hitBox.Name = "hitBox";
            this.hitBox.Size = new System.Drawing.Size(64, 20);
            this.hitBox.TabIndex = 6;
            this.hitBox.Text = "1";
            // 
            // critBox
            // 
            this.critBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.critBox.Location = new System.Drawing.Point(82, 172);
            this.critBox.Name = "critBox";
            this.critBox.Size = new System.Drawing.Size(64, 20);
            this.critBox.TabIndex = 7;
            this.critBox.Text = "1";
            // 
            // nameBox
            // 
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Location = new System.Drawing.Point(82, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(134, 20);
            this.nameBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(38, 14);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name:";
            // 
            // staminaLabel
            // 
            this.staminaLabel.AutoSize = true;
            this.staminaLabel.Location = new System.Drawing.Point(28, 96);
            this.staminaLabel.Name = "staminaLabel";
            this.staminaLabel.Size = new System.Drawing.Size(48, 13);
            this.staminaLabel.TabIndex = 6;
            this.staminaLabel.Text = "Stamina:";
            // 
            // defenceLabel
            // 
            this.defenceLabel.AutoSize = true;
            this.defenceLabel.Location = new System.Drawing.Point(25, 122);
            this.defenceLabel.Name = "defenceLabel";
            this.defenceLabel.Size = new System.Drawing.Size(51, 13);
            this.defenceLabel.TabIndex = 7;
            this.defenceLabel.Text = "Defence:";
            // 
            // hitLabel
            // 
            this.hitLabel.AutoSize = true;
            this.hitLabel.Location = new System.Drawing.Point(53, 148);
            this.hitLabel.Name = "hitLabel";
            this.hitLabel.Size = new System.Drawing.Size(23, 13);
            this.hitLabel.TabIndex = 8;
            this.hitLabel.Text = "Hit:";
            // 
            // critLabel
            // 
            this.critLabel.AutoSize = true;
            this.critLabel.Location = new System.Drawing.Point(5, 174);
            this.critLabel.Name = "critLabel";
            this.critLabel.Size = new System.Drawing.Size(71, 13);
            this.critLabel.TabIndex = 9;
            this.critLabel.Text = "Critical Strike:";
            // 
            // classListBox
            // 
            this.classListBox.FormattingEnabled = true;
            this.classListBox.Items.AddRange(new object[] {
            "Death Knight",
            "Druid",
            "Hunter",
            "Mage",
            "Monk",
            "Paladin",
            "Priest",
            "Rogue",
            "Shaman",
            "Warlock",
            "Warrior"});
            this.classListBox.Location = new System.Drawing.Point(82, 67);
            this.classListBox.Name = "classListBox";
            this.classListBox.Size = new System.Drawing.Size(134, 21);
            this.classListBox.TabIndex = 3;
            this.classListBox.SelectedIndexChanged += new System.EventHandler(this.classListBox_SelectedIndexChanged);
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(41, 70);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(35, 13);
            this.classLabel.TabIndex = 11;
            this.classLabel.Text = "Class:";
            // 
            // raceListBox
            // 
            this.raceListBox.FormattingEnabled = true;
            this.raceListBox.Items.AddRange(new object[] {
            "Blood Elf",
            "Draenei",
            "Gnome",
            "Human",
            "Night Elf",
            "Orc",
            "Troll",
            "Worgen"});
            this.raceListBox.Location = new System.Drawing.Point(82, 38);
            this.raceListBox.Name = "raceListBox";
            this.raceListBox.Size = new System.Drawing.Size(134, 21);
            this.raceListBox.TabIndex = 2;
            this.raceListBox.SelectedIndexChanged += new System.EventHandler(this.raceListBox_SelectedIndexChanged);
            // 
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.Location = new System.Drawing.Point(40, 41);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(36, 13);
            this.raceLabel.TabIndex = 13;
            this.raceLabel.Text = "Race:";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(141, 268);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 8;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(475, 297);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 17;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // currentCharactersGrid
            // 
            this.currentCharactersGrid.AllowUserToAddRows = false;
            this.currentCharactersGrid.AllowUserToDeleteRows = false;
            this.currentCharactersGrid.AllowUserToResizeColumns = false;
            this.currentCharactersGrid.AllowUserToResizeRows = false;
            this.currentCharactersGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.currentCharactersGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.currentCharactersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentCharactersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CharacterName,
            this.CharacterRace,
            this.CharacterClass});
            this.currentCharactersGrid.Location = new System.Drawing.Point(245, 12);
            this.currentCharactersGrid.Name = "currentCharactersGrid";
            this.currentCharactersGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.currentCharactersGrid.RowHeadersVisible = false;
            this.currentCharactersGrid.Size = new System.Drawing.Size(305, 279);
            this.currentCharactersGrid.TabIndex = 18;
            this.currentCharactersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.currentCharactersGrid_CellContentClick);
            // 
            // classIcon
            // 
            this.classIcon.Location = new System.Drawing.Point(152, 198);
            this.classIcon.Name = "classIcon";
            this.classIcon.Size = new System.Drawing.Size(64, 64);
            this.classIcon.TabIndex = 19;
            this.classIcon.TabStop = false;
            // 
            // raceIcon
            // 
            this.raceIcon.Location = new System.Drawing.Point(82, 198);
            this.raceIcon.Name = "raceIcon";
            this.raceIcon.Size = new System.Drawing.Size(64, 64);
            this.raceIcon.TabIndex = 20;
            this.raceIcon.TabStop = false;
            // 
            // CharacterName
            // 
            this.CharacterName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CharacterName.HeaderText = "Name";
            this.CharacterName.Name = "CharacterName";
            this.CharacterName.ReadOnly = true;
            this.CharacterName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CharacterRace
            // 
            this.CharacterRace.HeaderText = "Race";
            this.CharacterRace.Name = "CharacterRace";
            // 
            // CharacterClass
            // 
            this.CharacterClass.HeaderText = "Class";
            this.CharacterClass.Name = "CharacterClass";
            this.CharacterClass.ReadOnly = true;
            this.CharacterClass.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(558, 328);
            this.Controls.Add(this.raceIcon);
            this.Controls.Add(this.classIcon);
            this.Controls.Add(this.currentCharactersGrid);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.raceLabel);
            this.Controls.Add(this.raceListBox);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.classListBox);
            this.Controls.Add(this.critLabel);
            this.Controls.Add(this.hitLabel);
            this.Controls.Add(this.defenceLabel);
            this.Controls.Add(this.staminaLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.critBox);
            this.Controls.Add(this.hitBox);
            this.Controls.Add(this.defenceBox);
            this.Controls.Add(this.staminaBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "Character Creation";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currentCharactersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raceIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox staminaBox;
        private System.Windows.Forms.TextBox defenceBox;
        private System.Windows.Forms.TextBox hitBox;
        private System.Windows.Forms.TextBox critBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label staminaLabel;
        private System.Windows.Forms.Label defenceLabel;
        private System.Windows.Forms.Label hitLabel;
        private System.Windows.Forms.Label critLabel;
        private System.Windows.Forms.ComboBox classListBox;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.ComboBox raceListBox;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridView currentCharactersGrid;
        private System.Windows.Forms.PictureBox classIcon;
        private System.Windows.Forms.PictureBox raceIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharacterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharacterRace;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharacterClass;
    }
}

